#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class ModelApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"model", @"Model endpoint commands.");
                         command.Subcommands.Add(ModelCreateModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelCreateModelWithMessagePackCommandApiCommand.Create());
                         command.Subcommands.Add(ModelDeleteModelByIdCommandApiCommand.Create());
                         command.Subcommands.Add(ModelEditModelByIdCommandApiCommand.Create());
                         command.Subcommands.Add(ModelEditModelByIdWithMessagePackCommandApiCommand.Create());
                         command.Subcommands.Add(ModelGetModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelGetModelByIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}