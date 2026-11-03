
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The agent's own model's timeouts, write model. Unset ttft_timeout_ms =<br/>
    /// 5000 ms (5 seconds); unset total_timeout_ms = no limit. The two are compared<br/>
    /// only when both are set.
    /// </summary>
    public sealed partial class AgentLLMTimeoutsPayload
    {
        /// <summary>
        /// Milliseconds the model gets to start its reply (first text or tool call). Past it, the reply moves to the next fallback model. Not set: defaults to 5000 ms (5 seconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_timeout_ms")]
        public int? TtftTimeoutMs { get; set; }

        /// <summary>
        /// Milliseconds the model gets to finish its reply. Past it, a reply nothing of which was spoken yet moves to the next fallback model; one already being spoken fails like any failed reply. At least `ttft_timeout_ms` when both are set. Not set: no limit.<br/>
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
        /// Initializes a new instance of the <see cref="AgentLLMTimeoutsPayload" /> class.
        /// </summary>
        /// <param name="ttftTimeoutMs">
        /// Milliseconds the model gets to start its reply (first text or tool call). Past it, the reply moves to the next fallback model. Not set: defaults to 5000 ms (5 seconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="totalTimeoutMs">
        /// Milliseconds the model gets to finish its reply. Past it, a reply nothing of which was spoken yet moves to the next fallback model; one already being spoken fails like any failed reply. At least `ttft_timeout_ms` when both are set. Not set: no limit.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMTimeoutsPayload(
            int? ttftTimeoutMs,
            int? totalTimeoutMs)
        {
            this.TtftTimeoutMs = ttftTimeoutMs;
            this.TotalTimeoutMs = totalTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMTimeoutsPayload" /> class.
        /// </summary>
        public AgentLLMTimeoutsPayload()
        {
        }

    }
}