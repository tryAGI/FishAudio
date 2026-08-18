#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AgentSessionsApiGroupCommand.Create());
                         command.Subcommands.Add(AgentToolsApiGroupCommand.Create());
                         command.Subcommands.Add(AgentsApiGroupCommand.Create());
                         command.Subcommands.Add(KnowledgeSourcesApiGroupCommand.Create());
                         command.Subcommands.Add(ModelApiGroupCommand.Create());
                         command.Subcommands.Add(OpenAPIV1ApiGroupCommand.Create());
                         command.Subcommands.Add(PhoneCallsApiGroupCommand.Create());
                         command.Subcommands.Add(PhoneNumbersApiGroupCommand.Create());
                         command.Subcommands.Add(WalletApiGroupCommand.Create());
        return command;
    }
}