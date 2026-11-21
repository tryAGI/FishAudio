#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1CreateAudioInfillCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model that regenerates the span. Only `drama-3` serves this endpoint.",
        DefaultValueFactory = _ => "drama-3",
    };

    private static Option<byte[]?> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.",
    };

    private static Option<byte[]?> PrefixAudio { get; } = new(
        name: @"--prefix-audio")
    {
        Description = @"Join two clips: the clip before the generated speech. Alone, the model continues it.",
    };

    private static Option<byte[]?> SuffixAudio { get; } = new(
        name: @"--suffix-audio")
    {
        Description = @"Join two clips: the clip after the generated speech. Requires `prefix_audio`.",
    };
    private static readonly CreateAudioInfillRequestOptionSet CreateAudioInfillRequestOptionSetOptions = CreateAudioInfillRequestOptionSet.Create();
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-audio-infill", @"Audio Infill
Regenerate part of a recording with drama-3 and get the whole take back.
Use it to apply a script change to existing audio without re-recording it:
send the take, the full revised `transcript` and the range to replace.
drama-3 regenerates that range in the speaker's voice, taken from the audio
around it, and returns the take with the new span in place.

A request takes one of two shapes. Mixing them is a 400.

## Edit a take

Send `audio` with where the span to replace starts and ends. Frames
`[prefix_frames, suffix_frames)` are regenerated; the audio before and after
them is kept.

- Give each position in frames (`prefix_frames`, `suffix_frames`) or in
  seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the
  two; both for the same side is a 400, and so is a side left out.
- Positions are absolute, counted from the start of the take, at 44100 /
  2048 (about 21.53) frames per second. Seconds are rounded to the nearest
  frame: `frames = round(seconds × 44100 / 2048)`.
- `prefix_frames` equal to `suffix_frames` inserts new speech at that point.
- Some original audio has to stay: `prefix_frames` 0 together with
  `suffix_frames` at the end of the take is a 400. For the best results keep
  at least 0.75 s on each side and replace at least 0.2 s.

## Join two clips

Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the
speech between them; with `prefix_audio` alone it continues the clip. No
positions are needed. `suffix_audio` without `prefix_audio` is a 400.

## Length of the new span

The model decides how long the regenerated span is, up to 1024 frames
(about 47 s). There is no way to request an exact length yet, so the span
can come out shorter or longer than the speech it replaces.

## Response

The whole take as one audio file in `format`. The kept parts are
re-synthesized together with the new span rather than copied byte for byte.

Send `Accept: text/event-stream` to receive server-sent events instead:
`start` (with `middle_start_seconds`), then `audio.delta` events whose
base64 `audio` fields concatenate into the same file, then `done` (with
`output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.");
                        command.Options.Add(Model);
                        command.Options.Add(Audio);
                        command.Options.Add(PrefixAudio);
                        command.Options.Add(SuffixAudio);                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.Transcript);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.Audioname);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.PrefixFrames);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.PrefixSeconds);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.SuffixFrames);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.SuffixSeconds);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.PrefixAudioname);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.SuffixAudioname);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.Format);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.SampleRate);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.Mp3Bitrate);
                        command.Options.Add(CreateAudioInfillRequestOptionSetOptions.OpusBitrate);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::FishAudio.CreateAudioInfillRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::FishAudio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var audio = CliRuntime.WasSpecified(parseResult, Audio) ? parseResult.GetValue(Audio) : (__requestBase is { } __AudioBaseValue ? __AudioBaseValue.Audio : default);
                        var prefixAudio = CliRuntime.WasSpecified(parseResult, PrefixAudio) ? parseResult.GetValue(PrefixAudio) : (__requestBase is { } __PrefixAudioBaseValue ? __PrefixAudioBaseValue.PrefixAudio : default);
                        var suffixAudio = CliRuntime.WasSpecified(parseResult, SuffixAudio) ? parseResult.GetValue(SuffixAudio) : (__requestBase is { } __SuffixAudioBaseValue ? __SuffixAudioBaseValue.SuffixAudio : default);                        var transcript = parseResult.GetRequiredValue(CreateAudioInfillRequestOptionSetOptions.Transcript);
                        var audioname = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.Audioname) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.Audioname) : (__requestBase is { } __AudionameBaseValue ? __AudionameBaseValue.Audioname : default);
                        var prefixFrames = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.PrefixFrames) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.PrefixFrames) : (__requestBase is { } __PrefixFramesBaseValue ? __PrefixFramesBaseValue.PrefixFrames : default);
                        var prefixSeconds = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.PrefixSeconds) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.PrefixSeconds) : (__requestBase is { } __PrefixSecondsBaseValue ? __PrefixSecondsBaseValue.PrefixSeconds : default);
                        var suffixFrames = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.SuffixFrames) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.SuffixFrames) : (__requestBase is { } __SuffixFramesBaseValue ? __SuffixFramesBaseValue.SuffixFrames : default);
                        var suffixSeconds = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.SuffixSeconds) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.SuffixSeconds) : (__requestBase is { } __SuffixSecondsBaseValue ? __SuffixSecondsBaseValue.SuffixSeconds : default);
                        var prefixAudioname = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.PrefixAudioname) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.PrefixAudioname) : (__requestBase is { } __PrefixAudionameBaseValue ? __PrefixAudionameBaseValue.PrefixAudioname : default);
                        var suffixAudioname = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.SuffixAudioname) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.SuffixAudioname) : (__requestBase is { } __SuffixAudionameBaseValue ? __SuffixAudionameBaseValue.SuffixAudioname : default);
                        var format = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.Format) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.SampleRate) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var mp3Bitrate = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.Mp3Bitrate) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.Mp3Bitrate) : (__requestBase is { } __Mp3BitrateBaseValue ? __Mp3BitrateBaseValue.Mp3Bitrate : default);
                        var opusBitrate = CliRuntime.WasSpecified(parseResult, CreateAudioInfillRequestOptionSetOptions.OpusBitrate) ? parseResult.GetValue(CreateAudioInfillRequestOptionSetOptions.OpusBitrate) : (__requestBase is { } __OpusBitrateBaseValue ? __OpusBitrateBaseValue.OpusBitrate : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.OpenAPIV1.CreateAudioInfillAsync(
                                    model: model,
                                    audio: audio,
                                    prefixAudio: prefixAudio,
                                    suffixAudio: suffixAudio,
                                    transcript: transcript,
                                    audioname: audioname,
                                    prefixFrames: prefixFrames,
                                    prefixSeconds: prefixSeconds,
                                    suffixFrames: suffixFrames,
                                    suffixSeconds: suffixSeconds,
                                    prefixAudioname: prefixAudioname,
                                    suffixAudioname: suffixAudioname,
                                    format: format,
                                    sampleRate: sampleRate,
                                    mp3Bitrate: mp3Bitrate,
                                    opusBitrate: opusBitrate,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}