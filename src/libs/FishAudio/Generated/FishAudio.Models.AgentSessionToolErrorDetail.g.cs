
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A failed tool call's structured reason, beside the `error` string.<br/>
    /// Only `_transfer_call` fills it so far: `status_code` is then why the<br/>
    /// transfer did not connect (not_placed, busy, no_answer, declined, voicemail,<br/>
    /// ivr, hung_up, merge_failed or caller_hangup, the last when the caller hung<br/>
    /// up during the transfer). The gateway's keys, forwarded as they are.
    /// </summary>
    public sealed partial class AgentSessionToolErrorDetail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusCode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_status")]
        public int? SipStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionToolErrorDetail" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="statusMessage"></param>
        /// <param name="sipStatus">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionToolErrorDetail(
            string statusCode,
            string statusMessage,
            int? sipStatus)
        {
            this.StatusCode = statusCode ?? throw new global::System.ArgumentNullException(nameof(statusCode));
            this.SipStatus = sipStatus;
            this.StatusMessage = statusMessage ?? throw new global::System.ArgumentNullException(nameof(statusMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionToolErrorDetail" /> class.
        /// </summary>
        public AgentSessionToolErrorDetail()
        {
        }

    }
}