#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record ProsodyControlOptionSet(
    Option<double?> Speed,
                     Option<double?> Volume,
                     Option<bool?> NormalizeLoudness)
{
    public static ProsodyControlOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ProsodyControlOptionSet(
                        Speed: new Option<double?>($"--{normalizedPrefix}speed")
                {
                    Description = @"Speaking rate multiplier. Valid range: 0.5 to 2.0. 1.0 = normal speed, 0.5 = half speed, 2.0 = double speed. Useful for adjusting pacing without regenerating audio.",
                },
                Volume: new Option<double?>($"--{normalizedPrefix}volume")
                {
                    Description = @"Volume adjustment in decibels (dB). 0 = no change, positive values = louder, negative values = quieter.",
                },
                NormalizeLoudness: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}normalize-loudness", description: @"Normalize output loudness for more consistent perceived volume. **S2-Pro only.**")
        );
    }
}