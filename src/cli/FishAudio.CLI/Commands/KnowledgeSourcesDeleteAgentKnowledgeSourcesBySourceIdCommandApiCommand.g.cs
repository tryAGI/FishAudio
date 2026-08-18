#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeSourcesDeleteAgentKnowledgeSourcesBySourceIdCommandApiCommand
{
    private static Argument<string> SourceId { get; } = new(
        name: @"source-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-agent-knowledge-sources-by-source-id", @"Delete Knowledge Source
Delete a knowledge source. Returns 409 while any agent still references it,
in its draft or in its currently published version (sessions resolve
sources at call time, so deleting a published reference would change a
running agent). Check `GET /v1/agent/knowledge-sources/{source_id}/agents`,
detach via the agent config, and republish if needed before deleting.");
                        command.Arguments.Add(SourceId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sourceId = parseResult.GetRequiredValue(SourceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.KnowledgeSources.DeleteAgentKnowledgeSourcesBySourceIdAsync(
                                    sourceId: sourceId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}