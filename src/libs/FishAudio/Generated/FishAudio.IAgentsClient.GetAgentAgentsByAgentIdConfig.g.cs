#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Draft Config<br/>
        /// Read the agent's current draft configuration, the state the next publish<br/>
        /// will freeze. Sessions run the latest published version, not the draft; use<br/>
        /// the versions endpoints to see what is live. Webhook signing secrets are<br/>
        /// write-only and reported as `has_secret`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsConfigResponse> GetAgentAgentsByAgentIdConfigAsync(
            string agentId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Draft Config<br/>
        /// Read the agent's current draft configuration, the state the next publish<br/>
        /// will freeze. Sessions run the latest published version, not the draft; use<br/>
        /// the versions endpoints to see what is live. Webhook signing secrets are<br/>
        /// write-only and reported as `has_secret`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsConfigResponse>> GetAgentAgentsByAgentIdConfigAsResponseAsync(
            string agentId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}