#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneCallsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"phone-calls", @"Phone Calls endpoint commands.");
                         command.Subcommands.Add(PhoneCallsCreateAgentPhoneCallsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}