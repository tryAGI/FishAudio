#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// Get Knowledge Source<br/>
        /// Fetch one knowledge source including its full text content and current<br/>
        /// revision number.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentKnowledgeSourcesResponse4> GetAgentKnowledgeSourcesBySourceIdAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Knowledge Source<br/>
        /// Fetch one knowledge source including its full text content and current<br/>
        /// revision number.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentKnowledgeSourcesResponse4>> GetAgentKnowledgeSourcesBySourceIdAsResponseAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}