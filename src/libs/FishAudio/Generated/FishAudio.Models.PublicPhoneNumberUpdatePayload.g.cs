
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicPhoneNumberUpdatePayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Agent that answers this number's inbound calls. Explicit null unbinds; omit the field to keep the current binding.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Managed `twilio` numbers only: the caller ID a transfer target sees, `agent_number` (this number) or `original_caller` (the caller's own number). Applies to cold and warm transfers. It is a number setting, not agent config: no publish is needed and agent rollbacks leave it alone. Warm transfers follow it from the next call, cold transfers once `caller_id_sync_status` is `synced`. The deprecated boolean `cold_transfer_use_original_caller` is still accepted in its place.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_caller_id")]
        public global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? TransferCallerId { get; set; }

        /// <summary>
        /// Re-apply the current caller ID policy after a failed synchronization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_caller_id_sync")]
        public bool? RetryCallerIdSync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPhoneNumberUpdatePayload" /> class.
        /// </summary>
        /// <param name="label">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId">
        /// Agent that answers this number's inbound calls. Explicit null unbinds; omit the field to keep the current binding.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferCallerId">
        /// Managed `twilio` numbers only: the caller ID a transfer target sees, `agent_number` (this number) or `original_caller` (the caller's own number). Applies to cold and warm transfers. It is a number setting, not agent config: no publish is needed and agent rollbacks leave it alone. Warm transfers follow it from the next call, cold transfers once `caller_id_sync_status` is `synced`. The deprecated boolean `cold_transfer_use_original_caller` is still accepted in its place.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="retryCallerIdSync">
        /// Re-apply the current caller ID policy after a failed synchronization.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPhoneNumberUpdatePayload(
            string? label,
            string? agentId,
            global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? transferCallerId,
            bool? retryCallerIdSync)
        {
            this.Label = label;
            this.AgentId = agentId;
            this.TransferCallerId = transferCallerId;
            this.RetryCallerIdSync = retryCallerIdSync;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPhoneNumberUpdatePayload" /> class.
        /// </summary>
        public PublicPhoneNumberUpdatePayload()
        {
        }

    }
}