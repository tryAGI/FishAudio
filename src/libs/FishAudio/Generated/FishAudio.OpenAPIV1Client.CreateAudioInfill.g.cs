
#nullable enable

namespace FishAudio
{
    public partial class OpenAPIV1Client
    {


        private static readonly global::FishAudio.EndPointSecurityRequirement s_CreateAudioInfillSecurityRequirement0 =
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
        private static readonly global::FishAudio.EndPointSecurityRequirement[] s_CreateAudioInfillSecurityRequirements =
            new global::FishAudio.EndPointSecurityRequirement[]
            {                s_CreateAudioInfillSecurityRequirement0,
            };
        partial void PrepareCreateAudioInfillArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string model,
            global::FishAudio.CreateAudioInfillRequest request);
        partial void PrepareCreateAudioInfillRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string model,
            global::FishAudio.CreateAudioInfillRequest request);
        partial void ProcessCreateAudioInfillResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/audio/infill \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'model: drama-3' \<br/>
        ///   --form 'audio=@take.wav' \<br/>
        ///   --form-string 'transcript=Next, load the wafer into chamber B and run the standard CVD recipe.' \<br/>
        ///   --form 'prefix_frames=45' \<br/>
        ///   --form 'suffix_frames=62' \<br/>
        ///   --form 'format=mp3' \<br/>
        ///   --output edited.mp3
        /// </remarks>
        public async global::System.Threading.Tasks.Task CreateAudioInfillAsync(

            global::FishAudio.CreateAudioInfillRequest request,
            string model = "drama-3",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await CreateAudioInfillAsResponseAsync(

                request: request,
                model: model,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/audio/infill \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'model: drama-3' \<br/>
        ///   --form 'audio=@take.wav' \<br/>
        ///   --form-string 'transcript=Next, load the wafer into chamber B and run the standard CVD recipe.' \<br/>
        ///   --form 'prefix_frames=45' \<br/>
        ///   --form 'suffix_frames=62' \<br/>
        ///   --form 'format=mp3' \<br/>
        ///   --output edited.mp3
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> CreateAudioInfillAsResponseAsync(

            global::FishAudio.CreateAudioInfillRequest request,
            string model = "drama-3",
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAudioInfillArguments(
                httpClient: HttpClient,
                model: ref model,
                request: request);


            var __authorizations = global::FishAudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAudioInfillSecurityRequirements,
                operationName: "CreateAudioInfillAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::FishAudio.PathBuilder(
                                path: "/v1/audio/infill",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::FishAudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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

                __httpRequest.Headers.TryAddWithoutValidation("model", model.ToString());


                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Transcript ?? string.Empty),
                                name: "\"transcript\"");

                            if (request.Audio != default)
                            {

                                var __contentAudio = new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>());
                                __contentAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Audioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Audioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentAudio,
                                    name: "\"audio\"",
                                    fileName: request.Audioname != null ? $"\"{request.Audioname}\"" : string.Empty);
                                if (__contentAudio.Headers.ContentDisposition != null)
                                {
                                    __contentAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.PrefixFrames != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PrefixFrames, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"prefix_frames\"");

                            }
                            if (request.PrefixSeconds != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PrefixSeconds, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"prefix_seconds\"");

                            }
                            if (request.SuffixFrames != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.SuffixFrames, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"suffix_frames\"");

                            }
                            if (request.SuffixSeconds != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.SuffixSeconds, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"suffix_seconds\"");

                            }
                            if (request.PrefixAudio != default)
                            {

                                var __contentPrefixAudio = new global::System.Net.Http.ByteArrayContent(request.PrefixAudio ?? global::System.Array.Empty<byte>());
                                __contentPrefixAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.PrefixAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.PrefixAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentPrefixAudio,
                                    name: "\"prefix_audio\"",
                                    fileName: request.PrefixAudioname != null ? $"\"{request.PrefixAudioname}\"" : string.Empty);
                                if (__contentPrefixAudio.Headers.ContentDisposition != null)
                                {
                                    __contentPrefixAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.SuffixAudio != default)
                            {

                                var __contentSuffixAudio = new global::System.Net.Http.ByteArrayContent(request.SuffixAudio ?? global::System.Array.Empty<byte>());
                                __contentSuffixAudio.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.SuffixAudioname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.SuffixAudioname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentSuffixAudio,
                                    name: "\"suffix_audio\"",
                                    fileName: request.SuffixAudioname != null ? $"\"{request.SuffixAudioname}\"" : string.Empty);
                                if (__contentSuffixAudio.Headers.ContentDisposition != null)
                                {
                                    __contentSuffixAudio.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Format != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Format).HasValue ? (request.Format).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"format\"");

                            }
                            if (request.SampleRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.SampleRate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"sample_rate\"");

                            }
                            if (request.Mp3Bitrate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Mp3Bitrate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"mp3_bitrate\"");

                            }
                            if (request.OpusBitrate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OpusBitrate, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"opus_bitrate\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::FishAudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAudioInfillRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model,
                    request: request);

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
                                operationId: "createAudioInfill",
                                methodName: "CreateAudioInfillAsync",
                                pathTemplate: "\"/v1/audio/infill\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "createAudioInfill",
                                methodName: "CreateAudioInfillAsync",
                                pathTemplate: "\"/v1/audio/infill\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "createAudioInfill",
                                methodName: "CreateAudioInfillAsync",
                                pathTemplate: "\"/v1/audio/infill\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessCreateAudioInfillResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAudioInfill",
                                methodName: "CreateAudioInfillAsync",
                                pathTemplate: "\"/v1/audio/infill\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "createAudioInfill",
                                methodName: "CreateAudioInfillAsync",
                                pathTemplate: "\"/v1/audio/infill\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                            // Bad request syntax or unsupported method
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::FishAudio.CreateAudioInfillResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = __content_400 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.CreateAudioInfillResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 is { Length: > 0 } ? __content_400 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // No permission -- see authorization schemes
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::FishAudio.CreateAudioInfillResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.CreateAudioInfillResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 is { Length: > 0 } ? __content_401 : __response.ReasonPhrase ?? string.Empty,
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
                                global::FishAudio.CreateAudioInfillResponse? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = __content_402 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = __content_402 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.CreateAudioInfillResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 is { Length: > 0 } ? __content_402 : __response.ReasonPhrase ?? string.Empty,
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
                                global::FishAudio.CreateAudioInfillResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::FishAudio.CreateAudioInfillResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.CreateAudioInfillResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 is { Length: > 0 } ? __content_503 : __response.ReasonPhrase ?? string.Empty,
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
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::FishAudio.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::FishAudio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
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
                                    return new global::FishAudio.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
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
        /// <summary>
        /// Audio Infill<br/>
        /// Regenerate part of a recording with drama-3 and get the whole take back.<br/>
        /// Use it to apply a script change to existing audio without re-recording it:<br/>
        /// send the take, the full revised `transcript` and the range to replace.<br/>
        /// drama-3 regenerates that range in the speaker's voice, taken from the audio<br/>
        /// around it, and returns the take with the new span in place.<br/>
        /// A request takes one of two shapes. Mixing them is a 400.<br/>
        /// ## Edit a take<br/>
        /// Send `audio` with where the span to replace starts and ends. Frames<br/>
        /// `[prefix_frames, suffix_frames)` are regenerated; the audio before and after<br/>
        /// them is kept.<br/>
        /// - Give each position in frames (`prefix_frames`, `suffix_frames`) or in<br/>
        ///   seconds (`prefix_seconds`, `suffix_seconds`). Each side takes one of the<br/>
        ///   two; both for the same side is a 400, and so is a side left out.<br/>
        /// - Positions are absolute, counted from the start of the take, at 44100 /<br/>
        ///   2048 (about 21.53) frames per second. Seconds are rounded to the nearest<br/>
        ///   frame: `frames = round(seconds × 44100 / 2048)`.<br/>
        /// - `prefix_frames` equal to `suffix_frames` inserts new speech at that point.<br/>
        /// - Some original audio has to stay: `prefix_frames` 0 together with<br/>
        ///   `suffix_frames` at the end of the take is a 400. For the best results keep<br/>
        ///   at least 0.75 s on each side and replace at least 0.2 s.<br/>
        /// ## Join two clips<br/>
        /// Send `prefix_audio` and, optionally, `suffix_audio`. drama-3 generates the<br/>
        /// speech between them; with `prefix_audio` alone it continues the clip. No<br/>
        /// positions are needed. `suffix_audio` without `prefix_audio` is a 400.<br/>
        /// ## Length of the new span<br/>
        /// The model decides how long the regenerated span is, up to 1024 frames<br/>
        /// (about 47 s). There is no way to request an exact length yet, so the span<br/>
        /// can come out shorter or longer than the speech it replaces.<br/>
        /// ## Response<br/>
        /// The whole take as one audio file in `format`. The kept parts are<br/>
        /// re-synthesized together with the new span rather than copied byte for byte.<br/>
        /// Send `Accept: text/event-stream` to receive server-sent events instead:<br/>
        /// `start` (with `middle_start_seconds`), then `audio.delta` events whose<br/>
        /// base64 `audio` fields concatenate into the same file, then `done` (with<br/>
        /// `output_frames`, `middle_end_seconds` and `total_seconds`), then `[DONE]`.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="transcript">
        /// The full text of the result: the kept audio before the change, the new span and the kept audio after it, with the edit already applied. Sent to the model as written, without text normalization.
        /// </param>
        /// <param name="audio">
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="audioname">
        /// Edit a take: the whole recording to edit. Requires the start of the span (`prefix_frames` or `prefix_seconds`) and its end (`suffix_frames` or `suffix_seconds`). Do not combine with `prefix_audio` / `suffix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixFrames">
        /// Edit a take: the frame where the regenerated span starts. Everything before it is kept. A whole number of frames at 44100 / 2048 (about 21.53) frames per second; 0 keeps nothing before the span. Give this or `prefix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixSeconds">
        /// Edit a take: `prefix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `prefix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixFrames">
        /// Edit a take: the frame where the regenerated span ends and the kept audio resumes. Equal to `prefix_frames` inserts new speech at that point; the take's length keeps nothing after the span. Give this or `suffix_seconds`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixSeconds">
        /// Edit a take: `suffix_frames` given in seconds from the start of the take, rounded to the nearest frame. Give this or `suffix_frames`, not both.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixAudio">
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prefixAudioname">
        /// Join two clips: the clip before the generated speech. Alone, the model continues it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixAudio">
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="suffixAudioname">
        /// Join two clips: the clip after the generated speech. Requires `prefix_audio`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="format">
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mp3Bitrate">
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="opusBitrate">
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateAudioInfillAsync(
            string transcript,
            string model = "drama-3",
            byte[]? audio = default,
            string? audioname = default,
            int? prefixFrames = default,
            double? prefixSeconds = default,
            int? suffixFrames = default,
            double? suffixSeconds = default,
            byte[]? prefixAudio = default,
            string? prefixAudioname = default,
            byte[]? suffixAudio = default,
            string? suffixAudioname = default,
            global::FishAudio.CreateAudioInfillRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::FishAudio.CreateAudioInfillRequest
            {
                Transcript = transcript,
                Audio = audio,
                Audioname = audioname,
                PrefixFrames = prefixFrames,
                PrefixSeconds = prefixSeconds,
                SuffixFrames = suffixFrames,
                SuffixSeconds = suffixSeconds,
                PrefixAudio = prefixAudio,
                PrefixAudioname = prefixAudioname,
                SuffixAudio = suffixAudio,
                SuffixAudioname = suffixAudioname,
                Format = format,
                SampleRate = sampleRate,
                Mp3Bitrate = mp3Bitrate,
                OpusBitrate = opusBitrate,
            };

            await CreateAudioInfillAsync(
                model: model,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}