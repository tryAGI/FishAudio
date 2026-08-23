
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentPhoneNumbersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// E.164, e.g. +14155550123.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.CreateAgentPhoneNumbersResponseProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Inbound calls route to this agent; unbound numbers ring busy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.CreateAgentPhoneNumbersResponseStatus Status { get; set; }

        /// <summary>
        /// What failed when status is `error`; empty otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_detail")]
        public string? StatusDetail { get; set; }

        /// <summary>
        /// Whether the number can place calls (outbound and warm-transfer consult legs): managed `twilio` always, imported `sip` only when a termination was configured.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_outbound")]
        public bool? SupportsOutbound { get; set; }

        /// <summary>
        /// Imported `sip` numbers: the customer trunk's termination host.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_uri")]
        public string? TerminationUri { get; set; }

        /// <summary>
        /// Imported `sip` numbers: the inbound digest username. Passwords are never echoed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_auth_username")]
        public string? InboundAuthUsername { get; set; }

        /// <summary>
        /// Imported `sip` numbers: allowed source IPs/CIDRs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? InboundAllowedAddresses { get; set; }

        /// <summary>
        /// Imported `sip` numbers: termination transport.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_transport")]
        public string? TerminationTransport { get; set; }

        /// <summary>
        /// Imported `sip` numbers: the termination digest username. Passwords are never echoed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("termination_auth_username")]
        public string? TerminationAuthUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentPhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="phoneNumber">
        /// E.164, e.g. +14155550123.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="label"></param>
        /// <param name="agentId">
        /// Inbound calls route to this agent; unbound numbers ring busy.
        /// </param>
        /// <param name="statusDetail">
        /// What failed when status is `error`; empty otherwise.
        /// </param>
        /// <param name="supportsOutbound">
        /// Whether the number can place calls (outbound and warm-transfer consult legs): managed `twilio` always, imported `sip` only when a termination was configured.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="terminationUri">
        /// Imported `sip` numbers: the customer trunk's termination host.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inboundAuthUsername">
        /// Imported `sip` numbers: the inbound digest username. Passwords are never echoed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inboundAllowedAddresses">
        /// Imported `sip` numbers: allowed source IPs/CIDRs.
        /// </param>
        /// <param name="terminationTransport">
        /// Imported `sip` numbers: termination transport.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="terminationAuthUsername">
        /// Imported `sip` numbers: the termination digest username. Passwords are never echoed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentPhoneNumbersResponse(
            string phoneNumberId,
            string workspaceId,
            string phoneNumber,
            global::FishAudio.CreateAgentPhoneNumbersResponseProvider provider,
            global::FishAudio.CreateAgentPhoneNumbersResponseStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? label,
            string? agentId,
            string? statusDetail,
            bool? supportsOutbound,
            string? terminationUri,
            string? inboundAuthUsername,
            global::System.Collections.Generic.IList<string>? inboundAllowedAddresses,
            string? terminationTransport,
            string? terminationAuthUsername)
        {
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Provider = provider;
            this.Label = label;
            this.AgentId = agentId;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.SupportsOutbound = supportsOutbound;
            this.TerminationUri = terminationUri;
            this.InboundAuthUsername = inboundAuthUsername;
            this.InboundAllowedAddresses = inboundAllowedAddresses;
            this.TerminationTransport = terminationTransport;
            this.TerminationAuthUsername = terminationAuthUsername;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentPhoneNumbersResponse" /> class.
        /// </summary>
        public CreateAgentPhoneNumbersResponse()
        {
        }

    }
}