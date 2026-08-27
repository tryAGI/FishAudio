
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Public trim of the post-call analysis record: outcomes only, no run<br/>
    /// internals (model, tokens, config hash).
    /// </summary>
    public sealed partial class AgentSessionAnalysisResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionAnalysisResultStatus Status { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_results")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? CriteriaResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAnalysisResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="summary">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="data"></param>
        /// <param name="criteriaResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionAnalysisResult(
            global::FishAudio.AgentSessionAnalysisResultStatus status,
            string? summary,
            global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? data,
            global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? criteriaResults)
        {
            this.Status = status;
            this.Summary = summary;
            this.Data = data;
            this.CriteriaResults = criteriaResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAnalysisResult" /> class.
        /// </summary>
        public AgentSessionAnalysisResult()
        {
        }

    }
}