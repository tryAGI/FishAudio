#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentSessionsGetAgentSessionsCommandApiCommand
{
    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Comma-separated status filter (pending/active/completed/failed/unknown). Default: every status except pending.",
    };

    private static Option<string?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Filter by call direction (inbound/outbound). Sessions predating the field count as inbound.",
    };

    private static Option<string?> CallerNumber { get; } = new(
        name: @"--caller-number")
    {
        Description = @"Exact-match caller E.164 (phone sessions only).",
    };

    private static Option<string?> CreatedAfter { get; } = new(
        name: @"--created-after")
    {
        Description = @"",
    };

    private static Option<string?> CreatedBefore { get; } = new(
        name: @"--created-before")
    {
        Description = @"",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"",
    };

    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"1-based page number (offset pagination). Returns total; mutually exclusive with cursor, which deep scans must use.",
    };

    private static Option<bool?> IncludeTotal { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-total",
        description: @"Also count the filtered set on the cursor path.");

    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentSessionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentSessionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-agent-sessions", @"List Agent Sessions
List your team's sessions, newest first. Filter by agent, status, caller
number, or creation time. Paginate with `cursor` (recommended; follow
`next_cursor` while `has_more` is true) or with `page` for offset pagination
with a `total` count — the two are mutually exclusive.");
                        command.Options.Add(AgentId);
                        command.Options.Add(Status);
                        command.Options.Add(Direction);
                        command.Options.Add(CallerNumber);
                        command.Options.Add(CreatedAfter);
                        command.Options.Add(CreatedBefore);
                        command.Options.Add(Cursor);
                        command.Options.Add(Page);
                        command.Options.Add(IncludeTotal);
                        command.Options.Add(PageSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var agentId = parseResult.GetValue(AgentId);
                        var status = parseResult.GetValue(Status);
                        var direction = parseResult.GetValue(Direction);
                        var callerNumber = parseResult.GetValue(CallerNumber);
                        var createdAfter = parseResult.GetValue(CreatedAfter);
                        var createdBefore = parseResult.GetValue(CreatedBefore);
                        var cursor = parseResult.GetValue(Cursor);
                        var page = parseResult.GetValue(Page);
                        var includeTotal = parseResult.GetValue(IncludeTotal);
                        var pageSize = parseResult.GetValue(PageSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentSessions.GetAgentSessionsAsync(
                                    agentId: agentId,
                                    status: status,
                                    direction: direction,
                                    callerNumber: callerNumber,
                                    createdAfter: createdAfter,
                                    createdBefore: createdBefore,
                                    cursor: cursor,
                                    page: page,
                                    includeTotal: includeTotal,
                                    pageSize: pageSize,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Sessions",
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