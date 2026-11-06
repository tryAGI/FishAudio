#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PronunciationDictionariesDeletePronunciationDictionariesByDictionaryIdVersionsByVersionIdCommandApiCommand
{
    private static Argument<string> DictionaryId { get; } = new(
        name: @"dictionary-id")
    {
        Description = @"",
    };

    private static Argument<string> VersionId { get; } = new(
        name: @"version-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-pronunciation-dictionaries-by-dictionary-id-versions-by-version-id", @"Delete (archive) a version
Soft-archive a historical version. The latest version cannot be deleted (409), and deleting an already archived version also returns 409.");
                        command.Arguments.Add(DictionaryId);
                        command.Arguments.Add(VersionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var dictionaryId = parseResult.GetRequiredValue(DictionaryId);
                        var versionId = parseResult.GetRequiredValue(VersionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.PronunciationDictionaries.DeletePronunciationDictionariesByDictionaryIdVersionsByVersionIdAsync(
                                    dictionaryId: dictionaryId,
                                    versionId: versionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}