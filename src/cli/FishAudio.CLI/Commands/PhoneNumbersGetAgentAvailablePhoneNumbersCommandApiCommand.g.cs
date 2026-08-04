#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersGetAgentAvailablePhoneNumbersCommandApiCommand
{
    private static Option<string?> CountryCode { get; } = new(
        name: @"--country-code")
    {
        Description = @"ISO 3166-1 alpha-2 country code.",
    };

    private static Option<string?> AreaCode { get; } = new(
        name: @"--area-code")
    {
        Description = @"Restrict to one area code, e.g. 415.",
    };

    private static Option<global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?> NumberType { get; } = new(
        name: @"--number-type")
    {
        Description = @"The managed inventory is US local numbers only; `toll_free` currently returns 400.",
    };

    private static Option<string?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"Inventory to search. Only the managed `twilio` inventory (call-transfer support) is available; the parameter is kept so importing your own numbers can extend it later.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentAvailablePhoneNumbersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentAvailablePhoneNumbersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-agent-available-phone-numbers", @"Search Available Phone Numbers
Search the purchasable number inventory. Buy an entry with
`POST /v1/agent/phone-numbers`; availability is not a reservation, so a listed
number can still be claimed by someone else first.");
                        command.Options.Add(CountryCode);
                        command.Options.Add(AreaCode);
                        command.Options.Add(NumberType);
                        command.Options.Add(Provider);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var countryCode = parseResult.GetValue(CountryCode);
                        var areaCode = parseResult.GetValue(AreaCode);
                        var numberType = parseResult.GetValue(NumberType);
                        var provider = parseResult.GetValue(Provider);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneNumbers.GetAgentAvailablePhoneNumbersAsync(
                                    countryCode: countryCode,
                                    areaCode: areaCode,
                                    numberType: numberType,
                                    provider: provider,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"AvailablePhoneNumbers",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}