#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeFoldersEditAgentKnowledgeFoldersByFolderIdCommandApiCommand
{
    private static Argument<string> FolderId { get; } = new(
        name: @"folder-id")
    {
        Description = @"",
    };
    private static readonly PublicKnowledgeFolderPayloadOptionSet PublicKnowledgeFolderPayloadOptionSetOptions = PublicKnowledgeFolderPayloadOptionSet.Create();

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentKnowledgeFoldersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentKnowledgeFoldersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-agent-knowledge-folders-by-folder-id", @"Rename Knowledge Folder
Rename a folder. The name must be free within the folder's own workspace
(409 otherwise); renaming a folder to its current name succeeds.");
                        command.Arguments.Add(FolderId);                        command.Options.Add(PublicKnowledgeFolderPayloadOptionSetOptions.NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var folderId = parseResult.GetRequiredValue(FolderId);                        var name = parseResult.GetRequiredValue(PublicKnowledgeFolderPayloadOptionSetOptions.NameOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.KnowledgeFolders.EditAgentKnowledgeFoldersByFolderIdAsync(
                                    folderId: folderId,
                                    name: name,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}