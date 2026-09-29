#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Get Test Run<br/>
        /// Fetch one test run. Runs start `queued` and end `passed`, `failed` or<br/>
        /// `error`. A simulation run takes minutes, so poll until it finishes.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentTestRunsResponse6> GetAgentTestRunsByRunIdAsync(
            string runId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Test Run<br/>
        /// Fetch one test run. Runs start `queued` and end `passed`, `failed` or<br/>
        /// `error`. A simulation run takes minutes, so poll until it finishes.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentTestRunsResponse6>> GetAgentTestRunsByRunIdAsResponseAsync(
            string runId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}