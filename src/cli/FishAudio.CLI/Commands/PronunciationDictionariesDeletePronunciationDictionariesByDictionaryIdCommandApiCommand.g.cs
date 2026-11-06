#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PronunciationDictionariesDeletePronunciationDictionariesByDictionaryIdCommandApiCommand
{
    private static Argument<string> DictionaryId { get; } = new(
        name: @"dictionary-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-pronunciation-dictionaries-by-dictionary-id", @"Delete (archive) a pronunciation dictionary
Soft-archive the dictionary: it disappears from list/get and can no longer be modified, while its versions remain stored. Idempotent.");
                        command.Arguments.Add(DictionaryId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var dictionaryId = parseResult.GetRequiredValue(DictionaryId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.PronunciationDictionaries.DeletePronunciationDictionariesByDictionaryIdAsync(
                                    dictionaryId: dictionaryId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}