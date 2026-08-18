#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// List Agents Using Tool<br/>
        /// Every agent whose draft configuration references this tool: the<br/>
        /// pre-flight check before a delete. Published versions keep executing their<br/>
        /// frozen tool snapshot, so only draft references block deletion.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentToolsAgentsResponse> GetAgentToolsByToolIdAgentsAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agents Using Tool<br/>
        /// Every agent whose draft configuration references this tool: the<br/>
        /// pre-flight check before a delete. Published versions keep executing their<br/>
        /// frozen tool snapshot, so only draft references block deletion.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentToolsAgentsResponse>> GetAgentToolsByToolIdAgentsAsResponseAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}