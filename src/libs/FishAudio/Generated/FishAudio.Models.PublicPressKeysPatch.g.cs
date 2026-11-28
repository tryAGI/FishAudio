
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicPressKeysPatch
    {
        /// <summary>
        /// When true, the agent gets two tools on outbound phone calls. `_press_keys` presses phone keys to get through an automated phone menu, and `_skip_turn` stays silent for a turn while a menu or a hold message plays. An agent test on the `phone_outbound` channel has them as well. Inbound calls and web and API sessions ignore it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPressKeysPatch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, the agent gets two tools on outbound phone calls. `_press_keys` presses phone keys to get through an automated phone menu, and `_skip_turn` stays silent for a turn while a menu or a hold message plays. An agent test on the `phone_outbound` channel has them as well. Inbound calls and web and API sessions ignore it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPressKeysPatch(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPressKeysPatch" /> class.
        /// </summary>
        public PublicPressKeysPatch()
        {
        }

    }
}