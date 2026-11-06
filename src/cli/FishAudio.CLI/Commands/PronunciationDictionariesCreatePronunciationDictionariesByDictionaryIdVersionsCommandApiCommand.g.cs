#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class PronunciationDictionariesCreatePronunciationDictionariesByDictionaryIdVersionsCommandApiCommand
{
    private static Argument<string> DictionaryId { get; } = new(
        name: @"dictionary-id")
    {
        Description = @"",
    };

    private static Option<string?> ExpectedLatestVersionId { get; } = new(
        name: @"--expected-latest-version-id")
    {
        Description = @"Optimistic-concurrency guard: the latest version ID the caller believes is current, or null for the first publish. A mismatch returns 409.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Optional version note (up to 1024 characters).",
    };

    private static Option<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>?> Items { get; } = new(
        name: @"--items")
    {
        Description = @"Complete ordered rule list for the new version (up to 5000 rules). Keys must be unique within the version; order is the engine's application order.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreatePronunciationDictionariesVersionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreatePronunciationDictionariesVersionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-pronunciation-dictionaries-by-dictionary-id-versions", @"Publish a version
Publish an immutable snapshot of rules. Send the version you believe is current as `expected_latest_version_id`; a stale value returns 409. Keys are unique within a version (duplicates return 422). Alias rules never shorten billing.");
                        command.Arguments.Add(DictionaryId);
                        command.Options.Add(ExpectedLatestVersionId);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Items);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PronunciationDictionaryVersionCreatePayload>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var dictionaryId = parseResult.GetRequiredValue(DictionaryId);
                        var expectedLatestVersionId = CliRuntime.WasSpecified(parseResult, ExpectedLatestVersionId) ? parseResult.GetValue(ExpectedLatestVersionId) : (__requestBase is { } __ExpectedLatestVersionIdBaseValue ? __ExpectedLatestVersionIdBaseValue.ExpectedLatestVersionId : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var items = CliRuntime.WasSpecified(parseResult, Items) ? parseResult.GetValue(Items) : (__requestBase is { } __ItemsBaseValue ? __ItemsBaseValue.Items : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.PronunciationDictionaries.CreatePronunciationDictionariesByDictionaryIdVersionsAsync(
                                    dictionaryId: dictionaryId,
                                    expectedLatestVersionId: expectedLatestVersionId,
                                    description: description,
                                    items: items,
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
        CustomizeCommand(ref command);
        return command;
    }
}