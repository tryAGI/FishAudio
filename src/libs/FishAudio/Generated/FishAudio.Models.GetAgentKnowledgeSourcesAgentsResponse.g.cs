
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAgentKnowledgeSourcesAgentsResponse
    {
        /// <summary>
        /// Agents that reference this resource in their configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent> Agents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgeSourcesAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents">
        /// Agents that reference this resource in their configuration.
        /// </param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentKnowledgeSourcesAgentsResponse(
            global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent> agents,
            int total)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgeSourcesAgentsResponse" /> class.
        /// </summary>
        public GetAgentKnowledgeSourcesAgentsResponse()
        {
        }

    }
}