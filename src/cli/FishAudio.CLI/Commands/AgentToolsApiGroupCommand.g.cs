#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class AgentToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agent-tools", @"Agent Tools endpoint commands.");
                         command.Subcommands.Add(AgentToolsCreateAgentToolsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsDeleteAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsEditAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsByToolIdAgentsCommandApiCommand.Create());
        return command;
    }
}