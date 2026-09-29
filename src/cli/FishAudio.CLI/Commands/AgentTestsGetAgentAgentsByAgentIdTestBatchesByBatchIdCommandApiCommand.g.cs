#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentTestsGetAgentAgentsByAgentIdTestBatchesByBatchIdCommandApiCommand
{
    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"",
    };

    private static Argument<string> BatchId { get; } = new(
        name: @"batch-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetAgentAgentsTestBatchesResponse6 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetAgentAgentsTestBatchesResponse6 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-agent-agents-by-agent-id-test-batches-by-batch-id", @"Get Test Batch
The runs of one batch with their pass, fail and error counts. `status` is
`running` until every run has finished, then `completed`.");
                        command.Arguments.Add(AgentId);
                        command.Arguments.Add(BatchId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var batchId = parseResult.GetRequiredValue(BatchId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentTests.GetAgentAgentsByAgentIdTestBatchesByBatchIdAsync(
                                    agentId: agentId,
                                    batchId: batchId,
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