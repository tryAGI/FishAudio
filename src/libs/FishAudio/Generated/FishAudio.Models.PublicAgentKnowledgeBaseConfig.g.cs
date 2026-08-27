
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentKnowledgeBaseConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_source_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeSourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentKnowledgeBaseConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="knowledgeSourceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentKnowledgeBaseConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? knowledgeSourceIds)
        {
            this.Enabled = enabled;
            this.KnowledgeSourceIds = knowledgeSourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentKnowledgeBaseConfig" /> class.
        /// </summary>
        public PublicAgentKnowledgeBaseConfig()
        {
        }

    }
}