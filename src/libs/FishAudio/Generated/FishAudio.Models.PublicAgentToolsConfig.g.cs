
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentToolsConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tools")]
        public global::FishAudio.AgentSystemToolsConfig? SystemTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentToolsConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="toolIds"></param>
        /// <param name="systemTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentToolsConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::FishAudio.AgentSystemToolsConfig? systemTools)
        {
            this.Enabled = enabled;
            this.ToolIds = toolIds;
            this.SystemTools = systemTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentToolsConfig" /> class.
        /// </summary>
        public PublicAgentToolsConfig()
        {
        }

    }
}