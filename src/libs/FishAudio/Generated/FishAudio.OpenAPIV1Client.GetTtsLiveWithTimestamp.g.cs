
#nullable enable

namespace FishAudio
{
    public partial class OpenAPIV1Client
    {


        private static readonly global::FishAudio.EndPointSecurityRequirement s_GetTtsLiveWithTimestampSecurityRequirement0 =
            new global::FishAudio.EndPointSecurityRequirement
            {
                Authorizations = new global::FishAudio.EndPointAuthorizationRequirement[]
                {                    new global::FishAudio.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::FishAudio.EndPointSecurityRequirement[] s_GetTtsLiveWithTimestampSecurityRequirements =
            new global::FishAudio.EndPointSecurityRequirement[]
            {                s_GetTtsLiveWithTimestampSecurityRequirement0,
            };
        partial void PrepareGetTtsLiveWithTimestampArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::FishAudio.GetTtsLiveWithTimestampModel? model);
        partial void PrepareGetTtsLiveWithTimestampRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::FishAudio.GetTtsLiveWithTimestampModel? model);
        partial void ProcessGetTtsLiveWithTimestampResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTtsLiveWithTimestampResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

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
        public async global::System.Threading.Tasks.Task<byte[]> GetTtsLiveWithTimestampAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetTtsLiveWithTimestampAsResponseAsync(
                model: model,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> GetTtsLiveWithTimestampAsStreamAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTtsLiveWithTimestampArguments(
                httpClient: HttpClient,
                model: ref model);


            var __authorizations = global::FishAudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTtsLiveWithTimestampSecurityRequirements,
                operationName: "GetTtsLiveWithTimestampAsync");

            using var __timeoutCancellationTokenSource = global::FishAudio.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::FishAudio.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::FishAudio.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::FishAudio.PathBuilder(
                                path: "/v1/tts/live/with-timestamp",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::FishAudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (model != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("model", model?.ToValueString() ?? string.Empty);
            }

                global::FishAudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetTtsLiveWithTimestampRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::FishAudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::FishAudio.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::FishAudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetTtsLiveWithTimestampResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // No permission -- see authorization schemes
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::FishAudio.GetTtsLiveWithTimestampResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::FishAudio.GetTtsLiveWithTimestampResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // No payment -- see charging schemes
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse3? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::FishAudio.GetTtsLiveWithTimestampResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::FishAudio.GetTtsLiveWithTimestampResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The server cannot process the request due to a high load
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse4? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::FishAudio.GetTtsLiveWithTimestampResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::FishAudio.GetTtsLiveWithTimestampResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            try
                            {
                                __response.EnsureSuccessStatusCode();

                                var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                return new global::FishAudio.ResponseStream(__response, __content);
                            }
                            catch (global::System.Exception __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::FishAudio.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                }
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<byte[]>> GetTtsLiveWithTimestampAsResponseAsync(
            global::FishAudio.GetTtsLiveWithTimestampModel? model = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTtsLiveWithTimestampArguments(
                httpClient: HttpClient,
                model: ref model);


            var __authorizations = global::FishAudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTtsLiveWithTimestampSecurityRequirements,
                operationName: "GetTtsLiveWithTimestampAsync");

            using var __timeoutCancellationTokenSource = global::FishAudio.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::FishAudio.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::FishAudio.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::FishAudio.PathBuilder(
                                path: "/v1/tts/live/with-timestamp",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::FishAudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (model != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("model", model?.ToValueString() ?? string.Empty);
            }

                global::FishAudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetTtsLiveWithTimestampRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::FishAudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::FishAudio.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::FishAudio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::FishAudio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetTtsLiveWithTimestampResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getTtsLiveWithTimestamp",
                                methodName: "GetTtsLiveWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/live/with-timestamp\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // No permission -- see authorization schemes
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::FishAudio.GetTtsLiveWithTimestampResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::FishAudio.GetTtsLiveWithTimestampResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // No payment -- see charging schemes
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse3? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::FishAudio.GetTtsLiveWithTimestampResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::FishAudio.GetTtsLiveWithTimestampResponse3.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The server cannot process the request due to a high load
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::FishAudio.GetTtsLiveWithTimestampResponse4? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::FishAudio.GetTtsLiveWithTimestampResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::FishAudio.GetTtsLiveWithTimestampResponse4.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.GetTtsLiveWithTimestampResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessGetTtsLiveWithTimestampResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::FishAudio.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::FishAudio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: null,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::FishAudio.AutoSDKHttpResponse<byte[]>(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::FishAudio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}