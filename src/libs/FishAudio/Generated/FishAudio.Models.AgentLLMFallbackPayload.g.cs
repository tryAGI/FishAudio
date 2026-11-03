
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Replaces the whole fallback: `mode` and `models` travel together.
    /// </summary>
    public sealed partial class AgentLLMFallbackPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentLLMFallbackPayloadModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentLLMFallbackPayloadMode Mode { get; set; }

        /// <summary>
        /// Fallback models in order, 1 to 3. Only with mode `manual`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelPayload>? Models { get; set; }

        /// <summary>
        /// The agent's own model's timeouts. Only with mode `manual`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::FishAudio.AgentLLMTimeoutsPayload? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackPayload" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="models">
        /// Fallback models in order, 1 to 3. Only with mode `manual`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="primary">
        /// The agent's own model's timeouts. Only with mode `manual`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMFallbackPayload(
            global::FishAudio.AgentLLMFallbackPayloadMode mode,
            global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelPayload>? models,
            global::FishAudio.AgentLLMTimeoutsPayload? primary)
        {
            this.Mode = mode;
            this.Models = models;
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackPayload" /> class.
        /// </summary>
        public AgentLLMFallbackPayload()
        {
        }

    }
}