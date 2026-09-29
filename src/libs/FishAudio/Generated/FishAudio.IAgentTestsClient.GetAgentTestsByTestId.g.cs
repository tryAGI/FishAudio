#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Get Test<br/>
        /// Fetch one test's full definition. The body is also the export format: post<br/>
        /// it to `POST /v1/agent/tests` to create a copy.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentTestsResponse6> GetAgentTestsByTestIdAsync(
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Test<br/>
        /// Fetch one test's full definition. The body is also the export format: post<br/>
        /// it to `POST /v1/agent/tests` to create a copy.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentTestsResponse6>> GetAgentTestsByTestIdAsResponseAsync(
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}