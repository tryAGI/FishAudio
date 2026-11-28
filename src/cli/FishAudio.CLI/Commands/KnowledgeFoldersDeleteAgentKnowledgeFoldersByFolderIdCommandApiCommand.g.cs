#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeFoldersDeleteAgentKnowledgeFoldersByFolderIdCommandApiCommand
{
    private static Argument<string> FolderId { get; } = new(
        name: @"folder-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-agent-knowledge-folders-by-folder-id", @"Delete Knowledge Folder
Delete a folder, empty or not. The knowledge sources inside it are not
deleted: they are taken out of the folder (`folder_id` becomes null).");
                        command.Arguments.Add(FolderId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var folderId = parseResult.GetRequiredValue(FolderId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.KnowledgeFolders.DeleteAgentKnowledgeFoldersByFolderIdAsync(
                                    folderId: folderId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}