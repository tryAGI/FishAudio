#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Delete Tool<br/>
        /// Delete a tool. Returns 409 while any agent's draft configuration still<br/>
        /// references it. Check `GET /v1/agent/tools/{tool_id}/agents` and detach it<br/>
        /// via the agent config first, so a delete can never silently change agent<br/>
        /// behavior.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentToolsByToolIdAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tool<br/>
        /// Delete a tool. Returns 409 while any agent's draft configuration still<br/>
        /// references it. Check `GET /v1/agent/tools/{tool_id}/agents` and detach it<br/>
        /// via the agent config first, so a delete can never silently change agent<br/>
        /// behavior.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentToolsByToolIdAsResponseAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}