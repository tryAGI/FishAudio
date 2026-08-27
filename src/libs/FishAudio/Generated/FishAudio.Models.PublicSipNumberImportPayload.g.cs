
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The `sip` variant of POST /v1/agent/phone-numbers: import a number that<br/>
    /// stays at your carrier. Point your trunk's origination at our SIP host,<br/>
    /// give inbound at least one authentication factor (digest and/or source<br/>
    /// CIDRs), and optionally a termination host + credentials so the number can<br/>
    /// place calls. Nothing is rented: carrier charges stay on your account, and<br/>
    /// imported numbers carry no telephony charges at all: no monthly fee, no<br/>
    /// phone surcharge, no transfer fees; you pay agent minutes only.
    /// </summary>
    public sealed partial class PublicSipNumberImportPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_auth_username")]
        public string? InboundAuthUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_auth_password")]
        public string? InboundAuthPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? InboundAllowedAddresses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_uri")]
        public string? TerminationUri { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicSipNumberImportPayloadTerminationTransportJsonConverter))]
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? TerminationTransport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_auth_username")]
        public string? TerminationAuthUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_auth_password")]
        public string? TerminationAuthPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"sip"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "sip";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSipNumberImportPayload" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="inboundAuthUsername"></param>
        /// <param name="inboundAuthPassword"></param>
        /// <param name="inboundAllowedAddresses"></param>
        /// <param name="terminationUri"></param>
        /// <param name="terminationTransport">
        /// Default Value: auto
        /// </param>
        /// <param name="terminationAuthUsername"></param>
        /// <param name="terminationAuthPassword"></param>
        /// <param name="label"></param>
        /// <param name="agentId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSipNumberImportPayload(
            string phoneNumber,
            string? inboundAuthUsername,
            string? inboundAuthPassword,
            global::System.Collections.Generic.IList<string>? inboundAllowedAddresses,
            string? terminationUri,
            global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? terminationTransport,
            string? terminationAuthUsername,
            string? terminationAuthPassword,
            string? label,
            string? agentId,
            string provider = "sip")
        {
            this.InboundAuthUsername = inboundAuthUsername;
            this.InboundAuthPassword = inboundAuthPassword;
            this.InboundAllowedAddresses = inboundAllowedAddresses;
            this.TerminationUri = terminationUri;
            this.TerminationTransport = terminationTransport;
            this.TerminationAuthUsername = terminationAuthUsername;
            this.TerminationAuthPassword = terminationAuthPassword;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label;
            this.AgentId = agentId;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSipNumberImportPayload" /> class.
        /// </summary>
        public PublicSipNumberImportPayload()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PublicSipNumberImportPayload"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PublicSipNumberImportPayload FromPhoneNumber(string phoneNumber)
        {
            return new PublicSipNumberImportPayload
            {
                PhoneNumber = phoneNumber,
            };
        }

    }
}