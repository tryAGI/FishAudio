#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class KnowledgeSourcesEditAgentKnowledgeSourcesBySourceIdCommandApiCommand
{
    private static Argument<string> SourceId { get; } = new(
        name: @"source-id")
    {
        Description = @"",
    };

    private static Option<byte[]?> Source { get; } = new(
        name: @"--source")
    {
        Description = @"",
    };

    private static Option<string?> Sourcename { get; } = new(
        name: @"--sourcename")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.PatchAgentKnowledgeSourcesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.PatchAgentKnowledgeSourcesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-agent-knowledge-sources-by-source-id", @"Update Knowledge Source
Rename the source and/or replace its content by uploading a new file in
`source` (multipart). Replacing content increments `revision_number` while
the id stays stable, and every attached agent's draft picks it up
immediately; published versions pin the revision they were published with,
so republish each affected agent to put the new content live.");
                        command.Arguments.Add(SourceId);
                        command.Options.Add(Source);
                        command.Options.Add(Sourcename);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.PatchAgentKnowledgeSourcesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sourceId = parseResult.GetRequiredValue(SourceId);
                        var source = CliRuntime.WasSpecified(parseResult, Source) ? parseResult.GetValue(Source) : (__requestBase is { } __SourceBaseValue ? __SourceBaseValue.Source : default);
                        var sourcename = CliRuntime.WasSpecified(parseResult, Sourcename) ? parseResult.GetValue(Sourcename) : (__requestBase is { } __SourcenameBaseValue ? __SourcenameBaseValue.Sourcename : default);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.KnowledgeSources.EditAgentKnowledgeSourcesBySourceIdAsync(
                                    sourceId: sourceId,
                                    source: source,
                                    sourcename: sourcename,
                                    name: name,
                                    description: description,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::FishAudio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}