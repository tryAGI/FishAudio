#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentTestJudgeOptionSet(
    Option<string> Model)
{
    public static AgentTestJudgeOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentTestJudgeOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"One of the models `GET /v1/agent/llm-models` lists with `test_judge`.",
                    Required = true,
                }
        );
    }
}