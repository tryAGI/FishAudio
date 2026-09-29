
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAgentTestsResponse6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.GetAgentTestsResponseTestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.GetAgentTestsResponseTestType TestType { get; set; }

        /// <summary>
        /// Agents this test is attached to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        public global::System.Collections.Generic.IList<string>? AgentIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? Conversation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectation")]
        public string? Expectation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_examples")]
        public global::System.Collections.Generic.IList<string>? SuccessExamples { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_examples")]
        public global::System.Collections.Generic.IList<string>? FailureExamples { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_tool")]
        public global::FishAudio.AgentTestReferencedTool? ReferencedTool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_parameters")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? ToolParameters { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_absence")]
        public bool? VerifyAbsence { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation")]
        public global::FishAudio.AgentTestSimulationConfig? Simulation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTestsResponse6" /> class.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="testType"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="agentIds">
        /// Agents this test is attached to.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentTestsResponse6(
            string testId,
            string workspaceId,
            string name,
            global::FishAudio.GetAgentTestsResponseTestType testType,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? conversation,
            string? expectation,
            global::System.Collections.Generic.IList<string>? successExamples,
            global::System.Collections.Generic.IList<string>? failureExamples,
            global::FishAudio.AgentTestReferencedTool? referencedTool,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? toolParameters,
            bool? verifyAbsence,
            global::FishAudio.AgentTestSimulationConfig? simulation,
            object? dynamicVariables)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TestType = testType;
            this.AgentIds = agentIds;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Conversation = conversation;
            this.Expectation = expectation;
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
            this.ReferencedTool = referencedTool;
            this.ToolParameters = toolParameters;
            this.VerifyAbsence = verifyAbsence;
            this.Simulation = simulation;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTestsResponse6" /> class.
        /// </summary>
        public GetAgentTestsResponse6()
        {
        }

    }
}