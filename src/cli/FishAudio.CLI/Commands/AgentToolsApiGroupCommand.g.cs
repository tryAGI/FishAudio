#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentToolsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agent-tools", @"Agent Tools endpoint commands.");
                         command.Subcommands.Add(AgentToolsCreateAgentToolsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsDeleteAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsEditAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsByToolIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentToolsGetAgentToolsByToolIdAgentsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}