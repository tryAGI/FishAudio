
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
            global::FishAudio.AgentTransferDestinationPatchWarmConnect? warmConnect)
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
        /// Initializes a new instance of the <see cref="AgentTransferDestinationPatch" /> class.
        /// </summary>
        public AgentTransferDestinationPatch()
        {
        }

    }
}