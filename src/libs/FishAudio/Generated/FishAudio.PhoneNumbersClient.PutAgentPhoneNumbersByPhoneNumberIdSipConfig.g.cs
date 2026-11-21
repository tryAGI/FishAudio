
#nullable enable

namespace FishAudio
{
    public partial class PhoneNumbersClient
    {


        private static readonly global::FishAudio.EndPointSecurityRequirement s_PutAgentPhoneNumbersByPhoneNumberIdSipConfigSecurityRequirement0 =
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
        private static readonly global::FishAudio.EndPointSecurityRequirement[] s_PutAgentPhoneNumbersByPhoneNumberIdSipConfigSecurityRequirements =
            new global::FishAudio.EndPointSecurityRequirement[]
            {                s_PutAgentPhoneNumbersByPhoneNumberIdSipConfigSecurityRequirement0,
            };
        partial void PreparePutAgentPhoneNumbersByPhoneNumberIdSipConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string phoneNumberId,
            global::FishAudio.PublicSipNumberConfigPayload request);
        partial void PreparePutAgentPhoneNumbersByPhoneNumberIdSipConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string phoneNumberId,
            global::FishAudio.PublicSipNumberConfigPayload request);
        partial void ProcessPutAgentPhoneNumbersByPhoneNumberIdSipConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPutAgentPhoneNumbersByPhoneNumberIdSipConfigResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
            string phoneNumberId,

            global::FishAudio.PublicSipNumberConfigPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsResponseAsync(
                phoneNumberId: phoneNumberId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse>> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsResponseAsync(
            string phoneNumberId,

            global::FishAudio.PublicSipNumberConfigPayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutAgentPhoneNumbersByPhoneNumberIdSipConfigArguments(
                httpClient: HttpClient,
                phoneNumberId: ref phoneNumberId,
                request: request);


            var __authorizations = global::FishAudio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PutAgentPhoneNumbersByPhoneNumberIdSipConfigSecurityRequirements,
                operationName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync");

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
                                path: $"/v1/agent/phone-numbers/{phoneNumberId}/sip-config",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::FishAudio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                PreparePutAgentPhoneNumbersByPhoneNumberIdSipConfigRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    phoneNumberId: phoneNumberId,
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
                                operationId: "putAgentPhoneNumbersByPhoneNumberIdSipConfig",
                                methodName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync",
                                pathTemplate: "$\"/v1/agent/phone-numbers/{phoneNumberId}/sip-config\"",
                                httpMethod: "PUT",
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
                                operationId: "putAgentPhoneNumbersByPhoneNumberIdSipConfig",
                                methodName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync",
                                pathTemplate: "$\"/v1/agent/phone-numbers/{phoneNumberId}/sip-config\"",
                                httpMethod: "PUT",
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
                                operationId: "putAgentPhoneNumbersByPhoneNumberIdSipConfig",
                                methodName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync",
                                pathTemplate: "$\"/v1/agent/phone-numbers/{phoneNumberId}/sip-config\"",
                                httpMethod: "PUT",
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
                ProcessPutAgentPhoneNumbersByPhoneNumberIdSipConfigResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::FishAudio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::FishAudio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "putAgentPhoneNumbersByPhoneNumberIdSipConfig",
                                methodName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync",
                                pathTemplate: "$\"/v1/agent/phone-numbers/{phoneNumberId}/sip-config\"",
                                httpMethod: "PUT",
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
                                operationId: "putAgentPhoneNumbersByPhoneNumberIdSipConfig",
                                methodName: "PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync",
                                pathTemplate: "$\"/v1/agent/phone-numbers/{phoneNumberId}/sip-config\"",
                                httpMethod: "PUT",
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
                            // No permission -- see authorization schemes
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = __content_401 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse2>.Create(
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
                            // Nothing matches the given URI
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse3? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = __content_404 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse3.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = __content_404 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse3.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 is { Length: > 0 } ? __content_404 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Request conflict
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse4? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = __content_409 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse4.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = __content_409 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse4.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 is { Length: > 0 } ? __content_409 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
                                    responseObject: __value_409,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse5? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse5.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse5.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 is { Length: > 0 } ? __content_422 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Invalid responses from another server/proxy
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse6? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = __content_502 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse6.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = __content_502 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse6.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse6>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 is { Length: > 0 } ? __content_502 : __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseObject: __value_502,
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
                                global::FishAudio.PutAgentPhoneNumbersSipConfigResponse7? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse7.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = __content_503 is not { Length: > 0 } ? null : global::FishAudio.PutAgentPhoneNumbersSipConfigResponse7.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::FishAudio.ApiException<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse7>.Create(
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
                                ProcessPutAgentPhoneNumbersByPhoneNumberIdSipConfigResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::FishAudio.PutAgentPhoneNumbersSipConfigResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::FishAudio.PutAgentPhoneNumbersSipConfigResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::FishAudio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
        /// Update SIP Number Config<br/>
        /// Replace the trunk configuration of an imported `sip` number in place:<br/>
        /// rotate digest credentials, change the allowed source addresses, or add,<br/>
        /// update and remove the termination host and its custom SIP headers. Send<br/>
        /// the complete desired configuration; an empty password beside a set<br/>
        /// username keeps the stored one. Trunk ids are stable across updates, so calls in flight are not<br/>
        /// affected. 409 for numbers that are not `sip` imports or not active.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="inboundAuthUsername"></param>
        /// <param name="inboundAuthPassword"></param>
        /// <param name="inboundAllowedAddresses"></param>
        /// <param name="terminationUri"></param>
        /// <param name="terminationTransport">
        /// Default Value: auto
        /// </param>
        /// <param name="terminationAuthUsername"></param>
        /// <param name="terminationAuthPassword"></param>
        /// <param name="terminationHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::FishAudio.PutAgentPhoneNumbersSipConfigResponse> PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
            string phoneNumberId,
            string? inboundAuthUsername = default,
            string? inboundAuthPassword = default,
            global::System.Collections.Generic.IList<string>? inboundAllowedAddresses = default,
            string? terminationUri = default,
            global::FishAudio.PublicSipNumberConfigPayloadTerminationTransport? terminationTransport = default,
            string? terminationAuthUsername = default,
            string? terminationAuthPassword = default,
            global::System.Collections.Generic.Dictionary<string, string>? terminationHeaders = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::FishAudio.PublicSipNumberConfigPayload
            {
                InboundAuthUsername = inboundAuthUsername,
                InboundAuthPassword = inboundAuthPassword,
                InboundAllowedAddresses = inboundAllowedAddresses,
                TerminationUri = terminationUri,
                TerminationTransport = terminationTransport,
                TerminationAuthUsername = terminationAuthUsername,
                TerminationAuthPassword = terminationAuthPassword,
                TerminationHeaders = terminationHeaders,
            };

            return await PutAgentPhoneNumbersByPhoneNumberIdSipConfigAsync(
                phoneNumberId: phoneNumberId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}