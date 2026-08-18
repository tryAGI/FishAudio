#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PhoneNumbersGetAgentPhoneNumbersCommandApiCommand
{
    private static Option<string?> PhoneNumber { get; } = new(
        name: @"--phone-number")
    {
        Description = @"Exact E.164 match, e.g. +14155550123.",
    };

    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Only numbers bound to this agent.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"",
    };

    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"1-based page number; mutually exclusive with cursor.",
    };

    private static Option<bool?> IncludeTotal { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-total",
        description: @"");

    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentPhoneNumbersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentPhoneNumbersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-agent-phone-numbers", @"List Phone Numbers
List your team's phone numbers, newest first. Released numbers are gone
for good and never appear. Look an id up by E.164 with `phone_number`, or
filter with `agent_id` to see one agent's numbers. Paginate with `cursor`
(follow `next_cursor` while `has_more` is true) or with `page` for offset
pagination with a `total` count; the two are mutually exclusive.");
                        command.Options.Add(PhoneNumber);
                        command.Options.Add(AgentId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Page);
                        command.Options.Add(IncludeTotal);
                        command.Options.Add(PageSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var phoneNumber = parseResult.GetValue(PhoneNumber);
                        var agentId = parseResult.GetValue(AgentId);
                        var cursor = parseResult.GetValue(Cursor);
                        var page = parseResult.GetValue(Page);
                        var includeTotal = parseResult.GetValue(IncludeTotal);
                        var pageSize = parseResult.GetValue(PageSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PhoneNumbers.GetAgentPhoneNumbersAsync(
                                    phoneNumber: phoneNumber,
                                    agentId: agentId,
                                    cursor: cursor,
                                    page: page,
                                    includeTotal: includeTotal,
                                    pageSize: pageSize,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"PhoneNumbers",
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