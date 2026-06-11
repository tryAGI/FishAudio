#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class WalletGetWalletByUserIdApiCreditCommandApiCommand
{
    private static Argument<string?> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"User ID or 'self'",
    };

    private static Option<bool?> CheckFreeCredit { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--check-free-credit",
        description: @"");

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetWalletApiCreditResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetWalletApiCreditResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-wallet-by-user-id-api-credit", @"Get API Credit");
                        command.Arguments.Add(UserId);
                        command.Options.Add(CheckFreeCredit);
                        command.Options.Add(TeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                        var checkFreeCredit = parseResult.GetValue(CheckFreeCredit);
                        var teamId = parseResult.GetValue(TeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Wallet.GetWalletByUserIdApiCreditAsync(
                                    userId: userId,
                                    checkFreeCredit: checkFreeCredit,
                                    teamId: teamId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}