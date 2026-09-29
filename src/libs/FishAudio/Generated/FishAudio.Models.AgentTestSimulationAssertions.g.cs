
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Deterministic checks run before the judge, no LLM involved.
    /// </summary>
    public sealed partial class AgentTestSimulationAssertions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forbidden_tools")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? ForbiddenTools { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_by")]
        public global::FishAudio.AgentTestSimulationAssertionsEndedBy? EndedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationAssertions" /> class.
        /// </summary>
        /// <param name="toolCalls"></param>
        /// <param name="forbiddenTools"></param>
        /// <param name="endedBy">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSimulationAssertions(
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? toolCalls,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? forbiddenTools,
            global::FishAudio.AgentTestSimulationAssertionsEndedBy? endedBy)
        {
            this.ToolCalls = toolCalls;
            this.ForbiddenTools = forbiddenTools;
            this.EndedBy = endedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationAssertions" /> class.
        /// </summary>
        public AgentTestSimulationAssertions()
        {
        }

    }
}