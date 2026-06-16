#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateVoiceDesignCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Specify which voice-design model to use.",
        DefaultValueFactory = _ => "voice-design-1",
    };

    private static Option<string> Instruction { get; } = new(
        name: @"--instruction")
    {
        Description = @"Voice design prompt. Must contain 1 to 2000 characters.",
        Required = true,
    };

    private static Option<string?> ReferenceText { get; } = new(
        name: @"--reference-text")
    {
        Description = @"Optional text used as reference content for the generated voice.",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Optional BCP-47 language hint, such as `en`, `zh`, or `ja`.",
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"Number of voice candidates to generate.",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"Speaking speed multiplier for candidate generation.",
    };

    private static Option<int?> NumStep { get; } = new(
        name: @"--num-step")
    {
        Description = @"Number of diffusion steps used by the voice-design model.",
    };

    private static Option<double?> GuidanceScale { get; } = new(
        name: @"--guidance-scale")
    {
        Description = @"Classifier-free guidance scale. Higher values follow the prompt more strongly.",
    };

    private static Option<double?> InstructGuidanceScale { get; } = new(
        name: @"--instruct-guidance-scale")
    {
        Description = @"Instruction guidance scale for prompt conditioning.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Optional deterministic seed for candidate generation.",
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

                    private static string FormatResponse(ParseResult parseResult, global::FishAudio.CreateVoiceDesignResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::FishAudio.CreateVoiceDesignResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-voice-design", @"Voice Design");
                        command.Options.Add(Model);
                        command.Options.Add(Instruction);
                        command.Options.Add(ReferenceText);
                        command.Options.Add(Language);
                        command.Options.Add(N);
                        command.Options.Add(Speed);
                        command.Options.Add(NumStep);
                        command.Options.Add(GuidanceScale);
                        command.Options.Add(InstructGuidanceScale);
                        command.Options.Add(Seed);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.VoiceDesignRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var instruction = parseResult.GetRequiredValue(Instruction);
                        var referenceText = CliRuntime.WasSpecified(parseResult, ReferenceText) ? parseResult.GetValue(ReferenceText) : (__requestBase is { } __ReferenceTextBaseValue ? __ReferenceTextBaseValue.ReferenceText : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var n = CliRuntime.WasSpecified(parseResult, N) ? parseResult.GetValue(N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var numStep = CliRuntime.WasSpecified(parseResult, NumStep) ? parseResult.GetValue(NumStep) : (__requestBase is { } __NumStepBaseValue ? __NumStepBaseValue.NumStep : default);
                        var guidanceScale = CliRuntime.WasSpecified(parseResult, GuidanceScale) ? parseResult.GetValue(GuidanceScale) : (__requestBase is { } __GuidanceScaleBaseValue ? __GuidanceScaleBaseValue.GuidanceScale : default);
                        var instructGuidanceScale = CliRuntime.WasSpecified(parseResult, InstructGuidanceScale) ? parseResult.GetValue(InstructGuidanceScale) : (__requestBase is { } __InstructGuidanceScaleBaseValue ? __InstructGuidanceScaleBaseValue.InstructGuidanceScale : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenAPIV1.CreateVoiceDesignAsync(
                                    model: model,
                                    instruction: instruction,
                                    referenceText: referenceText,
                                    language: language,
                                    n: n,
                                    speed: speed,
                                    numStep: numStep,
                                    guidanceScale: guidanceScale,
                                    instructGuidanceScale: instructGuidanceScale,
                                    seed: seed,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        @"Candidates",
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