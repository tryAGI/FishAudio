#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal sealed record AgentTestSimulationConfigOptionSet(
    Option<string> Scenario,
                     Option<int?> MaxTurns,
                     Option<string?> SimulatedUserModel,
                     Option<int?> RepeatCount)
{
    public static AgentTestSimulationConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AgentTestSimulationConfigOptionSet(
                        Scenario: new Option<string>($"--{normalizedPrefix}scenario")
                {
                    Description = @"",
                    Required = true,
                },
                MaxTurns: new Option<int?>($"--{normalizedPrefix}max-turns")
                {
                    Description = @"",
                },
                SimulatedUserModel: new Option<string?>($"--{normalizedPrefix}simulated-user-model")
                {
                    Description = @"",
                },
                RepeatCount: new Option<int?>($"--{normalizedPrefix}repeat-count")
                {
                    Description = @"",
                }
        );
    }
}