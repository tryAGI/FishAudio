
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestUpdatePayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        public global::FishAudio.PublicAgentTestUpdatePayloadTestType? TestType { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Conversation { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectation")]
        public string? Expectation { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_examples")]
        public global::System.Collections.Generic.IList<string>? SuccessExamples { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_examples")]
        public global::System.Collections.Generic.IList<string>? FailureExamples { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_tool")]
        public global::FishAudio.AgentTestReferencedTool? ReferencedTool { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_parameters")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? ToolParameters { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_absence")]
        public bool? VerifyAbsence { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation")]
        public global::FishAudio.AgentTestSimulationConfig? Simulation { get; set; }

        /// <summary>
        /// The channel a `next_reply` or `tool` test plays. `null` puts it back on `web_voice`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public global::FishAudio.PublicAgentTestUpdatePayloadChannel? Channel { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// The judge of a `next_reply` or `simulation` test. Null follows the workspace's Tests settings (`GET /v1/agent/test-settings`). A `tool` test has no judge, it is null there. Left out, the test keeps its judge.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        public global::FishAudio.AgentTestJudge? Judge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestUpdatePayload" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestUpdatePayload(
            string? name,
            global::FishAudio.PublicAgentTestUpdatePayloadTestType? testType,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? conversation,
            string? expectation,
            global::System.Collections.Generic.IList<string>? successExamples,
            global::System.Collections.Generic.IList<string>? failureExamples,
            global::FishAudio.AgentTestReferencedTool? referencedTool,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? toolParameters,
            bool? verifyAbsence,
            global::FishAudio.AgentTestSimulationConfig? simulation,
            global::FishAudio.PublicAgentTestUpdatePayloadChannel? channel,
            object? dynamicVariables,
            global::FishAudio.AgentTestJudge? judge)
        {
            this.Name = name;
            this.TestType = testType;
            this.Conversation = conversation;
            this.Expectation = expectation;
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
            this.ReferencedTool = referencedTool;
            this.ToolParameters = toolParameters;
            this.VerifyAbsence = verifyAbsence;
            this.Simulation = simulation;
            this.Channel = channel;
            this.DynamicVariables = dynamicVariables;
            this.Judge = judge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestUpdatePayload" /> class.
        /// </summary>
        public PublicAgentTestUpdatePayload()
        {
        }

    }
}