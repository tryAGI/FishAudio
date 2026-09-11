#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace FishAudio.CLI.Commands;

internal static partial class OpenAPIV1GetTtsLiveWithTimestampCommandApiCommand
{
    private static Option<global::FishAudio.GetTtsLiveWithTimestampModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Specify which TTS model to use. Use `s2.1-pro-free` for the free developer tier. `drama-3-preview` is a preview model; its behavior and availability may change. If omitted or set to an unrecognized value, the request falls back to `s2.1-pro`.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-tts-live-with-timestamp", @"Text to Speech Live with Timestamps (WebSocket)
Streaming text-to-speech over a WebSocket that returns word-level timestamps
alongside the audio. Connect to `wss://api.fish.audio/v1/tts/live/with-timestamp`;
this is a WebSocket upgrade, not a plain HTTP request.

Use it when you need to feed text in as it is produced — an LLM token stream,
a live caption feed — and want word timings for lip-sync, subtitles or
highlighting. For a one-shot request use `POST /v1/tts/stream/with-timestamp`
instead.

## Handshake

Send the same headers as any other API call:

- `Authorization: Bearer &lt;your-api-key&gt;`
- `model: &lt;model&gt;` — optional, defaults to `s2.1-pro`.

## Framing

Every frame in both directions is a MessagePack-encoded **binary** frame
holding a map with an `event` key. Text frames are ignored by the server and
should be ignored by your client.

## Client to server

The inbound protocol is identical to `/v1/tts/live`:

- `start` — opens the session. Send it once per session, before any other
  event. Carries a `request` object with the same fields as the
  `POST /v1/tts` body; leave `text` empty and stream the words with `text`
  events. After a `finish` you may send another `start` to run a new session
  on the same socket.
- `text` — appends a text fragment to the session buffer.
- `flush` — forces buffered text through generation without waiting for the
  chunk to fill. The session stays open.
- `stop` — ends the session. The server drains the buffer and answers with a
  final `finish` event.

## Server to client

- `audio` — one audio chunk. Beyond the `audio` bytes it carries `content`,
  `alignment`, `chunk_seq` and `chunk_audio_offset_sec`; these last three are
  what this endpoint adds over `/v1/tts/live`. Concatenate every `audio`
  payload in arrival order to reconstruct the full audio. Note that `audio`
  here is raw MessagePack `bin`, not the base64 string used by the SSE
  endpoint.
- `finish` — terminal event, with `reason` of `stop` or `error`.
- `error` — a request-level failure such as an invalid `start` request or a
  concurrency refusal; the socket closes afterwards.

## Reading the alignment

`alignment` is a **cumulative snapshot** for its `chunk_seq`, not a delta:
when it is non-null, replace the alignment you stored for that chunk rather
than appending to it. A `null` alignment means nothing new has been committed
for the chunk yet, which is normal early on.

Segment times inside `alignment` are relative to the start of their chunk.
`chunk_audio_offset_sec` is the chunk's own start time within the full audio,
so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.
Both `chunk_seq` and `chunk_audio_offset_sec` are monotonically
non-decreasing. A frame may be labelled with the previous chunk's
`chunk_seq` while carrying the next chunk's audio bytes, so never use
`chunk_seq` to attribute audio bytes — only alignment.");
                        command.Options.Add(Model);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetValue(Model);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenAPIV1.GetTtsLiveWithTimestampAsync(
                                    model: model,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}