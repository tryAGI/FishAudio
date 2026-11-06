#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class AgentBackgroundSoundsDeleteAgentBackgroundSoundsByAssetIdCommandApiCommand
{
    private static Argument<string> AssetId { get; } = new(
        name: @"asset-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-agent-background-sounds-by-asset-id", @"Delete Background Sound
Soft-deletes the clip. An agent still naming it in
`voice.background_sound.custom_asset_id` falls back to silence for that
ambience at its next session rather than failing the call.");
                        command.Arguments.Add(AssetId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var assetId = parseResult.GetRequiredValue(AssetId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.AgentBackgroundSounds.DeleteAgentBackgroundSoundsByAssetIdAsync(
                                    assetId: assetId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}