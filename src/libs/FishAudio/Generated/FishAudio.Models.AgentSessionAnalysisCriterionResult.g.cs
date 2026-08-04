
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSessionAnalysisCriterionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisCriterionResultResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionAnalysisCriterionResultResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAnalysisCriterionResult" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
        /// <param name="rationale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionAnalysisCriterionResult(
            string name,
            global::FishAudio.AgentSessionAnalysisCriterionResultResult result,
            string? rationale)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Result = result;
            this.Rationale = rationale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAnalysisCriterionResult" /> class.
        /// </summary>
        public AgentSessionAnalysisCriterionResult()
        {
        }

    }
}