#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateTtsStreamWithTimestampWithMessagePackCommandApiCommand
{
    private static Option<global::FishAudio.CreateTtsStreamWithTimestampModel?> Model { get; } = new(
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
    private static readonly TTSStreamWithTimestampRequestOptionSet TTSStreamWithTimestampRequestOptionSetOptions = TTSStreamWithTimestampRequestOptionSet.Create();

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
        var command = new Command(@"create-tts-stream-with-timestamp-with-message-pack", @"Text to Speech Stream with Timestamps");
                        command.Options.Add(Model);
                        command.Options.Add(References);
                        command.Options.Add(ReferenceId);                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Text);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Temperature);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.TopP);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.ChunkLength);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Normalize);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Format);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.SampleRate);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Mp3Bitrate);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.OpusBitrate);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Latency);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.MaxNewTokens);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.RepetitionPenalty);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.MinChunkLength);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.ConditionOnPreviousChunks);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.EarlyStopThreshold);
                        command.Options.Add(TTSStreamWithTimestampRequestOptionSetOptions.Features);                        command.Options.Add(ProsodyOptions.Speed);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.TTSStreamWithTimestampRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetValue(Model);
                        var references = CliRuntime.WasSpecified(parseResult, References) ? parseResult.GetValue(References) : (__requestBase is { } __ReferencesBaseValue ? __ReferencesBaseValue.References : default);
                        var referenceId = CliRuntime.WasSpecified(parseResult, ReferenceId) ? parseResult.GetValue(ReferenceId) : (__requestBase is { } __ReferenceIdBaseValue ? __ReferenceIdBaseValue.ReferenceId : default);                        var text = parseResult.GetRequiredValue(TTSStreamWithTimestampRequestOptionSetOptions.Text);
                        var temperature = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Temperature) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.TopP) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var chunkLength = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.ChunkLength) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.ChunkLength) : (__requestBase is { } __ChunkLengthBaseValue ? __ChunkLengthBaseValue.ChunkLength : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Normalize) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var format = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Format) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.SampleRate) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var mp3Bitrate = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Mp3Bitrate) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Mp3Bitrate) : (__requestBase is { } __Mp3BitrateBaseValue ? __Mp3BitrateBaseValue.Mp3Bitrate : default);
                        var opusBitrate = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.OpusBitrate) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.OpusBitrate) : (__requestBase is { } __OpusBitrateBaseValue ? __OpusBitrateBaseValue.OpusBitrate : default);
                        var latency = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Latency) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Latency) : (__requestBase is { } __LatencyBaseValue ? __LatencyBaseValue.Latency : default);
                        var maxNewTokens = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.MaxNewTokens) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.MaxNewTokens) : (__requestBase is { } __MaxNewTokensBaseValue ? __MaxNewTokensBaseValue.MaxNewTokens : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.RepetitionPenalty) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var minChunkLength = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.MinChunkLength) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.MinChunkLength) : (__requestBase is { } __MinChunkLengthBaseValue ? __MinChunkLengthBaseValue.MinChunkLength : default);
                        var conditionOnPreviousChunks = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.ConditionOnPreviousChunks) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.ConditionOnPreviousChunks) : (__requestBase is { } __ConditionOnPreviousChunksBaseValue ? __ConditionOnPreviousChunksBaseValue.ConditionOnPreviousChunks : default);
                        var earlyStopThreshold = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.EarlyStopThreshold) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.EarlyStopThreshold) : (__requestBase is { } __EarlyStopThresholdBaseValue ? __EarlyStopThresholdBaseValue.EarlyStopThreshold : default);
                        var features = CliRuntime.WasSpecified(parseResult, TTSStreamWithTimestampRequestOptionSetOptions.Features) ? parseResult.GetValue(TTSStreamWithTimestampRequestOptionSetOptions.Features) : (__requestBase is { } __FeaturesBaseValue ? __FeaturesBaseValue.Features : default);

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


                                var response = client.OpenAPIV1.CreateTtsStreamWithTimestampWithMessagePackAsync(
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
                                    cancellationToken: cancellationToken);

                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::FishAudio.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}