
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentLLMFallbackRedacted
    {
        /// <summary>
        /// Default Value: platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentLLMFallbackRedactedModeJsonConverter))]
        public global::FishAudio.AgentLLMFallbackRedactedMode? Mode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelRedacted>? Models { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::FishAudio.AgentLLMTimeouts? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackRedacted" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: platform
        /// </param>
        /// <param name="models">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="primary">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMFallbackRedacted(
            global::FishAudio.AgentLLMFallbackRedactedMode? mode,
            global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelRedacted>? models,
            global::FishAudio.AgentLLMTimeouts? primary)
        {
            this.Mode = mode;
            this.Models = models;
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMFallbackRedacted" /> class.
        /// </summary>
        public AgentLLMFallbackRedacted()
        {
        }

    }
}