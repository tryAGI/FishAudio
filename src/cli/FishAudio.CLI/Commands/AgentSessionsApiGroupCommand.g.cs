#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class AgentSessionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agent-sessions", @"Agent Sessions endpoint commands.");
                         command.Subcommands.Add(AgentSessionsCreateAgentSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsCreateAgentSessionsBySessionIdEndCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsBySessionIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentSessionsGetAgentSessionsBySessionIdRecordingCommandApiCommand.Create());
        return command;
    }
}