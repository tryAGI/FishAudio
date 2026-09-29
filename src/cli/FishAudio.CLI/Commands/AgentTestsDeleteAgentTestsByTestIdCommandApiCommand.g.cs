#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsDeleteAgentTestsByTestIdCommandApiCommand
{
    private static Argument<string> TestId { get; } = new(
        name: @"test-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-agent-tests-by-test-id", @"Delete Test
Delete a test and detach it from every agent. Its past runs stay readable.");
                        command.Arguments.Add(TestId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var testId = parseResult.GetRequiredValue(TestId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.AgentTests.DeleteAgentTestsByTestIdAsync(
                                    testId: testId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}