
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Full desired trunk config for PUT /v1/agent/phone-numbers/{id}/sip-config.<br/>
    /// Send the complete configuration; leaving a password empty beside a set<br/>
    /// username keeps the stored one. `termination_headers` replaces the whole<br/>
    /// header map (send `{}` to remove all custom headers).
    /// </summary>
    public sealed partial class PublicSipNumberConfigPayload
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicSipNumberConfigPayloadTerminationTransportJsonConverter))]
        public global::FishAudio.PublicSipNumberConfigPayloadTerminationTransport? TerminationTransport { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? TerminationHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSipNumberConfigPayload" /> class.
        /// </summary>
        /// <param name="inboundAuthUsername"></param>
        /// <param name="inboundAuthPassword"></param>
        /// <param name="inboundAllowedAddresses"></param>
        /// <param name="terminationUri"></param>
        /// <param name="terminationTransport">
        /// Default Value: auto
        /// </param>
        /// <param name="terminationAuthUsername"></param>
        /// <param name="terminationAuthPassword"></param>
        /// <param name="terminationHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSipNumberConfigPayload(
            string? inboundAuthUsername,
            string? inboundAuthPassword,
            global::System.Collections.Generic.IList<string>? inboundAllowedAddresses,
            string? terminationUri,
            global::FishAudio.PublicSipNumberConfigPayloadTerminationTransport? terminationTransport,
            string? terminationAuthUsername,
            string? terminationAuthPassword,
            global::System.Collections.Generic.Dictionary<string, string>? terminationHeaders)
        {
            this.InboundAuthUsername = inboundAuthUsername;
            this.InboundAuthPassword = inboundAuthPassword;
            this.InboundAllowedAddresses = inboundAllowedAddresses;
            this.TerminationUri = terminationUri;
            this.TerminationTransport = terminationTransport;
            this.TerminationAuthUsername = terminationAuthUsername;
            this.TerminationAuthPassword = terminationAuthPassword;
            this.TerminationHeaders = terminationHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSipNumberConfigPayload" /> class.
        /// </summary>
        public PublicSipNumberConfigPayload()
        {
        }

    }
}