
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentKnowledgeBasePatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Replaces the attached knowledge sources wholesale. Every id must be an existing knowledge source visible to the agent, else 422.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_source_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeSourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentKnowledgeBasePatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="knowledgeSourceIds">
        /// Replaces the attached knowledge sources wholesale. Every id must be an existing knowledge source visible to the agent, else 422.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentKnowledgeBasePatch(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? knowledgeSourceIds)
        {
            this.Enabled = enabled;
            this.KnowledgeSourceIds = knowledgeSourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentKnowledgeBasePatch" /> class.
        /// </summary>
        public PublicAgentKnowledgeBasePatch()
        {
        }

    }
}