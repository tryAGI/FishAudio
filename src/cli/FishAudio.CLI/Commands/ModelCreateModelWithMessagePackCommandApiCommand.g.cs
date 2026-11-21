#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class ModelCreateModelWithMessagePackCommandApiCommand
{
    private static Option<byte[]?> CoverImage { get; } = new(
        name: @"--cover-image")
    {
        Description = @"Model cover image, this is required if the model is public",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>> Voices { get; } = new(
        name: @"--voices")
    {
        Description = @"Upload voices files that will be used to tune the model",
        Required = true,
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?> Texts { get; } = new(
        name: @"--texts")
    {
        Description = @"Texts corresponding to the voices, if unspecified, ASR will be performed on the voices",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?> VoiceDesignSignatures { get; } = new(
        name: @"--voice-design-signatures")
    {
        Description = @"Signatures from /v1/voice-design candidates, one per voice in the same order. When every uploaded voice verifies, the model is stamped source=voice_design; an invalid signature rejects the request.",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Model tags",
    };
    private static readonly CreateModelRequestOptionSet CreateModelRequestOptionSetOptions = CreateModelRequestOptionSet.Create();
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-model-with-message-pack", @"Create Model for Users via API");
                        command.Options.Add(CoverImage);
                        command.Options.Add(Voices);
                        command.Options.Add(Texts);
                        command.Options.Add(VoiceDesignSignatures);
                        command.Options.Add(Tags);                        command.Options.Add(CreateModelRequestOptionSetOptions.Visibility);
                        command.Options.Add(CreateModelRequestOptionSetOptions.Type);
                        command.Options.Add(CreateModelRequestOptionSetOptions.Title);
                        command.Options.Add(CreateModelRequestOptionSetOptions.DescriptionOption);
                        command.Options.Add(CreateModelRequestOptionSetOptions.CoverImagename);
                        command.Options.Add(CreateModelRequestOptionSetOptions.TrainMode);
                        command.Options.Add(CreateModelRequestOptionSetOptions.EnhanceAudioQuality);
                        command.Options.Add(CreateModelRequestOptionSetOptions.GenerateSample);
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
                        var coverImage = CliRuntime.WasSpecified(parseResult, CoverImage) ? parseResult.GetValue(CoverImage) : (__requestBase is { } __CoverImageBaseValue ? __CoverImageBaseValue.CoverImage : default);
                        var voices = parseResult.GetRequiredValue(Voices);
                        var texts = CliRuntime.WasSpecified(parseResult, Texts) ? parseResult.GetValue(Texts) : (__requestBase is { } __TextsBaseValue ? __TextsBaseValue.Texts : default);
                        var voiceDesignSignatures = CliRuntime.WasSpecified(parseResult, VoiceDesignSignatures) ? parseResult.GetValue(VoiceDesignSignatures) : (__requestBase is { } __VoiceDesignSignaturesBaseValue ? __VoiceDesignSignaturesBaseValue.VoiceDesignSignatures : default);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);                        var visibility = CliRuntime.WasSpecified(parseResult, CreateModelRequestOptionSetOptions.Visibility) ? parseResult.GetValue(CreateModelRequestOptionSetOptions.Visibility) : (__requestBase is { } __VisibilityBaseValue ? __VisibilityBaseValue.Visibility : default);
                        var type = parseResult.GetRequiredValue(CreateModelRequestOptionSetOptions.Type);
                        var title = parseResult.GetRequiredValue(CreateModelRequestOptionSetOptions.Title);
                        var description = CliRuntime.WasSpecified(parseResult, CreateModelRequestOptionSetOptions.DescriptionOption) ? parseResult.GetValue(CreateModelRequestOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var coverImagename = CliRuntime.WasSpecified(parseResult, CreateModelRequestOptionSetOptions.CoverImagename) ? parseResult.GetValue(CreateModelRequestOptionSetOptions.CoverImagename) : (__requestBase is { } __CoverImagenameBaseValue ? __CoverImagenameBaseValue.CoverImagename : default);
                        var trainMode = parseResult.GetRequiredValue(CreateModelRequestOptionSetOptions.TrainMode);
                        var enhanceAudioQuality = CliRuntime.WasSpecified(parseResult, CreateModelRequestOptionSetOptions.EnhanceAudioQuality) ? parseResult.GetValue(CreateModelRequestOptionSetOptions.EnhanceAudioQuality) : (__requestBase is { } __EnhanceAudioQualityBaseValue ? __EnhanceAudioQualityBaseValue.EnhanceAudioQuality : default);
                        var generateSample = CliRuntime.WasSpecified(parseResult, CreateModelRequestOptionSetOptions.GenerateSample) ? parseResult.GetValue(CreateModelRequestOptionSetOptions.GenerateSample) : (__requestBase is { } __GenerateSampleBaseValue ? __GenerateSampleBaseValue.GenerateSample : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Model.CreateModelWithMessagePackAsync(
                                    coverImage: coverImage,
                                    voices: voices,
                                    texts: texts,
                                    voiceDesignSignatures: voiceDesignSignatures,
                                    tags: tags,
                                    visibility: visibility,
                                    type: type,
                                    title: title,
                                    description: description,
                                    coverImagename: coverImagename,
                                    trainMode: trainMode,
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
        CustomizeCommand(ref command);
        return command;
    }
}