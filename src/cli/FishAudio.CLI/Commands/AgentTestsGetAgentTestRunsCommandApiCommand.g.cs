#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsGetAgentTestRunsCommandApiCommand
{
    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"",
    };

    private static Option<string?> TestId { get; } = new(
        name: @"--test-id")
    {
        Description = @"",
    };

    private static Option<string?> BatchId { get; } = new(
        name: @"--batch-id")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.GetAgentTestRunsStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"",
    };

    private static Option<global::FishAudio.GetAgentTestRunsTestType?> TestType { get; } = new(
        name: @"--test-type")
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
        Description = @"1-based page number, mutually exclusive with cursor.",
    };

    private static Option<bool?> IncludeTotal { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-total",
        description: @"");

    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentTestRunsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentTestRunsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-agent-test-runs", @"List Test Runs
Your team's test runs, newest first, filtered by agent, test, batch,
status or test type. Items leave out the conversation and the judge's
output. Fetch one run with `GET /v1/agent/test-runs/{run_id}` for those.
Paginate with `cursor` (follow `next_cursor` while `has_more` is true) or
with `page` for offset pagination with a `total` count. The two are
mutually exclusive.");
                        command.Options.Add(AgentId);
                        command.Options.Add(TestId);
                        command.Options.Add(BatchId);
                        command.Options.Add(Status);
                        command.Options.Add(TestType);
                        command.Options.Add(Cursor);
                        command.Options.Add(Page);
                        command.Options.Add(IncludeTotal);
                        command.Options.Add(PageSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var agentId = parseResult.GetValue(AgentId);
                        var testId = parseResult.GetValue(TestId);
                        var batchId = parseResult.GetValue(BatchId);
                        var status = parseResult.GetValue(Status);
                        var testType = parseResult.GetValue(TestType);
                        var cursor = parseResult.GetValue(Cursor);
                        var page = parseResult.GetValue(Page);
                        var includeTotal = parseResult.GetValue(IncludeTotal);
                        var pageSize = parseResult.GetValue(PageSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTests.GetAgentTestRunsAsync(
                                    agentId: agentId,
                                    testId: testId,
                                    batchId: batchId,
                                    status: status,
                                    testType: testType,
                                    cursor: cursor,
                                    page: page,
                                    includeTotal: includeTotal,
                                    pageSize: pageSize,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Runs",
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