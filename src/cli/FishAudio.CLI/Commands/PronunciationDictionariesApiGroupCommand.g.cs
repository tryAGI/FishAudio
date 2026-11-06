#nullable enable

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PronunciationDictionariesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"pronunciation-dictionaries", @"Pronunciation Dictionaries endpoint commands.");
                         command.Subcommands.Add(PronunciationDictionariesCreatePronunciationDictionariesCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesCreatePronunciationDictionariesByDictionaryIdVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesDeletePronunciationDictionariesByDictionaryIdCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesDeletePronunciationDictionariesByDictionaryIdVersionsByVersionIdCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesEditPronunciationDictionariesByDictionaryIdCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesGetPronunciationDictionariesCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesGetPronunciationDictionariesByDictionaryIdCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesGetPronunciationDictionariesByDictionaryIdVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesGetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCommandApiCommand.Create());
                         command.Subcommands.Add(PronunciationDictionariesGetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCompareCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}