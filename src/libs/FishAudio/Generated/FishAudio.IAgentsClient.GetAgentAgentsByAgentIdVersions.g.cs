#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agent Versions<br/>
        /// The publish history, newest first. The highest version_number is what live<br/>
        /// sessions run. Compare a version's config_hash with the draft's to detect<br/>
        /// unpublished changes.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeTotal">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsVersionsResponse> GetAgentAgentsByAgentIdVersionsAsync(
            string agentId,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Versions<br/>
        /// The publish history, newest first. The highest version_number is what live<br/>
        /// sessions run. Compare a version's config_hash with the draft's to detect<br/>
        /// unpublished changes.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeTotal">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsVersionsResponse>> GetAgentAgentsByAgentIdVersionsAsResponseAsync(
            string agentId,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}