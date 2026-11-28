
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentPressKeysConfig
    {
        /// <summary>
        /// When true, the agent gets two tools on outbound phone calls. `_press_keys` presses phone keys to get through an automated phone menu, and `_skip_turn` stays silent for a turn while a menu or a hold message plays. An agent test on the `phone_outbound` channel has them as well. Inbound calls and web and API sessions ignore it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPressKeysConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, the agent gets two tools on outbound phone calls. `_press_keys` presses phone keys to get through an automated phone menu, and `_skip_turn` stays silent for a turn while a menu or a hold message plays. An agent test on the `phone_outbound` channel has them as well. Inbound calls and web and API sessions ignore it.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPressKeysConfig(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPressKeysConfig" /> class.
        /// </summary>
        public AgentPressKeysConfig()
        {
        }

    }
}