
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTestSimulationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scenario { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition> SuccessConditions { get; set; }

        /// <summary>
        /// Deterministic checks run before the judge, no LLM involved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assertions")]
        public global::FishAudio.AgentTestSimulationAssertions? Assertions { get; set; }

        /// <summary>
        /// all: every tool answers from a mock, except real_tools, which run for<br/>
        /// real. selected: only the listed tools do, the rest follow fallback.<br/>
        /// none: every tool hits its real endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mocks")]
        public global::FishAudio.AgentTestToolMocks? ToolMocks { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulated_user_model")]
        public string? SimulatedUserModel { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public global::FishAudio.AgentTestSimulationConfigChannel? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationConfig" /> class.
        /// </summary>
        /// <param name="scenario"></param>
        /// <param name="successConditions"></param>
        /// <param name="maxTurns">
        /// Default Value: 10
        /// </param>
        /// <param name="assertions">
        /// Deterministic checks run before the judge, no LLM involved.
        /// </param>
        /// <param name="toolMocks">
        /// all: every tool answers from a mock, except real_tools, which run for<br/>
        /// real. selected: only the listed tools do, the rest follow fallback.<br/>
        /// none: every tool hits its real endpoint.
        /// </param>
        /// <param name="simulatedUserModel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="repeatCount">
        /// Default Value: 1
        /// </param>
        /// <param name="channel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSimulationConfig(
            string scenario,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition> successConditions,
            int? maxTurns,
            global::FishAudio.AgentTestSimulationAssertions? assertions,
            global::FishAudio.AgentTestToolMocks? toolMocks,
            string? simulatedUserModel,
            int? repeatCount,
            global::FishAudio.AgentTestSimulationConfigChannel? channel)
        {
            this.Scenario = scenario ?? throw new global::System.ArgumentNullException(nameof(scenario));
            this.MaxTurns = maxTurns;
            this.SuccessConditions = successConditions ?? throw new global::System.ArgumentNullException(nameof(successConditions));
            this.Assertions = assertions;
            this.ToolMocks = toolMocks;
            this.SimulatedUserModel = simulatedUserModel;
            this.RepeatCount = repeatCount;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationConfig" /> class.
        /// </summary>
        public AgentTestSimulationConfig()
        {
        }

    }
}