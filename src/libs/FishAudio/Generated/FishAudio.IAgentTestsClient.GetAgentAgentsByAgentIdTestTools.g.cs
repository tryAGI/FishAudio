#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// List Test Tools<br/>
        /// The tools a test can reference for this agent, exactly what a<br/>
        /// conversation on its draft offers. Use these ids in a test's tool mocks,<br/>
        /// assertions and `referenced_tool`, including integration tools such as<br/>
        /// `google_calendar:create_event`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsTestToolsResponse> GetAgentAgentsByAgentIdTestToolsAsync(
            string agentId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Test Tools<br/>
        /// The tools a test can reference for this agent, exactly what a<br/>
        /// conversation on its draft offers. Use these ids in a test's tool mocks,<br/>
        /// assertions and `referenced_tool`, including integration tools such as<br/>
        /// `google_calendar:create_event`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsTestToolsResponse>> GetAgentAgentsByAgentIdTestToolsAsResponseAsync(
            string agentId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}