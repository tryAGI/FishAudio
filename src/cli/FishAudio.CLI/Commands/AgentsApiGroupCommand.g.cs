#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class AgentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agents", @"Agents endpoint commands.");
                         command.Subcommands.Add(AgentsCreateAgentAgentsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentAgentsByAgentIdPublishCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentAgentsByAgentIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsEditAgentAgentsByAgentIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsEditAgentAgentsByAgentIdConfigCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsByAgentIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsByAgentIdConfigCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsByAgentIdVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsByAgentIdVersionsByVersionNumberCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetAgentAgentsByAgentIdWidgetCommandApiCommand.Create());
        return command;
    }
}