#nullable enable

namespace FishAudio
{
    public partial interface IKnowledgeSourcesClient
    {
        /// <summary>
        /// Delete Knowledge Source<br/>
        /// Delete a knowledge source. Returns 409 while any agent still references it<br/>
        /// — in its draft or in its currently published version (sessions resolve<br/>
        /// sources at call time, so deleting a published reference would change a<br/>
        /// running agent). Check `GET /v1/agent/knowledge-sources/{source_id}/agents`,<br/>
        /// detach via the agent config, and republish if needed before deleting.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentKnowledgeSourcesBySourceIdAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Knowledge Source<br/>
        /// Delete a knowledge source. Returns 409 while any agent still references it<br/>
        /// — in its draft or in its currently published version (sessions resolve<br/>
        /// sources at call time, so deleting a published reference would change a<br/>
        /// running agent). Check `GET /v1/agent/knowledge-sources/{source_id}/agents`,<br/>
        /// detach via the agent config, and republish if needed before deleting.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentKnowledgeSourcesBySourceIdAsResponseAsync(
            string sourceId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}