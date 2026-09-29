#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentSessionsCreateAgentSessionsBySessionIdEndCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-agent-sessions-by-session-id-end", @"End Agent Session
Hang up a live session: the agent disconnects and the call terminates. The
session record, transcript, and recording are retained and stay readable.");
                        command.Arguments.Add(SessionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.AgentSessions.CreateAgentSessionsBySessionIdEndAsync(
                                    sessionId: sessionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}