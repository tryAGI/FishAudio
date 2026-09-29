#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Create Test<br/>
        /// Create a test: `next_reply` judges the agent's next reply against an<br/>
        /// expectation, `tool` checks the tool the agent calls next, and `simulation`<br/>
        /// lets a simulated user hold a whole conversation that is scored against<br/>
        /// success conditions. Pass `agent_ids` to attach the test right away.<br/>
        /// The body of `GET /v1/agent/tests/{test_id}` posts back as is, so tests can<br/>
        /// be exported and imported. Tool references use your workspace's tool ids<br/>
        /// (list them with `GET /v1/agent/agents/{agent_id}/test-tools`), so an export<br/>
        /// imports cleanly within the same team and needs its tool ids remapped<br/>
        /// elsewhere.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/tests \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Reschedules an appointment",<br/>
        ///     "test_type": "simulation",<br/>
        ///     "agent_ids": ["&lt;agent-id&gt;"],<br/>
        ///     "simulation": {<br/>
        ///       "scenario": "You are Jane. Move your Tuesday cleaning to Thursday afternoon.",<br/>
        ///       "max_turns": 10,<br/>
        ///       "success_conditions": [<br/>
        ///         {"name": "rescheduled", "description": "The agent confirms the new Thursday slot."}<br/>
        ///       ],<br/>
        ///       "tool_mocks": {<br/>
        ///         "strategy": "all",<br/>
        ///         "tools": [<br/>
        ///           {<br/>
        ///             "tool": {"id": "&lt;tool-id&gt;", "name": "Book appointment", "type": "webhook"},<br/>
        ///             "result": {"status": "confirmed"}<br/>
        ///           }<br/>
        ///         ]<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentTestsResponse> CreateAgentTestsAsync(

            global::FishAudio.PublicAgentTestCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Test<br/>
        /// Create a test: `next_reply` judges the agent's next reply against an<br/>
        /// expectation, `tool` checks the tool the agent calls next, and `simulation`<br/>
        /// lets a simulated user hold a whole conversation that is scored against<br/>
        /// success conditions. Pass `agent_ids` to attach the test right away.<br/>
        /// The body of `GET /v1/agent/tests/{test_id}` posts back as is, so tests can<br/>
        /// be exported and imported. Tool references use your workspace's tool ids<br/>
        /// (list them with `GET /v1/agent/agents/{agent_id}/test-tools`), so an export<br/>
        /// imports cleanly within the same team and needs its tool ids remapped<br/>
        /// elsewhere.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/tests \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Reschedules an appointment",<br/>
        ///     "test_type": "simulation",<br/>
        ///     "agent_ids": ["&lt;agent-id&gt;"],<br/>
        ///     "simulation": {<br/>
        ///       "scenario": "You are Jane. Move your Tuesday cleaning to Thursday afternoon.",<br/>
        ///       "max_turns": 10,<br/>
        ///       "success_conditions": [<br/>
        ///         {"name": "rescheduled", "description": "The agent confirms the new Thursday slot."}<br/>
        ///       ],<br/>
        ///       "tool_mocks": {<br/>
        ///         "strategy": "all",<br/>
        ///         "tools": [<br/>
        ///           {<br/>
        ///             "tool": {"id": "&lt;tool-id&gt;", "name": "Book appointment", "type": "webhook"},<br/>
        ///             "result": {"status": "confirmed"}<br/>
        ///           }<br/>
        ///         ]<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentTestsResponse>> CreateAgentTestsAsResponseAsync(

            global::FishAudio.PublicAgentTestCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Test<br/>
        /// Create a test: `next_reply` judges the agent's next reply against an<br/>
        /// expectation, `tool` checks the tool the agent calls next, and `simulation`<br/>
        /// lets a simulated user hold a whole conversation that is scored against<br/>
        /// success conditions. Pass `agent_ids` to attach the test right away.<br/>
        /// The body of `GET /v1/agent/tests/{test_id}` posts back as is, so tests can<br/>
        /// be exported and imported. Tool references use your workspace's tool ids<br/>
        /// (list them with `GET /v1/agent/agents/{agent_id}/test-tools`), so an export<br/>
        /// imports cleanly within the same team and needs its tool ids remapped<br/>
        /// elsewhere.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="testType">
        /// Default Value: next_reply
        /// </param>
        /// <param name="conversation"></param>
        /// <param name="expectation"></param>
        /// <param name="successExamples"></param>
        /// <param name="failureExamples"></param>
        /// <param name="referencedTool">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolParameters"></param>
        /// <param name="verifyAbsence">
        /// Default Value: false
        /// </param>
        /// <param name="simulation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dynamicVariables"></param>
        /// <param name="agentIds">
        /// Agents to attach the test to. They must all be in one workspace, and the test is created there. Without agents the test goes into the API key owner's default workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentTestsResponse> CreateAgentTestsAsync(
            string name,
            global::FishAudio.PublicAgentTestCreatePayloadTestType? testType = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? conversation = default,
            string? expectation = default,
            global::System.Collections.Generic.IList<string>? successExamples = default,
            global::System.Collections.Generic.IList<string>? failureExamples = default,
            global::FishAudio.AgentTestReferencedTool? referencedTool = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? toolParameters = default,
            bool? verifyAbsence = default,
            global::FishAudio.AgentTestSimulationConfig? simulation = default,
            object? dynamicVariables = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}