#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateTtsWithMessagePackCommandApiCommand
{
    private static Option<global::FishAudio.CreateTtsModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Specify which TTS model to use. Use `s2.1-pro-free` for the free developer tier. If omitted or set to an unrecognized value, the request falls back to `s2.1-pro`.",
    };

    private static Option<global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>?> References { get; } = new(
        name: @"--references")
    {
        Description = @"Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2 family (`s2-pro`, `s2.1-pro`, `s2.1-pro-free`), not `s1`.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.",
    };

    private static Option<global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> ReferenceId { get; } = new(
        name: @"--reference-id")
    {
        Description = @"Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2 family (`s2-pro`, `s2.1-pro`, `s2.1-pro-free`), not `s1`.** When using multiple speakers, use speaker tags in your text like `<|speaker:0|>` and `<|speaker:1|>` to indicate speaker changes. Example: `<|speaker:0|>Hello!<|speaker:1|>Hi there!<|speaker:0|>How are you?` with `reference_id: [""speaker-a-id"", ""speaker-b-id""]`.",
    };
    private static readonly TTSRequestOptionSet TTSRequestOptionSetOptions = TTSRequestOptionSet.Create();

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
        var command = new Command(@"create-tts-with-message-pack", @"Text to Speech");
                        command.Options.Add(Model);
                        command.Options.Add(References);
                        command.Options.Add(ReferenceId);                        command.Options.Add(TTSRequestOptionSetOptions.Text);
                        command.Options.Add(TTSRequestOptionSetOptions.Temperature);
                        command.Options.Add(TTSRequestOptionSetOptions.TopP);
                        command.Options.Add(TTSRequestOptionSetOptions.ChunkLength);
                        command.Options.Add(TTSRequestOptionSetOptions.Normalize);
                        command.Options.Add(TTSRequestOptionSetOptions.Format);
                        command.Options.Add(TTSRequestOptionSetOptions.SampleRate);
                        command.Options.Add(TTSRequestOptionSetOptions.Mp3Bitrate);
                        command.Options.Add(TTSRequestOptionSetOptions.OpusBitrate);
                        command.Options.Add(TTSRequestOptionSetOptions.Latency);
                        command.Options.Add(TTSRequestOptionSetOptions.MaxNewTokens);
                        command.Options.Add(TTSRequestOptionSetOptions.RepetitionPenalty);
                        command.Options.Add(TTSRequestOptionSetOptions.MinChunkLength);
                        command.Options.Add(TTSRequestOptionSetOptions.ConditionOnPreviousChunks);
                        command.Options.Add(TTSRequestOptionSetOptions.EarlyStopThreshold);
                        command.Options.Add(TTSRequestOptionSetOptions.Features);                        command.Options.Add(ProsodyOptions.Speed);
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
                        var model = parseResult.GetValue(Model);
                        var references = CliRuntime.WasSpecified(parseResult, References) ? parseResult.GetValue(References) : (__requestBase is { } __ReferencesBaseValue ? __ReferencesBaseValue.References : default);
                        var referenceId = CliRuntime.WasSpecified(parseResult, ReferenceId) ? parseResult.GetValue(ReferenceId) : (__requestBase is { } __ReferenceIdBaseValue ? __ReferenceIdBaseValue.ReferenceId : default);                        var text = parseResult.GetRequiredValue(TTSRequestOptionSetOptions.Text);
                        var temperature = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Temperature) ? parseResult.GetValue(TTSRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.TopP) ? parseResult.GetValue(TTSRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var chunkLength = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.ChunkLength) ? parseResult.GetValue(TTSRequestOptionSetOptions.ChunkLength) : (__requestBase is { } __ChunkLengthBaseValue ? __ChunkLengthBaseValue.ChunkLength : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Normalize) ? parseResult.GetValue(TTSRequestOptionSetOptions.Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var format = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Format) ? parseResult.GetValue(TTSRequestOptionSetOptions.Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.SampleRate) ? parseResult.GetValue(TTSRequestOptionSetOptions.SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var mp3Bitrate = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Mp3Bitrate) ? parseResult.GetValue(TTSRequestOptionSetOptions.Mp3Bitrate) : (__requestBase is { } __Mp3BitrateBaseValue ? __Mp3BitrateBaseValue.Mp3Bitrate : default);
                        var opusBitrate = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.OpusBitrate) ? parseResult.GetValue(TTSRequestOptionSetOptions.OpusBitrate) : (__requestBase is { } __OpusBitrateBaseValue ? __OpusBitrateBaseValue.OpusBitrate : default);
                        var latency = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Latency) ? parseResult.GetValue(TTSRequestOptionSetOptions.Latency) : (__requestBase is { } __LatencyBaseValue ? __LatencyBaseValue.Latency : default);
                        var maxNewTokens = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.MaxNewTokens) ? parseResult.GetValue(TTSRequestOptionSetOptions.MaxNewTokens) : (__requestBase is { } __MaxNewTokensBaseValue ? __MaxNewTokensBaseValue.MaxNewTokens : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.RepetitionPenalty) ? parseResult.GetValue(TTSRequestOptionSetOptions.RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var minChunkLength = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.MinChunkLength) ? parseResult.GetValue(TTSRequestOptionSetOptions.MinChunkLength) : (__requestBase is { } __MinChunkLengthBaseValue ? __MinChunkLengthBaseValue.MinChunkLength : default);
                        var conditionOnPreviousChunks = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.ConditionOnPreviousChunks) ? parseResult.GetValue(TTSRequestOptionSetOptions.ConditionOnPreviousChunks) : (__requestBase is { } __ConditionOnPreviousChunksBaseValue ? __ConditionOnPreviousChunksBaseValue.ConditionOnPreviousChunks : default);
                        var earlyStopThreshold = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.EarlyStopThreshold) ? parseResult.GetValue(TTSRequestOptionSetOptions.EarlyStopThreshold) : (__requestBase is { } __EarlyStopThresholdBaseValue ? __EarlyStopThresholdBaseValue.EarlyStopThreshold : default);
                        var features = CliRuntime.WasSpecified(parseResult, TTSRequestOptionSetOptions.Features) ? parseResult.GetValue(TTSRequestOptionSetOptions.Features) : (__requestBase is { } __FeaturesBaseValue ? __FeaturesBaseValue.Features : default);

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


                                await client.OpenAPIV1.CreateTtsWithMessagePackAsync(
                                    model: model,
                                    references: references,
                                    referenceId: referenceId,
                                    text: text,
                                    temperature: temperature,
                                    topP: topP,
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
                                    features: features,
                                    prosody: prosody,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}