#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Get Test Batch<br/>
        /// The runs of one batch with their pass, fail and error counts. `status` is<br/>
        /// `running` until every run has finished, then `completed`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/test-batches/&lt;batch-id&gt; \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsTestBatchesResponse6> GetAgentAgentsByAgentIdTestBatchesByBatchIdAsync(
            string agentId,
            string batchId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Test Batch<br/>
        /// The runs of one batch with their pass, fail and error counts. `status` is<br/>
        /// `running` until every run has finished, then `completed`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/test-batches/&lt;batch-id&gt; \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsTestBatchesResponse6>> GetAgentAgentsByAgentIdTestBatchesByBatchIdAsResponseAsync(
            string agentId,
            string batchId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}