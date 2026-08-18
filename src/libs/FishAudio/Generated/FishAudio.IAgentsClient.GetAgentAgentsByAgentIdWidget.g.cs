#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Widget Config<br/>
        /// Unauthenticated display configuration for the embeddable `&lt;fish-agent&gt;`<br/>
        /// widget. Only agents published as public are reachable, and the request<br/>
        /// `Origin` must match the agent's allowed origins, the same gate as<br/>
        /// anonymous session creation. Attributes set on the embed tag override<br/>
        /// every field returned here.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="origin">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsWidgetResponse> GetAgentAgentsByAgentIdWidgetAsync(
            string agentId,
            string? origin = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Widget Config<br/>
        /// Unauthenticated display configuration for the embeddable `&lt;fish-agent&gt;`<br/>
        /// widget. Only agents published as public are reachable, and the request<br/>
        /// `Origin` must match the agent's allowed origins, the same gate as<br/>
        /// anonymous session creation. Attributes set on the embed tag override<br/>
        /// every field returned here.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="origin">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsWidgetResponse>> GetAgentAgentsByAgentIdWidgetAsResponseAsync(
            string agentId,
            string? origin = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}