#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentSessionOverridesPayloadOptionSet(
    Option<string?> FirstMessage,
                     Option<string?> FirstMessagePrompt,
                     Option<string?> SystemPrompt,
                     Option<string?> VoiceId)
{
    public static AgentSessionOverridesPayloadOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentSessionOverridesPayloadOptionSet(
                        FirstMessage: new Option<string?>($"--{normalizedPrefix}first-message")
                {
                    Description = @"",
                },
                FirstMessagePrompt: new Option<string?>($"--{normalizedPrefix}first-message-prompt")
                {
                    Description = @"",
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"Limited to 4000 tokens (o200k_base), same budget as the configured prompt it replaces.",
                },
                VoiceId: new Option<string?>($"--{normalizedPrefix}voice-id")
                {
                    Description = @"",
                }
        );
    }
}