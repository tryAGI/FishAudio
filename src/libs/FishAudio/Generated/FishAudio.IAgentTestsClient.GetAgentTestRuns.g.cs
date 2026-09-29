#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// List Test Runs<br/>
        /// Your team's test runs, newest first, filtered by agent, test, batch,<br/>
        /// status or test type. Items leave out the conversation and the judge's<br/>
        /// output. Fetch one run with `GET /v1/agent/test-runs/{run_id}` for those.<br/>
        /// Paginate with `cursor` (follow `next_cursor` while `has_more` is true) or<br/>
        /// with `page` for offset pagination with a `total` count. The two are<br/>
        /// mutually exclusive.
        /// </summary>
        /// <param name="agentId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="testId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="batchId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="testType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
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
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentTestRunsResponse> GetAgentTestRunsAsync(
            string? agentId = default,
            string? testId = default,
            string? batchId = default,
            global::FishAudio.GetAgentTestRunsStatus? status = default,
            global::FishAudio.GetAgentTestRunsTestType? testType = default,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Test Runs<br/>
        /// Your team's test runs, newest first, filtered by agent, test, batch,<br/>
        /// status or test type. Items leave out the conversation and the judge's<br/>
        /// output. Fetch one run with `GET /v1/agent/test-runs/{run_id}` for those.<br/>
        /// Paginate with `cursor` (follow `next_cursor` while `has_more` is true) or<br/>
        /// with `page` for offset pagination with a `total` count. The two are<br/>
        /// mutually exclusive.
        /// </summary>
        /// <param name="agentId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="testId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="batchId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="testType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
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
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentTestRunsResponse>> GetAgentTestRunsAsResponseAsync(
            string? agentId = default,
            string? testId = default,
            string? batchId = default,
            global::FishAudio.GetAgentTestRunsStatus? status = default,
            global::FishAudio.GetAgentTestRunsTestType? testType = default,
            string? cursor = default,
            int? page = default,
            bool? includeTotal = default,
            int? pageSize = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}