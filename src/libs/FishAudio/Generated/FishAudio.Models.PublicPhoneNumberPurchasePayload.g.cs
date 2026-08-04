
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicPhoneNumberPurchasePayload
    {
        /// <summary>
        /// Inventory to buy from. Only the managed `twilio` inventory is purchasable (supports call transfer). The field discriminates so importing your own numbers can share this endpoint later.
        /// </summary>
        /// <default>"twilio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "twilio";

        /// <summary>
        /// E.164 number from `GET /v1/agent/available-phone-numbers`, e.g. +14155550123.
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
        /// Bind an agent to answer inbound calls right away.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPhoneNumberPurchasePayload" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// E.164 number from `GET /v1/agent/available-phone-numbers`, e.g. +14155550123.
        /// </param>
        /// <param name="label"></param>
        /// <param name="agentId">
        /// Bind an agent to answer inbound calls right away.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider">
        /// Inventory to buy from. Only the managed `twilio` inventory is purchasable (supports call transfer). The field discriminates so importing your own numbers can share this endpoint later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPhoneNumberPurchasePayload(
            string phoneNumber,
            string? label,
            string? agentId,
            string provider = "twilio")
        {
            this.Provider = provider;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPhoneNumberPurchasePayload" /> class.
        /// </summary>
        public PublicPhoneNumberPurchasePayload()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PublicPhoneNumberPurchasePayload"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PublicPhoneNumberPurchasePayload FromPhoneNumber(string phoneNumber)
        {
            return new PublicPhoneNumberPurchasePayload
            {
                PhoneNumber = phoneNumber,
            };
        }

    }
}