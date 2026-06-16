#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateTtsCommandApiCommand
{
    private static Option<global::FishAudio.CreateTtsModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Specify which TTS model to use. We recommend `s2-pro`.",
        DefaultValueFactory = _ => global::FishAudio.CreateTtsModel.S2Pro,
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Text to convert to speech.",
        Required = true,
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Controls expressiveness. Higher is more varied, lower is more consistent.",
    };

    private static Option<double?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"Controls diversity via nucleus sampling.",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>?> References { get; } = new(
        name: @"--references")
    {
        Description = @"Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.",
    };

    private static Option<global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> ReferenceId { get; } = new(
        name: @"--reference-id")
    {
        Description = @"Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `<|speaker:0|>` and `<|speaker:1|>` to indicate speaker changes. Example: `<|speaker:0|>Hello!<|speaker:1|>Hi there!<|speaker:0|>How are you?` with `reference_id: [""speaker-a-id"", ""speaker-b-id""]`.",
    };

    private static Option<int?> ChunkLength { get; } = new(
        name: @"--chunk-length")
    {
        Description = @"Text segment size for processing.",
    };

    private static Option<bool?> Normalize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--normalize",
        description: @"Normalizes text for English and Chinese, improving stability for numbers.");

    private static Option<global::FishAudio.TTSRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Output audio format.",
    };

    private static Option<int?> SampleRate { get; } = new(
        name: @"--sample-rate")
    {
        Description = @"Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).",
    };

    private static Option<int?> Mp3Bitrate { get; } = new(
        name: @"--mp3-bitrate")
    {
        Description = @"MP3 bitrate in kbps. Only applies when format is mp3.",
    };

    private static Option<int?> OpusBitrate { get; } = new(
        name: @"--opus-bitrate")
    {
        Description = @"Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.",
    };

    private static Option<global::FishAudio.TTSRequestLatency?> Latency { get; } = new(
        name: @"--latency")
    {
        Description = @"Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.",
    };

    private static Option<int?> MaxNewTokens { get; } = new(
        name: @"--max-new-tokens")
    {
        Description = @"Maximum audio tokens to generate per text chunk.",
    };

    private static Option<double?> RepetitionPenalty { get; } = new(
        name: @"--repetition-penalty")
    {
        Description = @"Penalty for repeating audio patterns. Values above 1.0 reduce repetition.",
    };

    private static Option<int?> MinChunkLength { get; } = new(
        name: @"--min-chunk-length")
    {
        Description = @"Minimum characters before splitting into a new chunk.",
    };

    private static Option<bool?> ConditionOnPreviousChunks { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--condition-on-previous-chunks",
        description: @"Use previous audio as context for voice consistency.");

    private static Option<double?> EarlyStopThreshold { get; } = new(
        name: @"--early-stop-threshold")
    {
        Description = @"Early stopping threshold for batch processing.",
    };
    private static readonly ProsodyControlOptionSet ProsodyOptions = ProsodyControlOptionSet.Create(@"prosody");
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

    public static Command Create()
    {
        var command = new Command(@"create-tts", @"Text to Speech");
                        command.Options.Add(Model);
                        command.Options.Add(Text);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(References);
                        command.Options.Add(ReferenceId);
                        command.Options.Add(ChunkLength);
                        command.Options.Add(Normalize);
                        command.Options.Add(Format);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Mp3Bitrate);
                        command.Options.Add(OpusBitrate);
                        command.Options.Add(Latency);
                        command.Options.Add(MaxNewTokens);
                        command.Options.Add(RepetitionPenalty);
                        command.Options.Add(MinChunkLength);
                        command.Options.Add(ConditionOnPreviousChunks);
                        command.Options.Add(EarlyStopThreshold);                        command.Options.Add(ProsodyOptions.Speed);
                        command.Options.Add(ProsodyOptions.Volume);
                        command.Options.Add(ProsodyOptions.NormalizeLoudness);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.TTSRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var text = parseResult.GetRequiredValue(Text);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var references = CliRuntime.WasSpecified(parseResult, References) ? parseResult.GetValue(References) : (__requestBase is { } __ReferencesBaseValue ? __ReferencesBaseValue.References : default);
                        var referenceId = CliRuntime.WasSpecified(parseResult, ReferenceId) ? parseResult.GetValue(ReferenceId) : (__requestBase is { } __ReferenceIdBaseValue ? __ReferenceIdBaseValue.ReferenceId : default);
                        var chunkLength = CliRuntime.WasSpecified(parseResult, ChunkLength) ? parseResult.GetValue(ChunkLength) : (__requestBase is { } __ChunkLengthBaseValue ? __ChunkLengthBaseValue.ChunkLength : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, Normalize) ? parseResult.GetValue(Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, SampleRate) ? parseResult.GetValue(SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var mp3Bitrate = CliRuntime.WasSpecified(parseResult, Mp3Bitrate) ? parseResult.GetValue(Mp3Bitrate) : (__requestBase is { } __Mp3BitrateBaseValue ? __Mp3BitrateBaseValue.Mp3Bitrate : default);
                        var opusBitrate = CliRuntime.WasSpecified(parseResult, OpusBitrate) ? parseResult.GetValue(OpusBitrate) : (__requestBase is { } __OpusBitrateBaseValue ? __OpusBitrateBaseValue.OpusBitrate : default);
                        var latency = CliRuntime.WasSpecified(parseResult, Latency) ? parseResult.GetValue(Latency) : (__requestBase is { } __LatencyBaseValue ? __LatencyBaseValue.Latency : default);
                        var maxNewTokens = CliRuntime.WasSpecified(parseResult, MaxNewTokens) ? parseResult.GetValue(MaxNewTokens) : (__requestBase is { } __MaxNewTokensBaseValue ? __MaxNewTokensBaseValue.MaxNewTokens : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, RepetitionPenalty) ? parseResult.GetValue(RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var minChunkLength = CliRuntime.WasSpecified(parseResult, MinChunkLength) ? parseResult.GetValue(MinChunkLength) : (__requestBase is { } __MinChunkLengthBaseValue ? __MinChunkLengthBaseValue.MinChunkLength : default);
                        var conditionOnPreviousChunks = CliRuntime.WasSpecified(parseResult, ConditionOnPreviousChunks) ? parseResult.GetValue(ConditionOnPreviousChunks) : (__requestBase is { } __ConditionOnPreviousChunksBaseValue ? __ConditionOnPreviousChunksBaseValue.ConditionOnPreviousChunks : default);
                        var earlyStopThreshold = CliRuntime.WasSpecified(parseResult, EarlyStopThreshold) ? parseResult.GetValue(EarlyStopThreshold) : (__requestBase is { } __EarlyStopThresholdBaseValue ? __EarlyStopThresholdBaseValue.EarlyStopThreshold : default);

                        var __ProsodyBase = __requestBase is { } __ProsodyBaseValue ? __ProsodyBaseValue.Prosody : default;                        var prosodySpeed = CliRuntime.WasSpecified(parseResult, ProsodyOptions.Speed) ? parseResult.GetValue(ProsodyOptions.Speed) : (__ProsodyBase is { } __ProsodyspeedBaseValue ? __ProsodyspeedBaseValue.Speed : default);
                        var prosodyVolume = CliRuntime.WasSpecified(parseResult, ProsodyOptions.Volume) ? parseResult.GetValue(ProsodyOptions.Volume) : (__ProsodyBase is { } __ProsodyvolumeBaseValue ? __ProsodyvolumeBaseValue.Volume : default);
                        var prosodyNormalizeLoudness = CliRuntime.WasSpecified(parseResult, ProsodyOptions.NormalizeLoudness) ? parseResult.GetValue(ProsodyOptions.NormalizeLoudness) : (__ProsodyBase is { } __ProsodynormalizeLoudnessBaseValue ? __ProsodynormalizeLoudnessBaseValue.NormalizeLoudness : default);
                        var __ProsodySpecified = CliRuntime.WasSpecified(parseResult, ProsodyOptions.Speed) || CliRuntime.WasSpecified(parseResult, ProsodyOptions.Volume) || CliRuntime.WasSpecified(parseResult, ProsodyOptions.NormalizeLoudness);
                        var prosody =
                            __ProsodySpecified || __ProsodyBase is not null
                                ? new global::FishAudio.ProsodyControl
                                {
	                                Speed = prosodySpeed,
                                Volume = prosodyVolume,
                                NormalizeLoudness = prosodyNormalizeLoudness,

                                }
                                : __ProsodyBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.OpenAPIV1.CreateTtsAsync(
                                    model: model,
                                    text: text,
                                    temperature: temperature,
                                    topP: topP,
                                    references: references,
                                    referenceId: referenceId,
                                    chunkLength: chunkLength,
                                    normalize: normalize,
                                    format: format,
                                    sampleRate: sampleRate,
                                    mp3Bitrate: mp3Bitrate,
                                    opusBitrate: opusBitrate,
                                    latency: latency,
                                    maxNewTokens: maxNewTokens,
                                    repetitionPenalty: repetitionPenalty,
                                    minChunkLength: minChunkLength,
                                    conditionOnPreviousChunks: conditionOnPreviousChunks,
                                    earlyStopThreshold: earlyStopThreshold,
                                    prosody: prosody,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}