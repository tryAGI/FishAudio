#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Update Test<br/>
        /// Patch test fields. Omitted fields keep their value and null is rejected,<br/>
        /// except `referenced_tool: null`, which turns a `tool` test into a check that<br/>
        /// the agent calls no tool at all. Attach and detach agents with<br/>
        /// `PUT` and `DELETE /v1/agent/agents/{agent_id}/tests/{test_id}`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentTestsResponse> EditAgentTestsByTestIdAsync(
            string testId,

            global::FishAudio.PublicAgentTestUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test<br/>
        /// Patch test fields. Omitted fields keep their value and null is rejected,<br/>
        /// except `referenced_tool: null`, which turns a `tool` test into a check that<br/>
        /// the agent calls no tool at all. Attach and detach agents with<br/>
        /// `PUT` and `DELETE /v1/agent/agents/{agent_id}/tests/{test_id}`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentTestsResponse>> EditAgentTestsByTestIdAsResponseAsync(
            string testId,

            global::FishAudio.PublicAgentTestUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test<br/>
        /// Patch test fields. Omitted fields keep their value and null is rejected,<br/>
        /// except `referenced_tool: null`, which turns a `tool` test into a check that<br/>
        /// the agent calls no tool at all. Attach and detach agents with<br/>
        /// `PUT` and `DELETE /v1/agent/agents/{agent_id}/tests/{test_id}`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="testType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="conversation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="successExamples">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="failureExamples">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="referencedTool">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolParameters">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="verifyAbsence">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="simulation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="channel">
        /// The channel a `next_reply` or `tool` test plays. `null` puts it back on `web_voice`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dynamicVariables">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="judge">
        /// The judge of a `next_reply` or `simulation` test. Null follows the workspace's Tests settings (`GET /v1/agent/test-settings`). A `tool` test has no judge, it is null there. Left out, the test keeps its judge.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentTestsResponse> EditAgentTestsByTestIdAsync(
            string testId,
            string? name = default,
            global::FishAudio.PublicAgentTestUpdatePayloadTestType? testType = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? conversation = default,
            string? expectation = default,
            global::System.Collections.Generic.IList<string>? successExamples = default,
            global::System.Collections.Generic.IList<string>? failureExamples = default,
            global::FishAudio.AgentTestReferencedTool? referencedTool = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? toolParameters = default,
            bool? verifyAbsence = default,
            global::FishAudio.AgentTestSimulationConfig? simulation = default,
            global::FishAudio.PublicAgentTestUpdatePayloadChannel? channel = default,
            object? dynamicVariables = default,
            global::FishAudio.AgentTestJudge? judge = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}