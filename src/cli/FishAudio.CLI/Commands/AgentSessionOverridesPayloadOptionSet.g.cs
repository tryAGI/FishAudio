#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentSessionOverridesPayloadOptionSet(
    Option<string?> FirstMessage,
                     Option<string?> FirstMessagePrompt,
                     Option<int?> FirstMessageMaxWaitMs,
                     Option<bool?> FirstMessageInterruptible,
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
                FirstMessageMaxWaitMs: new Option<int?>($"--{normalizedPrefix}first-message-max-wait-ms")
                {
                    Description = @"Milliseconds (1000-5000) a `wait_for_caller` session waits before it speaks anyway, instead of the agent's `prompt.first_message_max_wait_ms`.",
                },
                FirstMessageInterruptible: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}first-message-interruptible", description: @"Whether the caller can cut the opener off in this session, instead of the agent's `prompt.first_message_interruptible`. `false` protects it: it always plays to the end and what the caller says meanwhile is dropped. Omit it or send `null` to keep the agent's value."),
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"Limited to 64000 tokens (o200k_base), 32000 when `llm.model` is `google/gemma-4-26b-a4b-it` (the agent's), same budget as the configured prompt it replaces.",
                },
                VoiceId: new Option<string?>($"--{normalizedPrefix}voice-id")
                {
                    Description = @"The voice this session speaks instead of the agent's: a Voice Library voice or one of your clones by id, or one of the live3 speech model's own voices by its lowercase name (clara, nora, ...). A name on a session that runs on Fish TTS speaks the Voice Library counterpart of that voice.",
                }
        );
    }
}