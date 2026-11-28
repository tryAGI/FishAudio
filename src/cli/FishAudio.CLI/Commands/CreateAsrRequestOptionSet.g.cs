#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record CreateAsrRequestOptionSet(
    Option<string> Audioname,
                     Option<string?> Language,
                     Option<bool?> IgnoreTimestamps)
{
    public static CreateAsrRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAsrRequestOptionSet(
                        Audioname: new Option<string>($"--{normalizedPrefix}audioname")
                {
                    Description = @"Audio file to be converted to text",
                    Required = true,
                },
                Language: new Option<string?>($"--{normalizedPrefix}language")
                {
                    Description = @"Optional hint. The language is auto-detected regardless; the detected language is returned as `language_code`.",
                },
                IgnoreTimestamps: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}ignore-timestamps", description: @"Whether to return precise timestamps in the text, this will increase the latency in audio shorter than 30 seconds")
        );
    }
}