#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsPutAgentAgentsByAgentIdTestsByTestIdCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Argument<string> TestId { get; } = new(
        name: @"test-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"put-agent-agents-by-agent-id-tests-by-test-id", @"Attach Test
Attach a test to an agent so the agent's test runs include it. Attaching
an attached test does nothing. The agent and the test must be in the same
workspace.");
                        command.Arguments.Add(AgentId);
                        command.Arguments.Add(TestId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var testId = parseResult.GetRequiredValue(TestId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.AgentTests.PutAgentAgentsByAgentIdTestsByTestIdAsync(
                                    agentId: agentId,
                                    testId: testId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}