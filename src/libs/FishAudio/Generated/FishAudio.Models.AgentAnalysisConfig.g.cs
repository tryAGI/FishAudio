
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalysisConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::FishAudio.AgentAnalysisSummaryConfig? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? DataFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisConfig" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="dataFields"></param>
        /// <param name="criteria"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalysisConfig(
            global::FishAudio.AgentAnalysisSummaryConfig? summary,
            global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? dataFields,
            global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? criteria)
        {
            this.Summary = summary;
            this.DataFields = dataFields;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalysisConfig" /> class.
        /// </summary>
        public AgentAnalysisConfig()
        {
        }

    }
}