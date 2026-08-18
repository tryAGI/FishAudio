#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// List Agents Using Knowledge Source<br/>
        /// Every agent that references this source in its draft or currently<br/>
        /// published configuration: the pre-flight check before a delete.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse> GetAgentKnowledgeSourcesBySourceIdAgentsAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agents Using Knowledge Source<br/>
        /// Every agent that references this source in its draft or currently<br/>
        /// published configuration: the pre-flight check before a delete.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse>> GetAgentKnowledgeSourcesBySourceIdAgentsAsResponseAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}