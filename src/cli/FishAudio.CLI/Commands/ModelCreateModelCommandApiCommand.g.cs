#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class ModelCreateModelCommandApiCommand
{
    private static Option<global::FishAudio.CreateModelRequestVisibility?> Visibility { get; } = new(
        name: @"--visibility")
    {
        Description = @"Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator",
    };

    private static Option<string> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Model type, tts is for text to speech",
        DefaultValueFactory = _ => "tts",
    };

    private static Option<string> Title { get; } = new(
        name: @"--title")
    {
        Description = @"Model title or name",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Model description",
    };

    private static Option<byte[]?> CoverImage { get; } = new(
        name: @"--cover-image")
    {
        Description = @"Model cover image, this is required if the model is public",
    };

    private static Option<string?> CoverImagename { get; } = new(
        name: @"--cover-imagename")
    {
        Description = @"Model cover image, this is required if the model is public",
    };

    private static Option<string> TrainMode { get; } = new(
        name: @"--train-mode")
    {
        Description = @"Model train mode, for TTS model, fast means model instantly available after creation",
        DefaultValueFactory = _ => "fast",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>> Voices { get; } = new(
        name: @"--voices")
    {
        Description = @"Upload voices files that will be used to tune the model",
        Required = true,
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?> Texts { get; } = new(
        name: @"--texts")
    {
        Description = @"Texts corresponding to the voices, if unspecified, ASR will be performed on the voices",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Model tags",
    };

    private static Option<bool?> EnhanceAudioQuality { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance-audio-quality",
        description: @"Enhance audio quality");

    private static Option<bool?> GenerateSample { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--generate-sample",
        description: @"Generate default text");
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateModelResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateModelResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-model", @"Create Model for Users via API");
                        command.Options.Add(Visibility);
                        command.Options.Add(Type);
                        command.Options.Add(Title);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(CoverImage);
                        command.Options.Add(CoverImagename);
                        command.Options.Add(TrainMode);
                        command.Options.Add(Voices);
                        command.Options.Add(Texts);
                        command.Options.Add(Tags);
                        command.Options.Add(EnhanceAudioQuality);
                        command.Options.Add(GenerateSample);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.CreateModelRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var visibility = CliRuntime.WasSpecified(parseResult, Visibility) ? parseResult.GetValue(Visibility) : __requestBase is not null ? __requestBase.Visibility : default;
                        var type = parseResult.GetRequiredValue(Type);
                        var title = parseResult.GetRequiredValue(Title);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : __requestBase is not null ? __requestBase.Description : default;
                        var coverImage = CliRuntime.WasSpecified(parseResult, CoverImage) ? parseResult.GetValue(CoverImage) : __requestBase is not null ? __requestBase.CoverImage : default;
                        var coverImagename = CliRuntime.WasSpecified(parseResult, CoverImagename) ? parseResult.GetValue(CoverImagename) : __requestBase is not null ? __requestBase.CoverImagename : default;
                        var trainMode = parseResult.GetRequiredValue(TrainMode);
                        var voices = parseResult.GetRequiredValue(Voices);
                        var texts = CliRuntime.WasSpecified(parseResult, Texts) ? parseResult.GetValue(Texts) : __requestBase is not null ? __requestBase.Texts : default;
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : __requestBase is not null ? __requestBase.Tags : default;
                        var enhanceAudioQuality = CliRuntime.WasSpecified(parseResult, EnhanceAudioQuality) ? parseResult.GetValue(EnhanceAudioQuality) : __requestBase is not null ? __requestBase.EnhanceAudioQuality : default;
                        var generateSample = CliRuntime.WasSpecified(parseResult, GenerateSample) ? parseResult.GetValue(GenerateSample) : __requestBase is not null ? __requestBase.GenerateSample : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Model.CreateModelAsync(
                                    visibility: visibility,
                                    type: type,
                                    title: title,
                                    description: description,
                                    coverImage: coverImage,
                                    coverImagename: coverImagename,
                                    trainMode: trainMode,
                                    voices: voices,
                                    texts: texts,
                                    tags: tags,
                                    enhanceAudioQuality: enhanceAudioQuality,
                                    generateSample: generateSample,
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