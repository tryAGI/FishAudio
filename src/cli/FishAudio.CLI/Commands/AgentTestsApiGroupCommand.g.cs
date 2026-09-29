#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agent-tests", @"Agent Tests endpoint commands.");
                         command.Subcommands.Add(AgentTestsCreateAgentAgentsByAgentIdTestsRunCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsCreateAgentTestsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsDeleteAgentAgentsByAgentIdTestsByTestIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsDeleteAgentTestsByTestIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsEditAgentTestsByTestIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentAgentsByAgentIdTestBatchesCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentAgentsByAgentIdTestBatchesByBatchIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentAgentsByAgentIdTestToolsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentTestRunsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentTestRunsByRunIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentTestsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsGetAgentTestsByTestIdCommandApiCommand.Create());
                         command.Subcommands.Add(AgentTestsPutAgentAgentsByAgentIdTestsByTestIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}