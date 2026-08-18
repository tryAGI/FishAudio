#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class PhoneCallsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"phone-calls", @"Phone Calls endpoint commands.");
                         command.Subcommands.Add(PhoneCallsCreateAgentPhoneCallsCommandApiCommand.Create());
        return command;
    }
}