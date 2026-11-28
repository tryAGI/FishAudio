
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTransferPressKeysPatch
    {
        /// <summary>
        /// When true, on the call to this destination the agent can press phone keys to get through the menu (`_press_keys`), and stay silent while the menu or a hold message plays (`_skip_turn`), before it briefs the person who answers. It works the same whether the caller's own call is inbound or outbound, and does not depend on `tools.system_tools.press_keys`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How to get through this number's phone menu, written for the agent, such as `Press 2 for billing, then enter extension 204.` Optional, at most 500 characters. `{{variable}}` placeholders are filled in for each session. Without it the agent picks keys from the destination's label and description and from what the caller asked for. Used only while enabled is true, and kept when it is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferPressKeysPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, on the call to this destination the agent can press phone keys to get through the menu (`_press_keys`), and stay silent while the menu or a hold message plays (`_skip_turn`), before it briefs the person who answers. It works the same whether the caller's own call is inbound or outbound, and does not depend on `tools.system_tools.press_keys`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="instructions">
        /// How to get through this number's phone menu, written for the agent, such as `Press 2 for billing, then enter extension 204.` Optional, at most 500 characters. `{{variable}}` placeholders are filled in for each session. Without it the agent picks keys from the destination's label and description and from what the caller asked for. Used only while enabled is true, and kept when it is false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferPressKeysPatch(
            bool? enabled,
            string? instructions)
        {
            this.Enabled = enabled;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferPressKeysPatch" /> class.
        /// </summary>
        public AgentTransferPressKeysPatch()
        {
        }

    }
}