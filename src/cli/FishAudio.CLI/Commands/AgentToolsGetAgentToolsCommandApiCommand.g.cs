#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentToolsGetAgentToolsCommandApiCommand
{
    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Case-insensitive match on name.",
    };

    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Only tools attached to this agent's draft config.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentToolsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentToolsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-agent-tools", @"List Tools
List your team's tools, newest first. Filter with `agent_id` to see one
agent's attached tools. Paginate with `cursor` (follow `next_cursor` while
`has_more` is true) or with `page` for offset pagination with a `total`
count; the two are mutually exclusive.");
                        command.Options.Add(Search);
                        command.Options.Add(AgentId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Page);
                        command.Options.Add(IncludeTotal);
                        command.Options.Add(PageSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var search = parseResult.GetValue(Search);
                        var agentId = parseResult.GetValue(AgentId);
                        var cursor = parseResult.GetValue(Cursor);
                        var page = parseResult.GetValue(Page);
                        var includeTotal = parseResult.GetValue(IncludeTotal);
                        var pageSize = parseResult.GetValue(PageSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTools.GetAgentToolsAsync(
                                    search: search,
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
                                        @"Tools",
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