#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Agent<br/>
        /// Update agent-level fields (name, description, status, public access and<br/>
        /// session-override policy). Omitted fields keep their value. Conversation<br/>
        /// behavior (voice, prompt, recording and the rest) is draft configuration:<br/>
        /// use `PATCH /v1/agent/agents/{agent_id}/config`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentAgentsResponse> EditAgentAgentsByAgentIdAsync(
            string agentId,

            global::FishAudio.PublicAgentUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update agent-level fields (name, description, status, public access and<br/>
        /// session-override policy). Omitted fields keep their value. Conversation<br/>
        /// behavior (voice, prompt, recording and the rest) is draft configuration:<br/>
        /// use `PATCH /v1/agent/agents/{agent_id}/config`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentAgentsResponse>> EditAgentAgentsByAgentIdAsResponseAsync(
            string agentId,

            global::FishAudio.PublicAgentUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update agent-level fields (name, description, status, public access and<br/>
        /// session-override policy). Omitted fields keep their value. Conversation<br/>
        /// behavior (voice, prompt, recording and the rest) is draft configuration:<br/>
        /// use `PATCH /v1/agent/agents/{agent_id}/config`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="publicEnabled">
        /// Allow keyless session creation from the browser SDK, gated by allowed_origins.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowedOrigins">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="overridesAllowed">
        /// Which session-creation overrides callers may use. An empty list rejects all overrides.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentAgentsResponse> EditAgentAgentsByAgentIdAsync(
            string agentId,
            string? name = default,
            string? description = default,
            global::FishAudio.PublicAgentUpdatePayloadStatus2? status = default,
            bool? publicEnabled = default,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? overridesAllowed = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}