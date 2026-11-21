#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeSourcesGetAgentKnowledgeSourcesCommandApiCommand
{
    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Case-insensitive match on name and file name.",
    };

    private static Option<string?> FolderId { get; } = new(
        name: @"--folder-id")
    {
        Description = @"Only sources in this knowledge folder. Omit it, or pass `root` (an empty value counts as omitted), to list every source across all workspaces, in a folder or not; sources outside any folder have a null `folder_id`. An unknown or deleted folder id gives an empty list. Combines with `search`.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentKnowledgeSourcesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentKnowledgeSourcesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-agent-knowledge-sources", @"List Knowledge Sources
List your team's knowledge sources, newest first. Paginate with `cursor`
(follow `next_cursor` while `has_more` is true) or with `page` for offset
pagination with a `total` count — the two are mutually exclusive. Filter
by folder with `folder_id=&lt;id&gt;`; with `folder_id=root` or no `folder_id`
you get every source, and the ones outside any folder have a null
`folder_id`.");
                        command.Options.Add(Search);
                        command.Options.Add(FolderId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Page);
                        command.Options.Add(IncludeTotal);
                        command.Options.Add(PageSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var search = parseResult.GetValue(Search);
                        var folderId = parseResult.GetValue(FolderId);
                        var cursor = parseResult.GetValue(Cursor);
                        var page = parseResult.GetValue(Page);
                        var includeTotal = parseResult.GetValue(IncludeTotal);
                        var pageSize = parseResult.GetValue(PageSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.KnowledgeSources.GetAgentKnowledgeSourcesAsync(
                                    search: search,
                                    folderId: folderId,
                                    cursor: cursor,
                                    page: page,
                                    includeTotal: includeTotal,
                                    pageSize: pageSize,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"KnowledgeSources",
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
        CustomizeCommand(ref command);
        return command;
    }
}