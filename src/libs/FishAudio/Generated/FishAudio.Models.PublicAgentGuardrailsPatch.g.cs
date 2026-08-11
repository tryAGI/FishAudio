
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentGuardrailsPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public bool? Focus { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manipulation")]
        public bool? Manipulation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentGuardrailsPatch" /> class.
        /// </summary>
        /// <param name="focus">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="manipulation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentGuardrailsPatch(
            bool? focus,
            bool? manipulation)
        {
            this.Focus = focus;
            this.Manipulation = manipulation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentGuardrailsPatch" /> class.
        /// </summary>
        public PublicAgentGuardrailsPatch()
        {
        }

    }
}