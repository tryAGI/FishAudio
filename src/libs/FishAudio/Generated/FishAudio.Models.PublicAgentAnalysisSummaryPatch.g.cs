
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentAnalysisSummaryPatch
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentAnalysisSummaryPatchLanguageJsonConverter))]
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentAnalysisSummaryPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="prompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentAnalysisSummaryPatch(
            bool? enabled,
            string? prompt,
            global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? language)
        {
            this.Enabled = enabled;
            this.Prompt = prompt;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentAnalysisSummaryPatch" /> class.
        /// </summary>
        public PublicAgentAnalysisSummaryPatch()
        {
        }

    }
}