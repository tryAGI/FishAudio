#nullable enable
#pragma warning disable MEAI001

using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.AI;

namespace FishAudio;

public sealed partial class FishAudioClient : ITextToSpeechClient
{
    private const string DefaultTextToSpeechModel = "s2.1-pro-free";
    private TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("fish-audio", new Uri(DefaultBaseUrl), DefaultTextToSpeechModel)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<TextToSpeechResponse> ITextToSpeechClient.GetAudioAsync(
        string text,
        TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var resolved = ResolveTextToSpeechOptions(options);
        var request = CreateTtsRequest(text, options, resolved);
        using var httpRequest = CreateTtsHttpRequest(request, resolved);
        using var response = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseContentRead,
            cancellationToken).ConfigureAwait(false);

        ProcessResponse(HttpClient, response);
        await ThrowIfNotSuccessAsync(response, cancellationToken).ConfigureAwait(false);

        var audio = await response.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
        var responseId = TryGetHeader(response, "request-id") ?? TryGetHeader(response, "x-request-id");

        return new TextToSpeechResponse([
            new DataContent(audio, resolved.MediaType),
        ])
        {
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(resolved, responseId),
        };
    }

    async IAsyncEnumerable<TextToSpeechResponseUpdate> ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var resolved = ResolveTextToSpeechOptions(options);
        var request = CreateTtsStreamRequest(text, options, resolved);
        var responseId = Guid.NewGuid().ToString("N");

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(resolved),
        };

        using var modelHeaderOverride = OpenAPIV1Client.UseCreateTtsStreamWithTimestampModelHeader(resolved.ModelId);
        await foreach (var @event in OpenAPIV1.CreateTtsStreamWithTimestampAsync(
            request: request,
            model: CreateTtsStreamWithTimestampModel.S2Pro,
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            yield return new TextToSpeechResponseUpdate([
                new DataContent(Convert.FromBase64String(@event.AudioBase64), resolved.MediaType),
            ])
            {
                Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                ResponseId = responseId,
                ModelId = resolved.ModelId,
                RawRepresentation = @event,
                AdditionalProperties = CreateResponseProperties(
                    resolved,
                    responseId,
                    @event.ChunkSeq,
                    @event.Content),
            };
        }

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.AudioUpdated,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
            AdditionalProperties = CreateResponseProperties(resolved, responseId),
        };

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = responseId,
            ModelId = resolved.ModelId,
        };
    }

    private TTSRequest CreateTtsRequest(
        string text,
        TextToSpeechOptions? options,
        ResolvedFishAudioTextToSpeechOptions resolved)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as TTSRequest
            ?? new TTSRequest
            {
                Text = text,
            };

        if (string.IsNullOrWhiteSpace(request.Text))
        {
            request.Text = text;
        }

        ApplyCommonOptions(request, options, resolved);
        return request;
    }

    private TTSStreamWithTimestampRequest CreateTtsStreamRequest(
        string text,
        TextToSpeechOptions? options,
        ResolvedFishAudioTextToSpeechOptions resolved)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as TTSStreamWithTimestampRequest
            ?? new TTSStreamWithTimestampRequest
            {
                Text = text,
            };

        if (string.IsNullOrWhiteSpace(request.Text))
        {
            request.Text = text;
        }

        ApplyCommonOptions(request, options, resolved);
        return request;
    }

    private static void ApplyCommonOptions(
        TTSRequest request,
        TextToSpeechOptions? options,
        ResolvedFishAudioTextToSpeechOptions resolved)
    {
        if (request.ReferenceId is null && CreateReferenceId(options) is { } referenceId)
        {
            request.ReferenceId = referenceId;
        }

        request.Format ??= resolved.RequestFormat;
        request.SampleRate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.SampleRate);
        request.Mp3Bitrate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.Mp3Bitrate);
        request.OpusBitrate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.OpusBitrate);
        request.Temperature ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.Temperature);
        request.TopP ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.TopP);
        request.ChunkLength ??= options.GetInt(FishAudioTextToSpeechPropertyNames.ChunkLength);
        request.Normalize ??= options.GetBool(FishAudioTextToSpeechPropertyNames.Normalize);
        request.Latency ??= ResolveLatency(options.GetString(FishAudioTextToSpeechPropertyNames.Latency));
        request.MaxNewTokens ??= options.GetInt(FishAudioTextToSpeechPropertyNames.MaxNewTokens);
        request.RepetitionPenalty ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.RepetitionPenalty);
        request.MinChunkLength ??= options.GetInt(FishAudioTextToSpeechPropertyNames.MinChunkLength);
        request.ConditionOnPreviousChunks ??= options.GetBool(FishAudioTextToSpeechPropertyNames.ConditionOnPreviousChunks);
        request.EarlyStopThreshold ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.EarlyStopThreshold);
        request.Prosody = CreateProsody(request.Prosody, options);
    }

    private static void ApplyCommonOptions(
        TTSStreamWithTimestampRequest request,
        TextToSpeechOptions? options,
        ResolvedFishAudioTextToSpeechOptions resolved)
    {
        if (request.ReferenceId is null && CreateReferenceId(options) is { } referenceId)
        {
            request.ReferenceId = referenceId;
        }

        request.Format ??= resolved.StreamFormat;
        request.SampleRate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.SampleRate);
        request.Mp3Bitrate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.Mp3Bitrate);
        request.OpusBitrate ??= options.GetInt(FishAudioTextToSpeechPropertyNames.OpusBitrate);
        request.Temperature ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.Temperature);
        request.TopP ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.TopP);
        request.ChunkLength ??= options.GetInt(FishAudioTextToSpeechPropertyNames.ChunkLength);
        request.Normalize ??= options.GetBool(FishAudioTextToSpeechPropertyNames.Normalize);
        request.Latency ??= ResolveStreamLatency(options.GetString(FishAudioTextToSpeechPropertyNames.Latency));
        request.MaxNewTokens ??= options.GetInt(FishAudioTextToSpeechPropertyNames.MaxNewTokens);
        request.RepetitionPenalty ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.RepetitionPenalty);
        request.MinChunkLength ??= options.GetInt(FishAudioTextToSpeechPropertyNames.MinChunkLength);
        request.ConditionOnPreviousChunks ??= options.GetBool(FishAudioTextToSpeechPropertyNames.ConditionOnPreviousChunks);
        request.EarlyStopThreshold ??= options.GetDouble(FishAudioTextToSpeechPropertyNames.EarlyStopThreshold);
        request.Prosody = CreateProsody(request.Prosody, options);
    }

    private HttpRequestMessage CreateTtsHttpRequest(
        TTSRequest request,
        ResolvedFishAudioTextToSpeechOptions resolved)
    {
        var baseUri = HttpClient.BaseAddress ?? new Uri(DefaultBaseUrl);
        var httpRequest = new HttpRequestMessage(HttpMethod.Post, new Uri(baseUri, "/v1/tts"))
        {
            Content = new StringContent(
                request.ToJson(JsonSerializerContext),
                Encoding.UTF8,
                "application/json"),
        };

        httpRequest.Headers.TryAddWithoutValidation("model", resolved.ModelId);
        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ResolveBearerApiKey());
        AutoSDKRequestOptionsSupport.ApplyHeaders(
            request: httpRequest,
            clientHeaders: Options.Headers,
            requestHeaders: null);
        PrepareRequest(HttpClient, httpRequest);

        return httpRequest;
    }

    private string ResolveBearerApiKey()
    {
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var authorization = Authorizations[i];
            if (authorization is { Type: "Http", Value.Length: > 0 }
                && string.Equals(authorization.Name, "Bearer", StringComparison.OrdinalIgnoreCase))
            {
                return authorization.Value;
            }
        }

        throw new InvalidOperationException("No API key found in FishAudioClient.Authorizations. Ensure the client was created with an API key.");
    }

    private static async Task ThrowIfNotSuccessAsync(
        HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        if (response.IsSuccessStatusCode)
        {
            return;
        }

        string? responseBody = null;
        Exception? readException = null;
        try
        {
            responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (HttpRequestException ex)
        {
            readException = ex;
        }
        catch (IOException ex)
        {
            readException = ex;
        }

        throw ApiException.Create(
            response.StatusCode,
            responseBody ?? response.ReasonPhrase ?? string.Empty,
            readException,
            responseBody,
            AutoSDKHttpResponse.CreateHeaders(response));
    }

    private static ResolvedFishAudioTextToSpeechOptions ResolveTextToSpeechOptions(TextToSpeechOptions? options)
    {
        var modelId = options?.ModelId is { Length: > 0 } modelIdValue
            ? modelIdValue
            : DefaultTextToSpeechModel;
        var (requestFormat, streamFormat, mediaType) = ResolveFormat(options?.AudioFormat);

        return new ResolvedFishAudioTextToSpeechOptions(
            modelId,
            requestFormat,
            streamFormat,
            mediaType);
    }

    private static (TTSRequestFormat RequestFormat, TTSStreamWithTimestampRequestFormat StreamFormat, string MediaType) ResolveFormat(string? format)
    {
        if (format is not { Length: > 0 })
        {
            return (TTSRequestFormat.Mp3, TTSStreamWithTimestampRequestFormat.Mp3, "audio/mpeg");
        }

        if (string.Equals(format, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            return (TTSRequestFormat.Mp3, TTSStreamWithTimestampRequestFormat.Mp3, "audio/mpeg");
        }

        if (string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase))
        {
            return (TTSRequestFormat.Wav, TTSStreamWithTimestampRequestFormat.Wav, "audio/wav");
        }

        if (string.Equals(format, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm_s16le", StringComparison.OrdinalIgnoreCase))
        {
            return (TTSRequestFormat.Pcm, TTSStreamWithTimestampRequestFormat.Pcm, "audio/pcm;codec=s16le");
        }

        if (string.Equals(format, "audio/ogg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/opus", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "opus", StringComparison.OrdinalIgnoreCase))
        {
            return (TTSRequestFormat.Opus, TTSStreamWithTimestampRequestFormat.Opus, "audio/ogg;codecs=opus");
        }

        throw new NotSupportedException($"Unsupported Fish Audio TTS audio format '{format}'. Use 'mp3', 'wav', 'pcm', or 'opus'.");
    }

    private static AnyOf<string, IList<string>, object>? CreateReferenceId(TextToSpeechOptions? options)
    {
        if (options.GetStringList(FishAudioTextToSpeechPropertyNames.ReferenceIds) is { Count: > 0 } referenceIds)
        {
            return AnyOf<string, IList<string>, object>.FromValue2(referenceIds.ToArray());
        }

        if (options?.VoiceId is { Length: > 0 } voiceId)
        {
            return AnyOf<string, IList<string>, object>.FromValue1(voiceId);
        }

        return null;
    }

    private static ProsodyControl? CreateProsody(ProsodyControl? prosody, TextToSpeechOptions? options)
    {
        var speed = options?.Speed;
        var volume = options?.Volume;
        var normalizeLoudness = options.GetBool(FishAudioTextToSpeechPropertyNames.NormalizeLoudness);

        if (prosody is null && speed is null && volume is null && normalizeLoudness is null)
        {
            return null;
        }

        prosody ??= new ProsodyControl();
        prosody.Speed ??= speed;
        prosody.Volume ??= volume;
        prosody.NormalizeLoudness ??= normalizeLoudness;
        return prosody;
    }

    private static TTSRequestLatency? ResolveLatency(string? value)
    {
        return value is { Length: > 0 }
            ? TTSRequestLatencyExtensions.ToEnum(value)
                ?? throw new ArgumentException($"Unknown Fish Audio TTS latency value '{value}'.", nameof(value))
            : null;
    }

    private static TTSStreamWithTimestampRequestLatency? ResolveStreamLatency(string? value)
    {
        return value is { Length: > 0 }
            ? TTSStreamWithTimestampRequestLatencyExtensions.ToEnum(value)
                ?? throw new ArgumentException($"Unknown Fish Audio TTS latency value '{value}'.", nameof(value))
            : null;
    }

    private static AdditionalPropertiesDictionary CreateResponseProperties(
        ResolvedFishAudioTextToSpeechOptions resolved,
        string? responseId = null,
        int? chunkSeq = null,
        string? content = null)
    {
        AdditionalPropertiesDictionary properties = new()
        {
            ["model_id"] = resolved.ModelId,
            ["media_type"] = resolved.MediaType,
        };

        if (responseId is { Length: > 0 })
        {
            properties["request_id"] = responseId;
        }

        if (chunkSeq is { } chunkSeqValue)
        {
            properties["chunk_seq"] = chunkSeqValue;
        }

        if (content is { Length: > 0 })
        {
            properties["content"] = content;
        }

        return properties;
    }

    private static string? TryGetHeader(HttpResponseMessage response, string name)
    {
        return response.Headers.TryGetValues(name, out var values)
            ? values.FirstOrDefault()
            : response.Content.Headers.TryGetValues(name, out values)
                ? values.FirstOrDefault()
                : null;
    }

    private sealed record ResolvedFishAudioTextToSpeechOptions(
        string ModelId,
        TTSRequestFormat RequestFormat,
        TTSStreamWithTimestampRequestFormat StreamFormat,
        string MediaType);
}

public sealed partial class OpenAPIV1Client
{
    private static readonly AsyncLocal<string?> s_createTtsStreamWithTimestampModelHeader = new();

    internal static IDisposable UseCreateTtsStreamWithTimestampModelHeader(string modelId)
    {
        var previous = s_createTtsStreamWithTimestampModelHeader.Value;
        s_createTtsStreamWithTimestampModelHeader.Value = modelId;
        return new CreateTtsStreamWithTimestampModelHeaderScope(previous);
    }

    partial void PrepareCreateTtsStreamWithTimestampRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        CreateTtsStreamWithTimestampModel model,
        TTSStreamWithTimestampRequest request)
    {
        _ = ReadResponseAsString;
        if (s_createTtsStreamWithTimestampModelHeader.Value is { Length: > 0 } modelId)
        {
            httpRequestMessage.Headers.Remove("model");
            httpRequestMessage.Headers.TryAddWithoutValidation("model", modelId);
        }
    }

    private sealed class CreateTtsStreamWithTimestampModelHeaderScope(string? previous) : IDisposable
    {
        public void Dispose()
        {
            s_createTtsStreamWithTimestampModelHeader.Value = previous;
        }
    }
}

internal static class FishAudioTextToSpeechOptionsExtensions
{
    public static bool? GetBool(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static double? GetDouble(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            double doubleValue => doubleValue,
            float floatValue => floatValue,
            int intValue => intValue,
            long longValue => longValue,
            string text when double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };
    }

    public static int? GetInt(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            int intValue => intValue,
            long longValue when longValue is >= int.MinValue and <= int.MaxValue => (int)longValue,
            string text when int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
            _ => null,
        };
    }

    public static string? GetString(this TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }

    public static IReadOnlyList<string>? GetStringList(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            string text when text.Length > 0 => [text],
            IEnumerable<string> values => values.Where(static text => text.Length > 0).ToArray(),
            _ => null,
        };
    }
}
