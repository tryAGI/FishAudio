#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentToolsDeleteAgentToolsByToolIdCommandApiCommand
{
    private static Argument<string> ToolId { get; } = new(
        name: @"tool-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-agent-tools-by-tool-id", @"Delete Tool
Delete a tool. Returns 409 while any agent's draft configuration still
references it — check `GET /v1/agent/tools/{tool_id}/agents` and detach it
via the agent config first, so a delete can never silently change agent
behavior.");
                        command.Arguments.Add(ToolId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolId = parseResult.GetRequiredValue(ToolId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.AgentTools.DeleteAgentToolsByToolIdAsync(
                                    toolId: toolId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}