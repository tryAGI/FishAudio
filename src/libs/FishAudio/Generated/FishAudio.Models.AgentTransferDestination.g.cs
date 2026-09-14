
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTransferDestination
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationTypeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationType? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationModeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationMode? Mode { get; set; }

        /// <summary>
        /// Default Value: confirm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_connect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectJsonConverter))]
        public global::FishAudio.AgentTransferDestinationWarmConnect? WarmConnect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestination" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferDestination(
            global::FishAudio.AgentTransferDestinationType? type,
            string? label,
            string? phoneNumber,
            string? sipUri,
            string? description,
            global::FishAudio.AgentTransferDestinationMode? mode,
            global::FishAudio.AgentTransferDestinationWarmConnect? warmConnect)
        {
            this.Type = type;
            this.Label = label;
            this.PhoneNumber = phoneNumber;
            this.SipUri = sipUri;
            this.Description = description;
            this.Mode = mode;
            this.WarmConnect = warmConnect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestination" /> class.
        /// </summary>
        public AgentTransferDestination()
        {
        }

    }
}