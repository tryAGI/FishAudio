#nullable enable

namespace FishAudio
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Text to Speech Live with Timestamps (WebSocket)<br/>
        /// Streaming text-to-speech over a WebSocket that returns word-level timestamps<br/>
        /// alongside the audio. Connect to `wss://api.fish.audio/v1/tts/live/with-timestamp`;<br/>
        /// this is a WebSocket upgrade, not a plain HTTP request.<br/>
        /// Use it when you need to feed text in as it is produced — an LLM token stream,<br/>
        /// a live caption feed — and want word timings for lip-sync, subtitles or<br/>
        /// highlighting. For a one-shot request use `POST /v1/tts/stream/with-timestamp`<br/>
        /// instead.<br/>
        /// ## Handshake<br/>
        /// Send the same headers as any other API call:<br/>
        /// - `Authorization: Bearer &lt;your-api-key&gt;`<br/>
        /// - `model: &lt;model&gt;` — optional, defaults to `s2.1-pro`.<br/>
        /// ## Framing<br/>
        /// Every frame in both directions is a MessagePack-encoded **binary** frame<br/>
        /// holding a map with an `event` key. Text frames are ignored by the server and<br/>
        /// should be ignored by your client.<br/>
        /// ## Client to server<br/>
        /// The inbound protocol is identical to `/v1/tts/live`:<br/>
        /// - `start` — opens the session. Send it once per session, before any other<br/>
        ///   event. Carries a `request` object with the same fields as the<br/>
        ///   `POST /v1/tts` body; leave `text` empty and stream the words with `text`<br/>
        ///   events. After a `finish` you may send another `start` to run a new session<br/>
        ///   on the same socket.<br/>
        /// - `text` — appends a text fragment to the session buffer.<br/>
        /// - `flush` — forces buffered text through generation without waiting for the<br/>
        ///   chunk to fill. The session stays open.<br/>
        /// - `stop` — ends the session. The server drains the buffer and answers with a<br/>
        ///   final `finish` event.<br/>
        /// ## Server to client<br/>
        /// - `audio` — one audio chunk. Beyond the `audio` bytes it carries `content`,<br/>
        ///   `alignment`, `chunk_seq` and `chunk_audio_offset_sec`; these last three are<br/>
        ///   what this endpoint adds over `/v1/tts/live`. Concatenate every `audio`<br/>
        ///   payload in arrival order to reconstruct the full audio. Note that `audio`<br/>
        ///   here is raw MessagePack `bin`, not the base64 string used by the SSE<br/>
        ///   endpoint.<br/>
        /// - `finish` — terminal event, with `reason` of `stop` or `error`.<br/>
        /// - `error` — a request-level failure such as an invalid `start` request or a<br/>
        ///   concurrency refusal; the socket closes afterwards.<br/>
        /// ## Reading the alignment<br/>
        /// `alignment` is a **cumulative snapshot** for its `chunk_seq`, not a delta:<br/>
        /// when it is non-null, replace the alignment you stored for that chunk rather<br/>
        /// than appending to it. A `null` alignment means nothing new has been committed<br/>
        /// for the chunk yet, which is normal early on.<br/>
        /// Segment times inside `alignment` are relative to the start of their chunk.<br/>
        /// `chunk_audio_offset_sec` is the chunk's own start time within the full audio,<br/>
        /// so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.<br/>
        /// Both `chunk_seq` and `chunk_audio_offset_sec` are monotonically<br/>
        /// non-decreasing. A frame may be labelled with the previous chunk's<br/>
        /// `chunk_seq` while carrying the next chunk's audio bytes, so never use<br/>
        /// `chunk_seq` to attribute audio bytes — only alignment.
        /// </summary>
        /// <param name="model">
        /// Default Value: s2.1-pro
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// import asyncio<br/>
        /// import ormsgpack<br/>
        /// import websockets<br/>
        /// TEXT = "Hello there. This is a live synthesis, streamed word by word."<br/>
        /// async def send_text(socket) -&gt; None:<br/>
        ///     # `request` takes the same fields as POST /v1/tts. Leave `text` empty and<br/>
        ///     # stream the words in as they become available.<br/>
        ///     await socket.send(<br/>
        ///         ormsgpack.packb(<br/>
        ///             {<br/>
        ///                 "event": "start",<br/>
        ///                 "request": {<br/>
        ///                     "text": "",<br/>
        ///                     "format": "opus",<br/>
        ///                     "latency": "balanced",<br/>
        ///                     "chunk_length": 100,<br/>
        ///                     "reference_id": "fbe02f8306fc4d3d915e9871722a39d5",<br/>
        ///                 },<br/>
        ///             }<br/>
        ///         )<br/>
        ///     )<br/>
        ///     for word in TEXT.split(" "):<br/>
        ///         await socket.send(ormsgpack.packb({"event": "text", "text": word + " "}))<br/>
        ///     await socket.send(ormsgpack.packb({"event": "stop"}))<br/>
        /// async def main() -&gt; None:<br/>
        ///     async with websockets.connect(<br/>
        ///         "wss://api.fish.audio/v1/tts/live/with-timestamp",<br/>
        ///         additional_headers={<br/>
        ///             "Authorization": "Bearer &lt;token&gt;",<br/>
        ///             "model": "s2.1-pro-free",<br/>
        ///         },<br/>
        ///         max_size=None,<br/>
        ///     ) as socket:<br/>
        ///         # Send and receive concurrently. Sending everything before reading can<br/>
        ///         # stall on flow control once the audio outpaces your receive buffer.<br/>
        ///         sender = asyncio.create_task(send_text(socket))<br/>
        ///         audio = bytearray()<br/>
        ///         alignments: dict[int, dict] = {}<br/>
        ///         offsets: dict[int, float] = {}<br/>
        ///         try:<br/>
        ///             async for frame in socket:<br/>
        ///                 if isinstance(frame, str):<br/>
        ///                     continue<br/>
        ///                 message = ormsgpack.unpackb(frame)<br/>
        ///                 if message["event"] == "audio":<br/>
        ///                     audio += message["audio"]<br/>
        ///                     offsets[message["chunk_seq"]] = message["chunk_audio_offset_sec"]<br/>
        ///                     if message["alignment"] is not None:<br/>
        ///                         # Cumulative snapshot: replace the chunk, never append.<br/>
        ///                         alignments[message["chunk_seq"]] = message["alignment"]<br/>
        ///                 elif message["event"] == "finish":<br/>
        ///                     if message["reason"] == "error":<br/>
        ///                         raise RuntimeError(message.get("message", "synthesis failed"))<br/>
        ///                     break<br/>
        ///                 elif message["event"] == "error":<br/>
        ///                     raise RuntimeError(message["error"])<br/>
        ///         finally:<br/>
        ///             sender.cancel()<br/>
        ///         with open("output.opus", "wb") as f:<br/>
        ///             f.write(audio)<br/>
        ///         # Segment times are chunk-relative; fold in the offset to get absolute.<br/>
        ///         for chunk_seq in sorted(alignments):<br/>
        ///             offset = offsets[chunk_seq]<br/>
        ///             for segment in alignments[chunk_seq]["segments"]:<br/>
        ///                 start = offset + segment["start"]<br/>
        ///                 end = offset + segment["end"]<br/>
        ///                 print(f"{start:6.2f}s -&gt; {end:6.2f}s  {segment['text']}")<br/>
        /// asyncio.run(main())
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GetTtsLiveWithTimestampAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Speech Live with Timestamps (WebSocket)<br/>
        /// Streaming text-to-speech over a WebSocket that returns word-level timestamps<br/>
        /// alongside the audio. Connect to `wss://api.fish.audio/v1/tts/live/with-timestamp`;<br/>
        /// this is a WebSocket upgrade, not a plain HTTP request.<br/>
        /// Use it when you need to feed text in as it is produced — an LLM token stream,<br/>
        /// a live caption feed — and want word timings for lip-sync, subtitles or<br/>
        /// highlighting. For a one-shot request use `POST /v1/tts/stream/with-timestamp`<br/>
        /// instead.<br/>
        /// ## Handshake<br/>
        /// Send the same headers as any other API call:<br/>
        /// - `Authorization: Bearer &lt;your-api-key&gt;`<br/>
        /// - `model: &lt;model&gt;` — optional, defaults to `s2.1-pro`.<br/>
        /// ## Framing<br/>
        /// Every frame in both directions is a MessagePack-encoded **binary** frame<br/>
        /// holding a map with an `event` key. Text frames are ignored by the server and<br/>
        /// should be ignored by your client.<br/>
        /// ## Client to server<br/>
        /// The inbound protocol is identical to `/v1/tts/live`:<br/>
        /// - `start` — opens the session. Send it once per session, before any other<br/>
        ///   event. Carries a `request` object with the same fields as the<br/>
        ///   `POST /v1/tts` body; leave `text` empty and stream the words with `text`<br/>
        ///   events. After a `finish` you may send another `start` to run a new session<br/>
        ///   on the same socket.<br/>
        /// - `text` — appends a text fragment to the session buffer.<br/>
        /// - `flush` — forces buffered text through generation without waiting for the<br/>
        ///   chunk to fill. The session stays open.<br/>
        /// - `stop` — ends the session. The server drains the buffer and answers with a<br/>
        ///   final `finish` event.<br/>
        /// ## Server to client<br/>
        /// - `audio` — one audio chunk. Beyond the `audio` bytes it carries `content`,<br/>
        ///   `alignment`, `chunk_seq` and `chunk_audio_offset_sec`; these last three are<br/>
        ///   what this endpoint adds over `/v1/tts/live`. Concatenate every `audio`<br/>
        ///   payload in arrival order to reconstruct the full audio. Note that `audio`<br/>
        ///   here is raw MessagePack `bin`, not the base64 string used by the SSE<br/>
        ///   endpoint.<br/>
        /// - `finish` — terminal event, with `reason` of `stop` or `error`.<br/>
        /// - `error` — a request-level failure such as an invalid `start` request or a<br/>
        ///   concurrency refusal; the socket closes afterwards.<br/>
        /// ## Reading the alignment<br/>
        /// `alignment` is a **cumulative snapshot** for its `chunk_seq`, not a delta:<br/>
        /// when it is non-null, replace the alignment you stored for that chunk rather<br/>
        /// than appending to it. A `null` alignment means nothing new has been committed<br/>
        /// for the chunk yet, which is normal early on.<br/>
        /// Segment times inside `alignment` are relative to the start of their chunk.<br/>
        /// `chunk_audio_offset_sec` is the chunk's own start time within the full audio,<br/>
        /// so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.<br/>
        /// Both `chunk_seq` and `chunk_audio_offset_sec` are monotonically<br/>
        /// non-decreasing. A frame may be labelled with the previous chunk's<br/>
        /// `chunk_seq` while carrying the next chunk's audio bytes, so never use<br/>
        /// `chunk_seq` to attribute audio bytes — only alignment.
        /// </summary>
        /// <param name="model">
        /// Default Value: s2.1-pro
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// import asyncio<br/>
        /// import ormsgpack<br/>
        /// import websockets<br/>
        /// TEXT = "Hello there. This is a live synthesis, streamed word by word."<br/>
        /// async def send_text(socket) -&gt; None:<br/>
        ///     # `request` takes the same fields as POST /v1/tts. Leave `text` empty and<br/>
        ///     # stream the words in as they become available.<br/>
        ///     await socket.send(<br/>
        ///         ormsgpack.packb(<br/>
        ///             {<br/>
        ///                 "event": "start",<br/>
        ///                 "request": {<br/>
        ///                     "text": "",<br/>
        ///                     "format": "opus",<br/>
        ///                     "latency": "balanced",<br/>
        ///                     "chunk_length": 100,<br/>
        ///                     "reference_id": "fbe02f8306fc4d3d915e9871722a39d5",<br/>
        ///                 },<br/>
        ///             }<br/>
        ///         )<br/>
        ///     )<br/>
        ///     for word in TEXT.split(" "):<br/>
        ///         await socket.send(ormsgpack.packb({"event": "text", "text": word + " "}))<br/>
        ///     await socket.send(ormsgpack.packb({"event": "stop"}))<br/>
        /// async def main() -&gt; None:<br/>
        ///     async with websockets.connect(<br/>
        ///         "wss://api.fish.audio/v1/tts/live/with-timestamp",<br/>
        ///         additional_headers={<br/>
        ///             "Authorization": "Bearer &lt;token&gt;",<br/>
        ///             "model": "s2.1-pro-free",<br/>
        ///         },<br/>
        ///         max_size=None,<br/>
        ///     ) as socket:<br/>
        ///         # Send and receive concurrently. Sending everything before reading can<br/>
        ///         # stall on flow control once the audio outpaces your receive buffer.<br/>
        ///         sender = asyncio.create_task(send_text(socket))<br/>
        ///         audio = bytearray()<br/>
        ///         alignments: dict[int, dict] = {}<br/>
        ///         offsets: dict[int, float] = {}<br/>
        ///         try:<br/>
        ///             async for frame in socket:<br/>
        ///                 if isinstance(frame, str):<br/>
        ///                     continue<br/>
        ///                 message = ormsgpack.unpackb(frame)<br/>
        ///                 if message["event"] == "audio":<br/>
        ///                     audio += message["audio"]<br/>
        ///                     offsets[message["chunk_seq"]] = message["chunk_audio_offset_sec"]<br/>
        ///                     if message["alignment"] is not None:<br/>
        ///                         # Cumulative snapshot: replace the chunk, never append.<br/>
        ///                         alignments[message["chunk_seq"]] = message["alignment"]<br/>
        ///                 elif message["event"] == "finish":<br/>
        ///                     if message["reason"] == "error":<br/>
        ///                         raise RuntimeError(message.get("message", "synthesis failed"))<br/>
        ///                     break<br/>
        ///                 elif message["event"] == "error":<br/>
        ///                     raise RuntimeError(message["error"])<br/>
        ///         finally:<br/>
        ///             sender.cancel()<br/>
        ///         with open("output.opus", "wb") as f:<br/>
        ///             f.write(audio)<br/>
        ///         # Segment times are chunk-relative; fold in the offset to get absolute.<br/>
        ///         for chunk_seq in sorted(alignments):<br/>
        ///             offset = offsets[chunk_seq]<br/>
        ///             for segment in alignments[chunk_seq]["segments"]:<br/>
        ///                 start = offset + segment["start"]<br/>
        ///                 end = offset + segment["end"]<br/>
        ///                 print(f"{start:6.2f}s -&gt; {end:6.2f}s  {segment['text']}")<br/>
        /// asyncio.run(main())
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetTtsLiveWithTimestampAsStreamAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Speech Live with Timestamps (WebSocket)<br/>
        /// Streaming text-to-speech over a WebSocket that returns word-level timestamps<br/>
        /// alongside the audio. Connect to `wss://api.fish.audio/v1/tts/live/with-timestamp`;<br/>
        /// this is a WebSocket upgrade, not a plain HTTP request.<br/>
        /// Use it when you need to feed text in as it is produced — an LLM token stream,<br/>
        /// a live caption feed — and want word timings for lip-sync, subtitles or<br/>
        /// highlighting. For a one-shot request use `POST /v1/tts/stream/with-timestamp`<br/>
        /// instead.<br/>
        /// ## Handshake<br/>
        /// Send the same headers as any other API call:<br/>
        /// - `Authorization: Bearer &lt;your-api-key&gt;`<br/>
        /// - `model: &lt;model&gt;` — optional, defaults to `s2.1-pro`.<br/>
        /// ## Framing<br/>
        /// Every frame in both directions is a MessagePack-encoded **binary** frame<br/>
        /// holding a map with an `event` key. Text frames are ignored by the server and<br/>
        /// should be ignored by your client.<br/>
        /// ## Client to server<br/>
        /// The inbound protocol is identical to `/v1/tts/live`:<br/>
        /// - `start` — opens the session. Send it once per session, before any other<br/>
        ///   event. Carries a `request` object with the same fields as the<br/>
        ///   `POST /v1/tts` body; leave `text` empty and stream the words with `text`<br/>
        ///   events. After a `finish` you may send another `start` to run a new session<br/>
        ///   on the same socket.<br/>
        /// - `text` — appends a text fragment to the session buffer.<br/>
        /// - `flush` — forces buffered text through generation without waiting for the<br/>
        ///   chunk to fill. The session stays open.<br/>
        /// - `stop` — ends the session. The server drains the buffer and answers with a<br/>
        ///   final `finish` event.<br/>
        /// ## Server to client<br/>
        /// - `audio` — one audio chunk. Beyond the `audio` bytes it carries `content`,<br/>
        ///   `alignment`, `chunk_seq` and `chunk_audio_offset_sec`; these last three are<br/>
        ///   what this endpoint adds over `/v1/tts/live`. Concatenate every `audio`<br/>
        ///   payload in arrival order to reconstruct the full audio. Note that `audio`<br/>
        ///   here is raw MessagePack `bin`, not the base64 string used by the SSE<br/>
        ///   endpoint.<br/>
        /// - `finish` — terminal event, with `reason` of `stop` or `error`.<br/>
        /// - `error` — a request-level failure such as an invalid `start` request or a<br/>
        ///   concurrency refusal; the socket closes afterwards.<br/>
        /// ## Reading the alignment<br/>
        /// `alignment` is a **cumulative snapshot** for its `chunk_seq`, not a delta:<br/>
        /// when it is non-null, replace the alignment you stored for that chunk rather<br/>
        /// than appending to it. A `null` alignment means nothing new has been committed<br/>
        /// for the chunk yet, which is normal early on.<br/>
        /// Segment times inside `alignment` are relative to the start of their chunk.<br/>
        /// `chunk_audio_offset_sec` is the chunk's own start time within the full audio,<br/>
        /// so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.<br/>
        /// Both `chunk_seq` and `chunk_audio_offset_sec` are monotonically<br/>
        /// non-decreasing. A frame may be labelled with the previous chunk's<br/>
        /// `chunk_seq` while carrying the next chunk's audio bytes, so never use<br/>
        /// `chunk_seq` to attribute audio bytes — only alignment.
        /// </summary>
        /// <param name="model">
        /// Default Value: s2.1-pro
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// import asyncio<br/>
        /// import ormsgpack<br/>
        /// import websockets<br/>
        /// TEXT = "Hello there. This is a live synthesis, streamed word by word."<br/>
        /// async def send_text(socket) -&gt; None:<br/>
        ///     # `request` takes the same fields as POST /v1/tts. Leave `text` empty and<br/>
        ///     # stream the words in as they become available.<br/>
        ///     await socket.send(<br/>
        ///         ormsgpack.packb(<br/>
        ///             {<br/>
        ///                 "event": "start",<br/>
        ///                 "request": {<br/>
        ///                     "text": "",<br/>
        ///                     "format": "opus",<br/>
        ///                     "latency": "balanced",<br/>
        ///                     "chunk_length": 100,<br/>
        ///                     "reference_id": "fbe02f8306fc4d3d915e9871722a39d5",<br/>
        ///                 },<br/>
        ///             }<br/>
        ///         )<br/>
        ///     )<br/>
        ///     for word in TEXT.split(" "):<br/>
        ///         await socket.send(ormsgpack.packb({"event": "text", "text": word + " "}))<br/>
        ///     await socket.send(ormsgpack.packb({"event": "stop"}))<br/>
        /// async def main() -&gt; None:<br/>
        ///     async with websockets.connect(<br/>
        ///         "wss://api.fish.audio/v1/tts/live/with-timestamp",<br/>
        ///         additional_headers={<br/>
        ///             "Authorization": "Bearer &lt;token&gt;",<br/>
        ///             "model": "s2.1-pro-free",<br/>
        ///         },<br/>
        ///         max_size=None,<br/>
        ///     ) as socket:<br/>
        ///         # Send and receive concurrently. Sending everything before reading can<br/>
        ///         # stall on flow control once the audio outpaces your receive buffer.<br/>
        ///         sender = asyncio.create_task(send_text(socket))<br/>
        ///         audio = bytearray()<br/>
        ///         alignments: dict[int, dict] = {}<br/>
        ///         offsets: dict[int, float] = {}<br/>
        ///         try:<br/>
        ///             async for frame in socket:<br/>
        ///                 if isinstance(frame, str):<br/>
        ///                     continue<br/>
        ///                 message = ormsgpack.unpackb(frame)<br/>
        ///                 if message["event"] == "audio":<br/>
        ///                     audio += message["audio"]<br/>
        ///                     offsets[message["chunk_seq"]] = message["chunk_audio_offset_sec"]<br/>
        ///                     if message["alignment"] is not None:<br/>
        ///                         # Cumulative snapshot: replace the chunk, never append.<br/>
        ///                         alignments[message["chunk_seq"]] = message["alignment"]<br/>
        ///                 elif message["event"] == "finish":<br/>
        ///                     if message["reason"] == "error":<br/>
        ///                         raise RuntimeError(message.get("message", "synthesis failed"))<br/>
        ///                     break<br/>
        ///                 elif message["event"] == "error":<br/>
        ///                     raise RuntimeError(message["error"])<br/>
        ///         finally:<br/>
        ///             sender.cancel()<br/>
        ///         with open("output.opus", "wb") as f:<br/>
        ///             f.write(audio)<br/>
        ///         # Segment times are chunk-relative; fold in the offset to get absolute.<br/>
        ///         for chunk_seq in sorted(alignments):<br/>
        ///             offset = offsets[chunk_seq]<br/>
        ///             for segment in alignments[chunk_seq]["segments"]:<br/>
        ///                 start = offset + segment["start"]<br/>
        ///                 end = offset + segment["end"]<br/>
        ///                 print(f"{start:6.2f}s -&gt; {end:6.2f}s  {segment['text']}")<br/>
        /// asyncio.run(main())
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<byte[]>> GetTtsLiveWithTimestampAsResponseAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}