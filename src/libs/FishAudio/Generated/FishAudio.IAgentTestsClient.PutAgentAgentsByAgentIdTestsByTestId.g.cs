#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Attach Test<br/>
        /// Attach a test to an agent so the agent's test runs include it. Attaching<br/>
        /// an attached test does nothing. The agent and the test must be in the same<br/>
        /// workspace.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAgentAgentsByAgentIdTestsByTestIdAsync(
            string agentId,
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Test<br/>
        /// Attach a test to an agent so the agent's test runs include it. Attaching<br/>
        /// an attached test does nothing. The agent and the test must be in the same<br/>
        /// workspace.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> PutAgentAgentsByAgentIdTestsByTestIdAsResponseAsync(
            string agentId,
            string testId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}