
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentAnalysisPatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Summary { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? DataFields { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentAnalysisPatch" /> class.
        /// </summary>
        /// <param name="summary">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dataFields">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="criteria">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentAnalysisPatch(
            global::FishAudio.PublicAgentAnalysisSummaryPatch? summary,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? dataFields,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? criteria)
        {
            this.Summary = summary;
            this.DataFields = dataFields;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentAnalysisPatch" /> class.
        /// </summary>
        public PublicAgentAnalysisPatch()
        {
        }

    }
}