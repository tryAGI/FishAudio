#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PronunciationDictionariesGetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCompareCommandApiCommand
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

    private static Option<string> BaseVersionId { get; } = new(
        name: @"--base-version-id")
    {
        Description = @"Version to compare the target version against.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-pronunciation-dictionaries-by-dictionary-id-versions-by-version-id-compare", @"Compare two versions
Return a row-level diff between the target version and `base_version_id`: added, removed, changed, moved and unchanged rules.");
                        command.Arguments.Add(DictionaryId);
                        command.Arguments.Add(VersionId);
                        command.Options.Add(BaseVersionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var dictionaryId = parseResult.GetRequiredValue(DictionaryId);
                        var versionId = parseResult.GetRequiredValue(VersionId);
                        var baseVersionId = parseResult.GetRequiredValue(BaseVersionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PronunciationDictionaries.GetPronunciationDictionariesByDictionaryIdVersionsByVersionIdCompareAsync(
                                    dictionaryId: dictionaryId,
                                    versionId: versionId,
                                    baseVersionId: baseVersionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Rows",
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