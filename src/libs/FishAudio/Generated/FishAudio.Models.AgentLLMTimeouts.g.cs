
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How long one model gets per reply (manual only), read model.
    /// </summary>
    public sealed partial class AgentLLMTimeouts
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_timeout_ms")]
        public int? TtftTimeoutMs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_timeout_ms")]
        public int? TotalTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMTimeouts" /> class.
        /// </summary>
        /// <param name="ttftTimeoutMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="totalTimeoutMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMTimeouts(
            int? ttftTimeoutMs,
            int? totalTimeoutMs)
        {
            this.TtftTimeoutMs = ttftTimeoutMs;
            this.TotalTimeoutMs = totalTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMTimeouts" /> class.
        /// </summary>
        public AgentLLMTimeouts()
        {
        }

    }
}