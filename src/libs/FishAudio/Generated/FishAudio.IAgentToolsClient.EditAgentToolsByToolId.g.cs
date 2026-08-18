#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Update Tool<br/>
        /// Patch tool fields; omitted fields keep their value (null is rejected;<br/>
        /// send an empty string to clear a text field). `headers` replaces the header<br/>
        /// list wholesale. Include credential values again whenever you send it,<br/>
        /// since reads never return them. Attached agents' drafts pick up the change<br/>
        /// immediately; published versions stay frozen until re-published.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentToolsResponse> EditAgentToolsByToolIdAsync(
            string toolId,

            global::FishAudio.PublicAgentToolUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool<br/>
        /// Patch tool fields; omitted fields keep their value (null is rejected;<br/>
        /// send an empty string to clear a text field). `headers` replaces the header<br/>
        /// list wholesale. Include credential values again whenever you send it,<br/>
        /// since reads never return them. Attached agents' drafts pick up the change<br/>
        /// immediately; published versions stay frozen until re-published.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentToolsResponse>> EditAgentToolsByToolIdAsResponseAsync(
            string toolId,

            global::FishAudio.PublicAgentToolUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool<br/>
        /// Patch tool fields; omitted fields keep their value (null is rejected;<br/>
        /// send an empty string to clear a text field). `headers` replaces the header<br/>
        /// list wholesale. Include credential values again whenever you send it,<br/>
        /// since reads never return them. Attached agents' drafts pick up the change<br/>
        /// immediately; published versions stay frozen until re-published.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="arguments">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="method">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="url">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bodyTemplate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="headers">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="timeoutSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="errorHandling">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mockResponses">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectsResponse">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="executionMode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentToolsResponse> EditAgentToolsByToolIdAsync(
            string toolId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? arguments = default,
            global::FishAudio.PublicAgentToolUpdatePayloadMethod2? method = default,
            string? url = default,
            string? contentType = default,
            string? bodyTemplate = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? headers = default,
            int? timeoutSeconds = default,
            global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2? errorHandling = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? mockResponses = default,
            bool? expectsResponse = default,
            global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2? executionMode = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}