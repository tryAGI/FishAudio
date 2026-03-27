#nullable enable

using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace FishAudio;

public sealed partial class FishAudioClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("fish-audio", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        var request = options?.RawRepresentationFactory?.Invoke(this) as CreateAsrRequest
            ?? new CreateAsrRequest
            {
                Audio = [],
                Audioname = "audio.wav",
            };

        if (request.Audio is null || request.Audio.Length == 0)
        {
            MemoryStream? ms = audioSpeechStream as MemoryStream;
            if (ms is null || ms.Position != 0)
            {
                ms = new MemoryStream();
                await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            }

            request.Audio = ms.TryGetBuffer(out ArraySegment<byte> buffer)
                && buffer.Array is not null && buffer.Offset == 0 && buffer.Count == ms.Length
                    ? buffer.Array
                    : ms.ToArray();
        }

        request.Audioname ??= "audio.wav";

        // Map MEAI options
        if (options?.SpeechLanguage is { Length: > 0 } language)
        {
            request.Language ??= language;
        }

        // Request timestamps by default (set IgnoreTimestamps = false)
        request.IgnoreTimestamps ??= false;

        var response = await OpenAPIV1.CreateAsrAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        TimeSpan? startTime = null;
        TimeSpan? endTime = null;
        if (response.Segments is { Count: > 0 } segments)
        {
            startTime = TimeSpan.FromSeconds(segments[0].Start);
            endTime = TimeSpan.FromSeconds(segments[^1].End);
        }
        else if (response.Duration is > 0)
        {
            startTime = TimeSpan.Zero;
            endTime = TimeSpan.FromSeconds(response.Duration);
        }

        return new SpeechToTextResponse(response.Text)
        {
            RawRepresentation = response,
            StartTime = startTime,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        // Fish Audio ASR is synchronous — delegate to non-streaming
        var response = await ((ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}
