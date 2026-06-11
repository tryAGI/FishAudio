#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class ModelGetModelCommandApiCommand
{
    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"Page size",
    };

    private static Option<int?> PageNumber { get; } = new(
        name: @"--page-number")
    {
        Description = @"Page number",
    };

    private static Option<string?> Title { get; } = new(
        name: @"--title")
    {
        Description = @"Title to filter models",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Tag to filter models",
    };

    private static Option<bool?> Self { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--self",
        description: @"If True, only models created by the user will be returned");

    private static Option<string?> AuthorId { get; } = new(
        name: @"--author-id")
    {
        Description = @"Author ID to filter models, this will be ignored if self is True",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Language to filter models",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?> TitleLanguage { get; } = new(
        name: @"--title-language")
    {
        Description = @"Title language to filter models",
    };

    private static Option<global::FishAudio.GetModelSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.GetModelResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.GetModelResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-model", @"List Models");
                        command.Options.Add(PageSize);
                        command.Options.Add(PageNumber);
                        command.Options.Add(Title);
                        command.Options.Add(Tag);
                        command.Options.Add(Self);
                        command.Options.Add(AuthorId);
                        command.Options.Add(Language);
                        command.Options.Add(TitleLanguage);
                        command.Options.Add(SortBy);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var pageSize = parseResult.GetValue(PageSize);
                        var pageNumber = parseResult.GetValue(PageNumber);
                        var title = parseResult.GetValue(Title);
                        var tag = parseResult.GetValue(Tag);
                        var self = parseResult.GetValue(Self);
                        var authorId = parseResult.GetValue(AuthorId);
                        var language = parseResult.GetValue(Language);
                        var titleLanguage = parseResult.GetValue(TitleLanguage);
                        var sortBy = parseResult.GetValue(SortBy);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Model.GetModelAsync(
                                    pageSize: pageSize,
                                    pageNumber: pageNumber,
                                    title: title,
                                    tag: tag,
                                    self: self,
                                    authorId: authorId,
                                    language: language,
                                    titleLanguage: titleLanguage,
                                    sortBy: sortBy,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Items",
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
        return command;
    }
}