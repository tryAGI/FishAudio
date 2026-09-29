
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The agent must have called this library tool, optionally with matching<br/>
    /// arguments, between min_calls and max_calls times (calls that match).
    /// </summary>
    public sealed partial class AgentTestToolCallAssertion
    {
        /// <summary>
        /// Tool the runner should (or should not) observe on the next turn. A<br/>
        /// webhook or client tool is referenced by its library id, an integration<br/>
        /// tool by "&lt;provider_key&gt;:&lt;tool_name&gt;" (for example<br/>
        /// "google_calendar:create_event").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentTestReferencedTool Tool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? Params { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_calls")]
        public int? MinCalls { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_calls")]
        public int? MaxCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolCallAssertion" /> class.
        /// </summary>
        /// <param name="tool">
        /// Tool the runner should (or should not) observe on the next turn. A<br/>
        /// webhook or client tool is referenced by its library id, an integration<br/>
        /// tool by "&lt;provider_key&gt;:&lt;tool_name&gt;" (for example<br/>
        /// "google_calendar:create_event").
        /// </param>
        /// <param name="params"></param>
        /// <param name="minCalls">
        /// Default Value: 1
        /// </param>
        /// <param name="maxCalls">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestToolCallAssertion(
            global::FishAudio.AgentTestReferencedTool tool,
            global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? @params,
            int? minCalls,
            int? maxCalls)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Params = @params;
            this.MinCalls = minCalls;
            this.MaxCalls = maxCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestToolCallAssertion" /> class.
        /// </summary>
        public AgentTestToolCallAssertion()
        {
        }

    }
}