#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentToolPreToolSpeechOptionSet(
    Option<global::FishAudio.AgentToolPreToolSpeechMode> Mode,
                     Option<string?> Message)
{
    public static AgentToolPreToolSpeechOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentToolPreToolSpeechOptionSet(
                        Mode: new Option<global::FishAudio.AgentToolPreToolSpeechMode>($"--{normalizedPrefix}mode")
                {
                    Description = @"",
                    Required = true,
                },
                Message: new Option<string?>($"--{normalizedPrefix}message")
                {
                    Description = @"What to say. Required, and only used, when `mode` is `static`.",
                }
        );
    }
}