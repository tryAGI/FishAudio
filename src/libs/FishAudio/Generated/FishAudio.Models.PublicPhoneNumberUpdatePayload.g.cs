
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
        /// Managed `twilio` numbers only: show the original caller's number on cold transfers (true) or this number (false). Takes effect for new calls once `caller_id_sync_status` is `synced`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cold_transfer_use_original_caller")]
        public bool? ColdTransferUseOriginalCaller { get; set; }

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
        /// <param name="coldTransferUseOriginalCaller">
        /// Managed `twilio` numbers only: show the original caller's number on cold transfers (true) or this number (false). Takes effect for new calls once `caller_id_sync_status` is `synced`.<br/>
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
            bool? coldTransferUseOriginalCaller,
            bool? retryCallerIdSync)
        {
            this.Label = label;
            this.AgentId = agentId;
            this.ColdTransferUseOriginalCaller = coldTransferUseOriginalCaller;
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