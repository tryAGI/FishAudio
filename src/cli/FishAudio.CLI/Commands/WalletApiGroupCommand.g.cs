#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static class WalletApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"wallet", @"Wallet endpoint commands.");
                         command.Subcommands.Add(WalletGetWalletByUserIdApiCreditCommandApiCommand.Create());
                         command.Subcommands.Add(WalletGetWalletByUserIdPackageCommandApiCommand.Create());
        return command;
    }
}