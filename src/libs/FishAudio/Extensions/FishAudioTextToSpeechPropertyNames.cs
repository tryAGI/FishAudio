#nullable enable

namespace FishAudio;

/// <summary>
/// Fish Audio-specific <see cref="Microsoft.Extensions.AI.TextToSpeechOptions.AdditionalProperties"/> keys.
/// </summary>
public static class FishAudioTextToSpeechPropertyNames
{
    /// <summary>Multiple Fish Audio voice model IDs for multi-speaker synthesis.</summary>
    public const string ReferenceIds = "fish_audio_reference_ids";
    /// <summary>Sampling temperature for speech generation.</summary>
    public const string Temperature = "fish_audio_temperature";
    /// <summary>Nucleus sampling value for speech generation.</summary>
    public const string TopP = "fish_audio_top_p";
    /// <summary>Text chunk size used by Fish Audio during synthesis.</summary>
    public const string ChunkLength = "fish_audio_chunk_length";
    /// <summary>Whether Fish Audio should normalize input text.</summary>
    public const string Normalize = "fish_audio_normalize";
    /// <summary>Requested output sample rate in Hz.</summary>
    public const string SampleRate = "fish_audio_sample_rate";
    /// <summary>MP3 bitrate in kbps.</summary>
    public const string Mp3Bitrate = "fish_audio_mp3_bitrate";
    /// <summary>Opus bitrate in bps.</summary>
    public const string OpusBitrate = "fish_audio_opus_bitrate";
    /// <summary>Fish Audio latency-quality mode: normal, balanced, or low.</summary>
    public const string Latency = "fish_audio_latency";
    /// <summary>Maximum audio tokens to generate per text chunk.</summary>
    public const string MaxNewTokens = "fish_audio_max_new_tokens";
    /// <summary>Penalty used to reduce repeated audio patterns.</summary>
    public const string RepetitionPenalty = "fish_audio_repetition_penalty";
    /// <summary>Minimum characters before splitting into a new chunk.</summary>
    public const string MinChunkLength = "fish_audio_min_chunk_length";
    /// <summary>Whether previous generated chunks should condition following chunks.</summary>
    public const string ConditionOnPreviousChunks = "fish_audio_condition_on_previous_chunks";
    /// <summary>Early stopping threshold for batch processing.</summary>
    public const string EarlyStopThreshold = "fish_audio_early_stop_threshold";
    /// <summary>Whether S2-Pro output loudness should be normalized.</summary>
    public const string NormalizeLoudness = "fish_audio_normalize_loudness";
}
