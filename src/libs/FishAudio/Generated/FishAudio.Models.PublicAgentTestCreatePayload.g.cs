
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestCreatePayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: next_reply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestCreatePayloadTestTypeJsonConverter))]
        public global::FishAudio.PublicAgentTestCreatePayloadTestType? TestType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Conversation { get; set; }

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
        /// Agents to attach the test to. They must all be in one workspace, and the test is created there. Without agents the test goes into the API key owner's default workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        public global::System.Collections.Generic.IList<string>? AgentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestCreatePayload" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestCreatePayload(
            string name,
            global::FishAudio.PublicAgentTestCreatePayloadTestType? testType,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? conversation,
            string? expectation,
            global::System.Collections.Generic.IList<string>? successExamples,
            global::System.Collections.Generic.IList<string>? failureExamples,
            global::FishAudio.AgentTestReferencedTool? referencedTool,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? toolParameters,
            bool? verifyAbsence,
            global::FishAudio.AgentTestSimulationConfig? simulation,
            object? dynamicVariables,
            global::System.Collections.Generic.IList<string>? agentIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TestType = testType;
            this.Conversation = conversation;
            this.Expectation = expectation;
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
            this.ReferencedTool = referencedTool;
            this.ToolParameters = toolParameters;
            this.VerifyAbsence = verifyAbsence;
            this.Simulation = simulation;
            this.DynamicVariables = dynamicVariables;
            this.AgentIds = agentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestCreatePayload" /> class.
        /// </summary>
        public PublicAgentTestCreatePayload()
        {
        }

    }
}