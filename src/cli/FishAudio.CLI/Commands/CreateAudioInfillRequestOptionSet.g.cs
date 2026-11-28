#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record CreateAudioInfillRequestOptionSet(
    Option<string> Transcript,
                     Option<string?> Audioname,
                     Option<int?> PrefixFrames,
                     Option<double?> PrefixSeconds,
                     Option<int?> SuffixFrames,
                     Option<double?> SuffixSeconds,
                     Option<string?> PrefixAudioname,
                     Option<string?> SuffixAudioname,
                     Option<global::FishAudio.CreateAudioInfillRequestFormat?> Format,
                     Option<int?> SampleRate,
                     Option<int?> Mp3Bitrate,
                     Option<int?> OpusBitrate)
{
    public static CreateAudioInfillRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAudioInfillRequestOptionSet(
                        Transcript: new Option<string>($"--{normalizedPrefix}transcript")
                {
                    Description = @"The full text of the result: the kept audio before the change, the new span and the kept audio after it, with the edit already applied. Sent to the model as written, without text normalization.",
                    Required = true,
                },
                Audioname: new Option<string?>($"--{normalizedPrefix}audioname")
                {
                    Description = @"Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.",
                },
                PrefixFrames: new Option<int?>($"--{normalizedPrefix}prefix-frames")
                {
                    Description = @"Edit a take: the frame where the regenerated span starts. Everything before it is kept. A whole number of frames at 44100 / 2048 (about 21.53) frames per second; 0 keeps nothing before the span. Give this or `prefix_seconds`, not both.",
                },
                PrefixSeconds: new Option<double?>($"--{normalizedPrefix}prefix-seconds")
                {
                    Description = @"Edit a take: `prefix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `prefix_frames`, not both.",
                },
                SuffixFrames: new Option<int?>($"--{normalizedPrefix}suffix-frames")
                {
                    Description = @"Edit a take: the frame where the regenerated span ends and the kept audio resumes. Equal to `prefix_frames` inserts new speech at that point; the take's length keeps nothing after the span. Give this or `suffix_seconds`, not both.",
                },
                SuffixSeconds: new Option<double?>($"--{normalizedPrefix}suffix-seconds")
                {
                    Description = @"Edit a take: `suffix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `suffix_frames`, not both.",
                },
                PrefixAudioname: new Option<string?>($"--{normalizedPrefix}prefix-audioname")
                {
                    Description = @"Join two clips: the clip before the generated speech. Alone, the model continues it.",
                },
                SuffixAudioname: new Option<string?>($"--{normalizedPrefix}suffix-audioname")
                {
                    Description = @"Join two clips: the clip after the generated speech. Requires `prefix_audio`.",
                },
                Format: new Option<global::FishAudio.CreateAudioInfillRequestFormat?>($"--{normalizedPrefix}format")
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
                }
        );
    }
}