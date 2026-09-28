#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentSessionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agent-sessions", @"Agent Sessions endpoint commands.");
                         command.Subcommands.Add(AgentSessionsCreateAgentSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsCreateAgentSessionsBySessionIdEndCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsBySessionIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsBySessionIdRecordingCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}