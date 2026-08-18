
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentLLMPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::FishAudio.PublicAgentLLMPatchTier2? Tier { get; set; }

        /// <summary>
        /// Your own OpenAI-compatible endpoint; mutually exclusive with `tier`, explicit null reverts to the tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::FishAudio.PublicAgentLLMCustomConfig? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentLLMPatch" /> class.
        /// </summary>
        /// <param name="tier">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// Your own OpenAI-compatible endpoint; mutually exclusive with `tier`, explicit null reverts to the tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentLLMPatch(
            global::FishAudio.PublicAgentLLMPatchTier2? tier,
            global::FishAudio.PublicAgentLLMCustomConfig? custom)
        {
            this.Tier = tier;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentLLMPatch" /> class.
        /// </summary>
        public PublicAgentLLMPatch()
        {
        }

    }
}