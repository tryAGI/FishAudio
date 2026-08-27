
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// POST phone-calls body, shared by the public and console routes.<br/>
    /// to_number is deliberately not format-validated here: the contract orders<br/>
    /// the E.164 check after the agent/published checks, so it runs in the<br/>
    /// service with a machine-readable reason.
    /// </summary>
    public sealed partial class PhoneCallCreatePayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The team-owned number to dial from (twilio provider only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// Destination in E.164, e.g. +14155550123.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::FishAudio.AgentSessionOverridesPayload? Overrides { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneCallCreatePayload" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="phoneNumberId">
        /// The team-owned number to dial from (twilio provider only).
        /// </param>
        /// <param name="toNumber">
        /// Destination in E.164, e.g. +14155550123.
        /// </param>
        /// <param name="dynamicVariables">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="overrides">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneCallCreatePayload(
            string agentId,
            string phoneNumberId,
            string toNumber,
            object? dynamicVariables,
            global::FishAudio.AgentSessionOverridesPayload? overrides,
            object? metadata)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.DynamicVariables = dynamicVariables;
            this.Overrides = overrides;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneCallCreatePayload" /> class.
        /// </summary>
        public PhoneCallCreatePayload()
        {
        }

    }
}