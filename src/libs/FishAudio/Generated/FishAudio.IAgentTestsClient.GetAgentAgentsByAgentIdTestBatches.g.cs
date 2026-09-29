#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// List Test Batches<br/>
        /// The agent's test batches, newest first, with their pass, fail and error<br/>
        /// counts. Paginate with `cursor`, following `next_cursor` while `has_more` is<br/>
        /// true.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsTestBatchesResponse> GetAgentAgentsByAgentIdTestBatchesAsync(
            string agentId,
            string? cursor = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Test Batches<br/>
        /// The agent's test batches, newest first, with their pass, fail and error<br/>
        /// counts. Paginate with `cursor`, following `next_cursor` while `has_more` is<br/>
        /// true.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsTestBatchesResponse>> GetAgentAgentsByAgentIdTestBatchesAsResponseAsync(
            string agentId,
            string? cursor = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}