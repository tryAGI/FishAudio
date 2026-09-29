
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Calls of one tool the test prepared no answer for. A run with a<br/>
    /// gap never passes cleanly: it fails with needs_review.
    /// </summary>
    public sealed partial class AgentTestMockGap
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        public string? ToolId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        public global::FishAudio.AgentTestMockGapToolType? ToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTestMockGapSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentTestMockGapSource Source { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public int? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestMockGap" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="source"></param>
        /// <param name="toolId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="calls">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestMockGap(
            string toolName,
            global::FishAudio.AgentTestMockGapSource source,
            string? toolId,
            global::FishAudio.AgentTestMockGapToolType? toolType,
            int? calls)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolId = toolId;
            this.ToolType = toolType;
            this.Source = source;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestMockGap" /> class.
        /// </summary>
        public AgentTestMockGap()
        {
        }

    }
}