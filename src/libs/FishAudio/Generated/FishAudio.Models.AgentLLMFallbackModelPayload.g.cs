
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One fallback, write model: `model` or `custom`, under the same rules as<br/>
    /// llm.model / llm.custom.
    /// </summary>
    public sealed partial class AgentLLMFallbackModelPayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::FishAudio.AgentLLMFallbackModelPayloadModel? Model { get; set; }

        /// <summary>
        /// A customer endpoint, with the same rules as `llm.custom`. Omit `api_key` to keep the stored key of the fallback with the same `base_url` and `model`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::FishAudio.AgentLLMCustomPayload? Custom { get; set; }

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
        /// First entry only: request this model together with the agent's own model. Both requests bill their tokens.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel")]
        public global::FishAudio.AgentLLMParallelPayload? Parallel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackModelPayload" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// A customer endpoint, with the same rules as `llm.custom`. Omit `api_key` to keep the stored key of the fallback with the same `base_url` and `model`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ttftTimeoutMs">
        /// Milliseconds the model gets to start its reply (first text or tool call). Past it, the reply moves to the next fallback model. Not set: defaults to 5000 ms (5 seconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="totalTimeoutMs">
        /// Milliseconds the model gets to finish its reply. Past it, a reply nothing of which was spoken yet moves to the next fallback model; one already being spoken fails like any failed reply. At least `ttft_timeout_ms` when both are set. Not set: no limit.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parallel">
        /// First entry only: request this model together with the agent's own model. Both requests bill their tokens.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMFallbackModelPayload(
            global::FishAudio.AgentLLMFallbackModelPayloadModel? model,
            global::FishAudio.AgentLLMCustomPayload? custom,
            int? ttftTimeoutMs,
            int? totalTimeoutMs,
            global::FishAudio.AgentLLMParallelPayload? parallel)
        {
            this.Model = model;
            this.Custom = custom;
            this.TtftTimeoutMs = ttftTimeoutMs;
            this.TotalTimeoutMs = totalTimeoutMs;
            this.Parallel = parallel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackModelPayload" /> class.
        /// </summary>
        public AgentLLMFallbackModelPayload()
        {
        }

    }
}