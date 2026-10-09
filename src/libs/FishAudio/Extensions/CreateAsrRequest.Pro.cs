#nullable enable

using System.Globalization;
using System.Text.Json.Serialization;

namespace FishAudio;

// The hosted OpenAPI schema omits these documented transcribe-1-pro fields.
public sealed partial class CreateAsrRequest
{
    /// <summary>Retain inline emotion and vocal-event cues. Pro defaults to true.</summary>
    [JsonPropertyName("tag_audio_events")]
    public bool? TagAudioEvents { get; set; }

    /// <summary>Speaker turns mode: auto, true, or false. Requires transcribe-1-pro.</summary>
    [JsonPropertyName("diarize")]
    public string? Diarize { get; set; }

    /// <summary>Expected speaker count, at least 1; mutually exclusive with bounds.</summary>
    [JsonPropertyName("num_speakers")]
    public int? NumSpeakers { get; set; }

    /// <summary>Minimum speaker count, at least 1.</summary>
    [JsonPropertyName("min_speakers")]
    public int? MinSpeakers { get; set; }

    /// <summary>Maximum speaker count, at least 1.</summary>
    [JsonPropertyName("max_speakers")]
    public int? MaxSpeakers { get; set; }
}

public sealed partial class OpenAPIV1Client
{
    partial void PrepareCreateAsrRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        CreateAsrModel? model,
        CreateAsrRequest request)
    {
        _ = ReadResponseAsString;
        if (request.TagAudioEvents is null && request.Diarize is null && request.NumSpeakers is null
            && request.MinSpeakers is null && request.MaxSpeakers is null)
        {
            return;
        }

        // Inspect the effective header, including per-request overrides.
        if (!httpRequestMessage.Headers.TryGetValues("model", out var models)
            || models.SingleOrDefault() != "transcribe-1-pro")
        {
            throw new ArgumentException("Speaker and audio-event options require transcribe-1-pro.", nameof(request));
        }

        if (request.Diarize is not (null or "auto" or "true" or "false")
            || request.NumSpeakers is < 1 || request.MinSpeakers is < 1 || request.MaxSpeakers is < 1
            || (request.NumSpeakers is not null && (request.MinSpeakers is not null || request.MaxSpeakers is not null))
            || request.MinSpeakers > request.MaxSpeakers
            || (request.Diarize == "false" && (request.NumSpeakers is not null || request.MinSpeakers is not null || request.MaxSpeakers is not null)))
        {
            throw new ArgumentException("Invalid Fish Audio speaker options.", nameof(request));
        }

        if (httpRequestMessage.Content is MultipartFormDataContent form)
        {
            Add("tag_audio_events", request.TagAudioEvents is { } tag ? (tag ? "true" : "false") : null);
            Add("diarize", request.Diarize);
            Add("num_speakers", request.NumSpeakers?.ToString(CultureInfo.InvariantCulture));
            Add("min_speakers", request.MinSpeakers?.ToString(CultureInfo.InvariantCulture));
            Add("max_speakers", request.MaxSpeakers?.ToString(CultureInfo.InvariantCulture));

            void Add(string name, string? value)
            {
                if (value is not null)
                {
#pragma warning disable CA2000 // Ownership transfers to the multipart form; failures dispose below.
                    var content = new StringContent(value);
#pragma warning restore CA2000
                    try
                    {
                        form.Add(content, name); // The form owns the content after a successful add.
                    }
                    catch
                    {
                        content.Dispose();
                        throw;
                    }
                }
            }
        }
    }
}
