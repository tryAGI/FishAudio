
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentLLMConfigRedacted
    {
        /// <summary>
        /// Default Value: openai/gpt-6.1-terra-fast
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentLLMConfigRedactedModelJsonConverter))]
        public global::FishAudio.AgentLLMConfigRedactedModel? Model { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::FishAudio.AgentLLMCustomConfigRedacted? Custom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        public global::FishAudio.AgentLLMFallbackRedacted? Fallback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMConfigRedacted" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: openai/gpt-6.1-terra-fast
        /// </param>
        /// <param name="custom">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fallback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMConfigRedacted(
            global::FishAudio.AgentLLMConfigRedactedModel? model,
            global::FishAudio.AgentLLMCustomConfigRedacted? custom,
            global::FishAudio.AgentLLMFallbackRedacted? fallback)
        {
            this.Model = model;
            this.Custom = custom;
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMConfigRedacted" /> class.
        /// </summary>
        public AgentLLMConfigRedacted()
        {
        }

    }
}