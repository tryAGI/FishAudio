#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record TTSStreamWithTimestampRequestOptionSet(
    Option<string> Text,
                     Option<double?> Temperature,
                     Option<double?> TopP,
                     Option<int?> ChunkLength,
                     Option<bool?> Normalize,
                     Option<string?> Language,
                     Option<global::FishAudio.TTSStreamWithTimestampRequestFormat?> Format,
                     Option<int?> SampleRate,
                     Option<int?> Mp3Bitrate,
                     Option<int?> OpusBitrate,
                     Option<global::FishAudio.TTSStreamWithTimestampRequestLatency?> Latency,
                     Option<int?> MaxNewTokens,
                     Option<double?> RepetitionPenalty,
                     Option<int?> MinChunkLength,
                     Option<bool?> ConditionOnPreviousChunks,
                     Option<double?> EarlyStopThreshold,
                     Option<global::System.Collections.Generic.IList<string>?> Features)
{
    public static TTSStreamWithTimestampRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new TTSStreamWithTimestampRequestOptionSet(
                        Text: new Option<string>($"--{normalizedPrefix}text")
                {
                    Description = @"Text to convert to speech.",
                    Required = true,
                },
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"Controls expressiveness. Higher is more varied, lower is more consistent.",
                },
                TopP: new Option<double?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"Controls diversity via nucleus sampling.",
                },
                ChunkLength: new Option<int?>($"--{normalizedPrefix}chunk-length")
                {
                    Description = @"Text segment size for processing.",
                },
                Normalize: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}normalize", description: @"Rewrites numbers, dates, units and symbols as spoken words before synthesis, improving stability. Uses `language` when it is set and otherwise detects the language of each text chunk."),
                Language: new Option<string?>($"--{normalizedPrefix}language")
                {
                    Description = @"BCP-47 language tag of the text, for example `en`, `es-MX` or `zh-CN`. Case-insensitive, and `_` is read as `-`. Used only by text normalization (how numbers, dates, units and symbols are spelled out before synthesis) and by word-timestamp alignment. It is not passed to the speech model and does not change the voice, accent or audio quality; a wrong tag only changes how those tokens are spelled out. Omit it, or send `auto` or an empty string, to detect the language per chunk. A tag without dedicated normalization rules skips normalization instead of failing. Without a region, Spanish follows Spain conventions; send `es-MX` for Mexican readings. When `normalize` is false it only affects word timestamps. For text that mixes languages, leave it unset.",
                },
                Format: new Option<global::FishAudio.TTSStreamWithTimestampRequestFormat?>($"--{normalizedPrefix}format")
                {
                    Description = @"Output audio format.",
                },
                SampleRate: new Option<int?>($"--{normalizedPrefix}sample-rate")
                {
                    Description = @"Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).",
                },
                Mp3Bitrate: new Option<int?>($"--{normalizedPrefix}mp3-bitrate")
                {
                    Description = @"MP3 bitrate in kbps. Only applies when format is mp3.",
                },
                OpusBitrate: new Option<int?>($"--{normalizedPrefix}opus-bitrate")
                {
                    Description = @"Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.",
                },
                Latency: new Option<global::FishAudio.TTSStreamWithTimestampRequestLatency?>($"--{normalizedPrefix}latency")
                {
                    Description = @"Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.",
                },
                MaxNewTokens: new Option<int?>($"--{normalizedPrefix}max-new-tokens")
                {
                    Description = @"Maximum audio tokens to generate per text chunk.",
                },
                RepetitionPenalty: new Option<double?>($"--{normalizedPrefix}repetition-penalty")
                {
                    Description = @"Penalty for repeating audio patterns. Values above 1.0 reduce repetition.",
                },
                MinChunkLength: new Option<int?>($"--{normalizedPrefix}min-chunk-length")
                {
                    Description = @"Minimum characters before splitting into a new chunk.",
                },
                ConditionOnPreviousChunks: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}condition-on-previous-chunks", description: @"Use previous audio as context for voice consistency."),
                EarlyStopThreshold: new Option<double?>($"--{normalizedPrefix}early-stop-threshold")
                {
                    Description = @"Early stopping threshold for batch processing.",
                },
                Features: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}features")
                {
                    Description = @"Optional request-scoped TTS feature flags forwarded verbatim to the inference backend. Use [""quality-guard""] to enable the quality guard for this synthesis request. Feature availability is determined by the inference backend.",
                }
        );
    }
}