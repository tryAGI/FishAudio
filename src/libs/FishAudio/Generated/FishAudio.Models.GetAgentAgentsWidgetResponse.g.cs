
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Display config for the embeddable `&lt;fish-agent&gt;` widget.<br/>
    /// Served without authentication for public agents; HTML attributes on the<br/>
    /// embed tag override every field. Grows alongside the Builder widget tab<br/>
    /// (greeting, policy switches, styles): additions only, never renames.
    /// </summary>
    public sealed partial class GetAgentAgentsWidgetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAgentsWidgetResponse" /> class.
        /// </summary>
        /// <param name="agentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentAgentsWidgetResponse(
            string agentName)
        {
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAgentsWidgetResponse" /> class.
        /// </summary>
        public GetAgentAgentsWidgetResponse()
        {
        }

    }
}