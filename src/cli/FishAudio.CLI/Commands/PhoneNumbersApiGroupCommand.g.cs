#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class PhoneNumbersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"phone-numbers", @"Phone Numbers endpoint commands.");
                         command.Subcommands.Add(PhoneNumbersCreateAgentPhoneNumbersCommandApiCommand.Create());
                         command.Subcommands.Add(PhoneNumbersDeleteAgentPhoneNumbersByPhoneNumberIdCommandApiCommand.Create());
                         command.Subcommands.Add(PhoneNumbersEditAgentPhoneNumbersByPhoneNumberIdCommandApiCommand.Create());
                         command.Subcommands.Add(PhoneNumbersGetAgentAvailablePhoneNumbersCommandApiCommand.Create());
                         command.Subcommands.Add(PhoneNumbersGetAgentPhoneNumbersCommandApiCommand.Create());
                         command.Subcommands.Add(PhoneNumbersGetAgentPhoneNumbersByPhoneNumberIdCommandApiCommand.Create());
        return command;
    }
}