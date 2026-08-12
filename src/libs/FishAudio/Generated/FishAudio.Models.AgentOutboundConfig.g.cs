
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Outbound-only behavior; mirror of core WorkflowOutbound.<br/>
    /// Absent node = AMD on, hang up on voicemail.
    /// </summary>
    public sealed partial class AgentOutboundConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd_enabled")]
        public bool? AmdEnabled { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail")]
        public global::FishAudio.AgentOutboundVoicemailConfig? Voicemail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundConfig" /> class.
        /// </summary>
        /// <param name="amdEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="voicemail">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOutboundConfig(
            bool? amdEnabled,
            global::FishAudio.AgentOutboundVoicemailConfig? voicemail)
        {
            this.AmdEnabled = amdEnabled;
            this.Voicemail = voicemail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutboundConfig" /> class.
        /// </summary>
        public AgentOutboundConfig()
        {
        }

    }
}