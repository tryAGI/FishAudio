#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateAsrCommandApiCommand
{
    private static Option<byte[]> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Audio to be converted to text",
        Required = true,
    };

    private static Option<string> Audioname { get; } = new(
        name: @"--audioname")
    {
        Description = @"Audio to be converted to text",
        Required = true,
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Language to be used for the speech",
    };

    private static Option<bool?> IgnoreTimestamps { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--ignore-timestamps",
        description: @"Whether to return precise timestamps in the text, this will increase the latency in audio shorter than 30 seconds");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateAsrResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateAsrResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-asr", @"Speech to Text");
                        command.Options.Add(Audio);
                        command.Options.Add(Audioname);
                        command.Options.Add(Language);
                        command.Options.Add(IgnoreTimestamps);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.CreateAsrRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var audio = parseResult.GetRequiredValue(Audio);
                        var audioname = parseResult.GetRequiredValue(Audioname);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var ignoreTimestamps = CliRuntime.WasSpecified(parseResult, IgnoreTimestamps) ? parseResult.GetValue(IgnoreTimestamps) : (__requestBase is { } __IgnoreTimestampsBaseValue ? __IgnoreTimestampsBaseValue.IgnoreTimestamps : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenAPIV1.CreateAsrAsync(
                                    audio: audio,
                                    audioname: audioname,
                                    language: language,
                                    ignoreTimestamps: ignoreTimestamps,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Segments",
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