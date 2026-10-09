#nullable enable

using System.Text.Json.Serialization;

namespace FishAudio;

public sealed partial class CreateAsrResponse
{
    /// <summary>Pro request identifier for diagnostics.</summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>Pro speaker turns, present when timestamps and diarization are enabled.</summary>
    [JsonPropertyName("speaker_turns")]
    public IReadOnlyList<ASRSpeakerTurn>? SpeakerTurns { get; set; }
}

/// <summary>A speaker turn. Labels identify speakers only within this response.</summary>
public sealed class ASRSpeakerTurn
{
    /// <summary>Response-local speaker label, for example speaker:0.</summary>
    [JsonPropertyName("speaker")]
    public required string Speaker { get; set; }

    /// <summary>Speech including emotion and vocal-event cues.</summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>Start time in seconds.</summary>
    [JsonPropertyName("start")]
    public double Start { get; set; }

    /// <summary>End time in seconds.</summary>
    [JsonPropertyName("end")]
    public double End { get; set; }
}
