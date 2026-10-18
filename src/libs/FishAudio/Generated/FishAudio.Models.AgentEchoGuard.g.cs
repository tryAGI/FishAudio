
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Echo guard per call channel: true on, false off, null uses the default.
    /// </summary>
    public sealed partial class AgentEchoGuard
    {
        /// <summary>
        /// Voice calls in a browser or app (web widget, SDK, test calls). Null uses the default (on).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_voice")]
        public bool? WebVoice { get; set; }

        /// <summary>
        /// Inbound phone calls. Null uses the default (on).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_inbound")]
        public bool? PhoneInbound { get; set; }

        /// <summary>
        /// Outbound phone calls. Null uses the default (off).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_outbound")]
        public bool? PhoneOutbound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEchoGuard" /> class.
        /// </summary>
        /// <param name="webVoice">
        /// Voice calls in a browser or app (web widget, SDK, test calls). Null uses the default (on).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="phoneInbound">
        /// Inbound phone calls. Null uses the default (on).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="phoneOutbound">
        /// Outbound phone calls. Null uses the default (off).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentEchoGuard(
            bool? webVoice,
            bool? phoneInbound,
            bool? phoneOutbound)
        {
            this.WebVoice = webVoice;
            this.PhoneInbound = phoneInbound;
            this.PhoneOutbound = phoneOutbound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEchoGuard" /> class.
        /// </summary>
        public AgentEchoGuard()
        {
        }

    }
}