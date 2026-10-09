
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTransferDestinationPatch
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchTypeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationPatchType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_uri")]
        public string? SipUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: cold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchModeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationPatchMode? Mode { get; set; }

        /// <summary>
        /// Default Value: confirm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_connect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchWarmConnectJsonConverter))]
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? WarmConnect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_briefing_instructions")]
        public string? WarmBriefingInstructions { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_ring_timeout_seconds")]
        public int? WarmRingTimeoutSeconds { get; set; }

        /// <summary>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_confirm_timeout_seconds")]
        public int? WarmConfirmTimeoutSeconds { get; set; }

        /// <summary>
        /// Applies to warm transfers whose warm_connect is `confirm` or `briefing`, and is ignored for cold transfers and `direct`. When true, once the destination answers, the agent stays silent until the other side speaks, then classifies the pickup. A person is briefed as usual. Voicemail or an IVR (phone menu) ends the transfer as failed. A hold queue or silence keeps the agent waiting until `warm_confirm_timeout_seconds` ends the attempt as unreachable. A failed transfer follows `on_failure`. Leave it off for destinations whose people are only reachable through a phone menu, because the menu stops the transfer.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_human_detection")]
        public bool? WarmHumanDetection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_failure")]
        public global::FishAudio.AgentTransferOnFailurePatch? OnFailure { get; set; }

        /// <summary>
        /// Default Value: generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("announcement_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchAnnouncementModeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? AnnouncementMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("announcement_message")]
        public string? AnnouncementMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestinationPatch" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: phone
        /// </param>
        /// <param name="label"></param>
        /// <param name="phoneNumber">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sipUri">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description"></param>
        /// <param name="mode">
        /// Default Value: cold
        /// </param>
        /// <param name="warmConnect">
        /// Default Value: confirm
        /// </param>
        /// <param name="warmBriefingInstructions"></param>
        /// <param name="warmRingTimeoutSeconds">
        /// Default Value: 30
        /// </param>
        /// <param name="warmConfirmTimeoutSeconds">
        /// Default Value: 60
        /// </param>
        /// <param name="warmHumanDetection">
        /// Applies to warm transfers whose warm_connect is `confirm` or `briefing`, and is ignored for cold transfers and `direct`. When true, once the destination answers, the agent stays silent until the other side speaks, then classifies the pickup. A person is briefed as usual. Voicemail or an IVR (phone menu) ends the transfer as failed. A hold queue or silence keeps the agent waiting until `warm_confirm_timeout_seconds` ends the attempt as unreachable. A failed transfer follows `on_failure`. Leave it off for destinations whose people are only reachable through a phone menu, because the menu stops the transfer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="onFailure"></param>
        /// <param name="announcementMode">
        /// Default Value: generated
        /// </param>
        /// <param name="announcementMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferDestinationPatch(
            global::FishAudio.AgentTransferDestinationPatchType? type,
            string? label,
            string? phoneNumber,
            string? sipUri,
            string? description,
            global::FishAudio.AgentTransferDestinationPatchMode? mode,
            global::FishAudio.AgentTransferDestinationPatchWarmConnect? warmConnect,
            string? warmBriefingInstructions,
            int? warmRingTimeoutSeconds,
            int? warmConfirmTimeoutSeconds,
            bool? warmHumanDetection,
            global::FishAudio.AgentTransferOnFailurePatch? onFailure,
            global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? announcementMode,
            string? announcementMessage)
        {
            this.Type = type;
            this.Label = label;
            this.PhoneNumber = phoneNumber;
            this.SipUri = sipUri;
            this.Description = description;
            this.Mode = mode;
            this.WarmConnect = warmConnect;
            this.WarmBriefingInstructions = warmBriefingInstructions;
            this.WarmRingTimeoutSeconds = warmRingTimeoutSeconds;
            this.WarmConfirmTimeoutSeconds = warmConfirmTimeoutSeconds;
            this.WarmHumanDetection = warmHumanDetection;
            this.OnFailure = onFailure;
            this.AnnouncementMode = announcementMode;
            this.AnnouncementMessage = announcementMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestinationPatch" /> class.
        /// </summary>
        public AgentTransferDestinationPatch()
        {
        }

    }
}