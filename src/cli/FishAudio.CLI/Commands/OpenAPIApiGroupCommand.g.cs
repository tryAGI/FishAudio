#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"open-api", @"OpenAPI endpoint commands.");
                         command.Subcommands.Add(OpenAPICreateKeyRevokeCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}