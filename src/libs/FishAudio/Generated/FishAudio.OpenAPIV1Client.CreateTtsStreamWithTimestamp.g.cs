
#nullable enable

namespace FishAudio
{
    public partial class OpenAPIV1Client
    {


        private static readonly global::FishAudio.EndPointSecurityRequirement s_CreateTtsStreamWithTimestampSecurityRequirement0 =
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
        private static readonly global::FishAudio.EndPointSecurityRequirement[] s_CreateTtsStreamWithTimestampSecurityRequirements =
            new global::FishAudio.EndPointSecurityRequirement[]
            {                s_CreateTtsStreamWithTimestampSecurityRequirement0,
            };
        partial void PrepareCreateTtsStreamWithTimestampArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::FishAudio.CreateTtsStreamWithTimestampModel model,
            global::FishAudio.TTSStreamWithTimestampRequest request);
        partial void PrepareCreateTtsStreamWithTimestampRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::FishAudio.CreateTtsStreamWithTimestampModel model,
            global::FishAudio.TTSStreamWithTimestampRequest request);
        partial void ProcessCreateTtsStreamWithTimestampResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text to Speech Stream with Timestamps
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --no-buffer --request POST \<br/>
        ///   --url https://api.fish.audio/v1/tts/stream/with-timestamp \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: s2-pro' \<br/>
        ///   --data '{<br/>
        ///     "text": "[happy] I can’t believe it’s been this long. It feels like forever since we last really talked. I’ve missed hearing your voice, your stories, even the little things you used to say. How have you been? I’ve thought about calling you so many times, but I never knew where to start. Seeing you again now makes me realize just how much I’ve missed you. We have so much to catch up on, and I don’t even know which part of my life to tell you about first.",<br/>
        ///     "format": "opus",<br/>
        ///     "normalize": true,<br/>
        ///     "temperature": 0.9,<br/>
        ///     "chunk_length": 100,<br/>
        ///     "top_p": 0.9,<br/>
        ///     "latency": "balanced",<br/>
        ///     "sample_rate": 48000,<br/>
        ///     "reference_id": "fbe02f8306fc4d3d915e9871722a39d5"<br/>
        ///   }'
        /// </remarks>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::FishAudio.CreateTtsStreamWithTimestampResponse> CreateTtsStreamWithTimestampAsync(

            global::FishAudio.TTSStreamWithTimestampRequest request,
            global::FishAudio.CreateTtsStreamWithTimestampModel model = global::FishAudio.CreateTtsStreamWithTimestampModel.S2Pro,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTtsStreamWithTimestampArguments(
                httpClient: HttpClient,
                model: ref model,
                request: request);


            var __authorizations = global::FishAudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTtsStreamWithTimestampSecurityRequirements,
                operationName: "CreateTtsStreamWithTimestampAsync");

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
                                path: "/v1/tts/stream/with-timestamp",
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

                __httpRequest.Headers.TryAddWithoutValidation("model", model.ToValueString());

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::FishAudio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTtsStreamWithTimestampRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model!,
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
                                operationId: "createTtsStreamWithTimestamp",
                                methodName: "CreateTtsStreamWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/stream/with-timestamp\"",
                                httpMethod: "POST",
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
                                operationId: "createTtsStreamWithTimestamp",
                                methodName: "CreateTtsStreamWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/stream/with-timestamp\"",
                                httpMethod: "POST",
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
                                operationId: "createTtsStreamWithTimestamp",
                                methodName: "CreateTtsStreamWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/stream/with-timestamp\"",
                                httpMethod: "POST",
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
                ProcessCreateTtsStreamWithTimestampResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createTtsStreamWithTimestamp",
                                methodName: "CreateTtsStreamWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/stream/with-timestamp\"",
                                httpMethod: "POST",
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
                                operationId: "createTtsStreamWithTimestamp",
                                methodName: "CreateTtsStreamWithTimestampAsync",
                                pathTemplate: "\"/v1/tts/stream/with-timestamp\"",
                                httpMethod: "POST",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::FishAudio.CreateTtsStreamWithTimestampResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::FishAudio.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Text to Speech Stream with Timestamps
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="text">
        /// Text to convert to speech.
        /// </param>
        /// <param name="temperature">
        /// Controls expressiveness. Higher is more varied, lower is more consistent.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="topP">
        /// Controls diversity via nucleus sampling.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="references">
        /// Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.
        /// </param>
        /// <param name="referenceId">
        /// Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `&lt;|speaker:0|&gt;` and `&lt;|speaker:1|&gt;` to indicate speaker changes. Example: `&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!&lt;|speaker:0|&gt;How are you?` with `reference_id: ["speaker-a-id", "speaker-b-id"]`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prosody">
        /// Speed and volume adjustments for the output.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkLength">
        /// Text segment size for processing.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="normalize">
        /// Normalizes text for English and Chinese, improving stability for numbers.<br/>
        /// Default Value: true
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
        /// <param name="latency">
        /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum audio tokens to generate per text chunk.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating audio patterns. Values above 1.0 reduce repetition.<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="minChunkLength">
        /// Minimum characters before splitting into a new chunk.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="conditionOnPreviousChunks">
        /// Use previous audio as context for voice consistency.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="earlyStopThreshold">
        /// Early stopping threshold for batch processing.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::FishAudio.CreateTtsStreamWithTimestampResponse> CreateTtsStreamWithTimestampAsync(
            string text,
            global::FishAudio.CreateTtsStreamWithTimestampModel model = global::FishAudio.CreateTtsStreamWithTimestampModel.S2Pro,
            double? temperature = default,
            double? topP = default,
            global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>? references = default,
            global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? referenceId = default,
            global::FishAudio.ProsodyControl? prosody = default,
            int? chunkLength = default,
            bool? normalize = default,
            global::FishAudio.TTSStreamWithTimestampRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::FishAudio.TTSStreamWithTimestampRequestLatency? latency = default,
            int? maxNewTokens = default,
            double? repetitionPenalty = default,
            int? minChunkLength = default,
            bool? conditionOnPreviousChunks = default,
            double? earlyStopThreshold = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::FishAudio.TTSStreamWithTimestampRequest
            {
                Text = text,
                Temperature = temperature,
                TopP = topP,
                References = references,
                ReferenceId = referenceId,
                Prosody = prosody,
                ChunkLength = chunkLength,
                Normalize = normalize,
                Format = format,
                SampleRate = sampleRate,
                Mp3Bitrate = mp3Bitrate,
                OpusBitrate = opusBitrate,
                Latency = latency,
                MaxNewTokens = maxNewTokens,
                RepetitionPenalty = repetitionPenalty,
                MinChunkLength = minChunkLength,
                ConditionOnPreviousChunks = conditionOnPreviousChunks,
                EarlyStopThreshold = earlyStopThreshold,
            };

            var __enumerable = CreateTtsStreamWithTimestampAsync(
                model: model,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}