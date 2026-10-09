
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentVariablesPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public object? Defaults { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_missing")]
        public global::FishAudio.PublicAgentVariablesPatchOnMissing? OnMissing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVariablesPatch" /> class.
        /// </summary>
        /// <param name="defaults">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="onMissing">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentVariablesPatch(
            object? defaults,
            global::FishAudio.PublicAgentVariablesPatchOnMissing? onMissing)
        {
            this.Defaults = defaults;
            this.OnMissing = onMissing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVariablesPatch" /> class.
        /// </summary>
        public PublicAgentVariablesPatch()
        {
        }

    }
}