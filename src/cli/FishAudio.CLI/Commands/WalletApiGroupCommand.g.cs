#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class WalletApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"wallet", @"Wallet endpoint commands.");
                         command.Subcommands.Add(WalletGetWalletByUserIdApiCreditCommandApiCommand.Create());
                         command.Subcommands.Add(WalletGetWalletByUserIdPackageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}