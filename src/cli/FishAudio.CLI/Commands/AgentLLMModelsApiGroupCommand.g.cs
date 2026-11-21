#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentLLMModelsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"agent-llm-models", @"Agent LLM Models endpoint commands.");
                         command.Subcommands.Add(AgentLlmModelsGetAgentLlmModelsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}