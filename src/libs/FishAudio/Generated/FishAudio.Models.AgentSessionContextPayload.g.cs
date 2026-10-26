
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Per-session overrides of the agent's context switches (the config's<br/>
    /// `context` section). A switch left out follows the agent.
    /// </summary>
    public sealed partial class AgentSessionContextPayload
    {
        /// <summary>
        /// Whether the agent knows the current date and time in this session. Omit it to follow the agent's `context.current_time`. `false` withholds both from this session, `true` injects them even when the agent has them off.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_time")]
        public bool? CurrentTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionContextPayload" /> class.
        /// </summary>
        /// <param name="currentTime">
        /// Whether the agent knows the current date and time in this session. Omit it to follow the agent's `context.current_time`. `false` withholds both from this session, `true` injects them even when the agent has them off.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionContextPayload(
            bool? currentTime)
        {
            this.CurrentTime = currentTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionContextPayload" /> class.
        /// </summary>
        public AgentSessionContextPayload()
        {
        }

    }
}