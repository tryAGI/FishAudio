
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConversationConfig
    {
        /// <summary>
        /// Default Value: 1800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: balanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentConversationConfigEagernessJsonConverter))]
        public global::FishAudio.AgentConversationConfigEagerness? Eagerness { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptible")]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// Default Value: balanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentConversationConfigInterruptionSensitivityJsonConverter))]
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? InterruptionSensitivity { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reengage_enabled")]
        public bool? ReengageEnabled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_audio")]
        public bool? RecordAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destinations")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? TransferDestinations { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound")]
        public global::FishAudio.AgentOutboundConfig? Outbound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationConfig" /> class.
        /// </summary>
        /// <param name="maxDurationSeconds">
        /// Default Value: 1800
        /// </param>
        /// <param name="eagerness">
        /// Default Value: balanced
        /// </param>
        /// <param name="interruptible">
        /// Default Value: true
        /// </param>
        /// <param name="interruptionSensitivity">
        /// Default Value: balanced
        /// </param>
        /// <param name="reengageEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="recordAudio">
        /// Default Value: true
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="transferDestinations">
        /// Default Value: []
        /// </param>
        /// <param name="outbound">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationConfig(
            int? maxDurationSeconds,
            global::FishAudio.AgentConversationConfigEagerness? eagerness,
            bool? interruptible,
            global::FishAudio.AgentConversationConfigInterruptionSensitivity? interruptionSensitivity,
            bool? reengageEnabled,
            bool? recordAudio,
            string? timezone,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? transferDestinations,
            global::FishAudio.AgentOutboundConfig? outbound)
        {
            this.MaxDurationSeconds = maxDurationSeconds;
            this.Eagerness = eagerness;
            this.Interruptible = interruptible;
            this.InterruptionSensitivity = interruptionSensitivity;
            this.ReengageEnabled = reengageEnabled;
            this.RecordAudio = recordAudio;
            this.Timezone = timezone;
            this.TransferDestinations = transferDestinations;
            this.Outbound = outbound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationConfig" /> class.
        /// </summary>
        public AgentConversationConfig()
        {
        }

    }
}