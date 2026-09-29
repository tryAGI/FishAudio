#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Run Tests<br/>
        /// Start a batch that runs the agent's attached tests against its current<br/>
        /// draft, one run per test and repeat. A simulation test repeats<br/>
        /// `simulation.repeat_count` times, and a `repeat_count` in the body repeats<br/>
        /// every selected test that many times instead. A batch starts at most 1000<br/>
        /// runs. Runs are queued and finish in the background, simulations take<br/>
        /// minutes. Poll `GET /v1/agent/agents/{agent_id}/test-batches/{batch_id}`<br/>
        /// until `completed` is true, then gate on `pass_rate`, which leaves out<br/>
        /// `error` runs.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/tests/run \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsTestsRunResponse> CreateAgentAgentsByAgentIdTestsRunAsync(
            string agentId,

            global::FishAudio.CreateAgentAgentsTestsRunRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests<br/>
        /// Start a batch that runs the agent's attached tests against its current<br/>
        /// draft, one run per test and repeat. A simulation test repeats<br/>
        /// `simulation.repeat_count` times, and a `repeat_count` in the body repeats<br/>
        /// every selected test that many times instead. A batch starts at most 1000<br/>
        /// runs. Runs are queued and finish in the background, simulations take<br/>
        /// minutes. Poll `GET /v1/agent/agents/{agent_id}/test-batches/{batch_id}`<br/>
        /// until `completed` is true, then gate on `pass_rate`, which leaves out<br/>
        /// `error` runs.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/tests/run \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentAgentsTestsRunResponse>> CreateAgentAgentsByAgentIdTestsRunAsResponseAsync(
            string agentId,

            global::FishAudio.CreateAgentAgentsTestsRunRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests<br/>
        /// Start a batch that runs the agent's attached tests against its current<br/>
        /// draft, one run per test and repeat. A simulation test repeats<br/>
        /// `simulation.repeat_count` times, and a `repeat_count` in the body repeats<br/>
        /// every selected test that many times instead. A batch starts at most 1000<br/>
        /// runs. Runs are queued and finish in the background, simulations take<br/>
        /// minutes. Poll `GET /v1/agent/agents/{agent_id}/test-batches/{batch_id}`<br/>
        /// until `completed` is true, then gate on `pass_rate`, which leaves out<br/>
        /// `error` runs.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="testIds">
        /// Attached tests to run. Omit to run every test attached to the agent.
        /// </param>
        /// <param name="repeatCount">
        /// Run every selected test this many times in this batch, in place of each test's own repeat count.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsTestsRunResponse> CreateAgentAgentsByAgentIdTestsRunAsync(
            string agentId,
            global::System.Collections.Generic.IList<string>? testIds = default,
            int? repeatCount = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}