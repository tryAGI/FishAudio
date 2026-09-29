#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Detach Test<br/>
        /// Detach a test from an agent. The test itself stays in your library.<br/>
        /// Detaching a test that is not attached does nothing.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentAgentsByAgentIdTestsByTestIdAsync(
            string agentId,
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach Test<br/>
        /// Detach a test from an agent. The test itself stays in your library.<br/>
        /// Detaching a test that is not attached does nothing.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentAgentsByAgentIdTestsByTestIdAsResponseAsync(
            string agentId,
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}