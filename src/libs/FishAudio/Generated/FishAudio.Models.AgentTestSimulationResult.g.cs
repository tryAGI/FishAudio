
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The simulation run's result: what was said, what the agent called,<br/>
    /// the deterministic assertions and the judge's per-condition verdicts.
    /// </summary>
    public sealed partial class AgentTestSimulationResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? Transcript { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assertions")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? Assertions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationResult" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="toolCalls"></param>
        /// <param name="assertions"></param>
        /// <param name="conditions"></param>
        /// <param name="summary"></param>
        /// <param name="passed">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSimulationResult(
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? transcript,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? toolCalls,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? assertions,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? conditions,
            string? summary,
            bool? passed)
        {
            this.Transcript = transcript;
            this.ToolCalls = toolCalls;
            this.Assertions = assertions;
            this.Conditions = conditions;
            this.Summary = summary;
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationResult" /> class.
        /// </summary>
        public AgentTestSimulationResult()
        {
        }

    }
}