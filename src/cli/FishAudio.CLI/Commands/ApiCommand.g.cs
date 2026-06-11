#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(ModelApiGroupCommand.Create());
                         command.Subcommands.Add(OpenAPIV1ApiGroupCommand.Create());
                         command.Subcommands.Add(WalletApiGroupCommand.Create());
        return command;
    }
}