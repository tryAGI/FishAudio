
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One transfer attempt. `call_id` matches its `_transfer_call` tool_call<br/>
    /// item. A warm transfer's consult call (the caller on hold meanwhile) is in<br/>
    /// `messages`, never in the caller's message items. `merged` and `referred`<br/>
    /// succeeded, and `outcome` is null while the attempt runs.
    /// </summary>
    public sealed partial class AgentSessionTransferItem
    {
        /// <summary>
        /// Default Value: transfer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionTransferItemDestinationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionTransferItemDestinationType DestinationType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionTransferItemModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionTransferItemMode Mode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_connect")]
        public global::FishAudio.AgentSessionTransferItemWarmConnect? WarmConnect { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public global::FishAudio.AgentSessionTransferItemOutcome? Outcome { get; set; }

        /// <summary>
        /// dial_failed and refer_failed: the final SIP response code the carrier gave. Null when it gave none.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_status")]
        public int? SipStatus { get; set; }

        /// <summary>
        /// dial_failed and refer_failed: why the transfer target could not be reached, classified from sip_status the same way as an outbound call's dial_status.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dial_status")]
        public global::FishAudio.AgentSessionTransferItemDialStatus? DialStatus { get; set; }

        /// <summary>
        /// declined: the agent's summary of why the transfer target declined. Null when none was given. What they actually said is in messages.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decline_reason")]
        public string? DeclineReason { get; set; }

        /// <summary>
        /// consult_closed: how the consult call ended before the caller was connected. Null when it cannot be told.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consult_end_reason")]
        public global::FishAudio.AgentSessionTransferItemConsultEndReason? ConsultEndReason { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_started_at")]
        public string? HoldStartedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_ended_at")]
        public string? HoldEndedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dial_started_at")]
        public string? DialStartedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answered_at")]
        public string? AnsweredAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public string? EndedAt { get; set; }

        /// <summary>
        /// merged and referred: when the call between the caller and the transfer target ended. Null while it is still on. A cold transfer waits for the carrier's call record (up to about an hour) and stays null on imported SIP numbers.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_call_ended_at")]
        public string? TransferredCallEndedAt { get; set; }

        /// <summary>
        /// merged and referred: how long the caller talked with the transfer target. Warm: from ended_at to transferred_call_ended_at. Cold: the carrier's call record, 0 when the target never really answered.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_call_duration_seconds")]
        public int? TransferredCallDurationSeconds { get; set; }

        /// <summary>
        /// merged: how the call between the caller and the transfer target ended. caller_hangup: the caller hung up (on an outbound call, the person the agent called). transfer_target_hangup: the transfer target hung up. conversation_timeout: the call reached the agent's maximum call duration, counted from the start of the call. connection_lost: a line dropped, nobody hung up. Null when it cannot be told, and always null on a cold transfer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_call_end_reason")]
        public global::FishAudio.AgentSessionTransferItemTransferredCallEndReason? TransferredCallEndReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferMessage>? Messages { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionTransferItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="destination"></param>
        /// <param name="destinationType"></param>
        /// <param name="target"></param>
        /// <param name="mode"></param>
        /// <param name="type">
        /// Default Value: transfer
        /// </param>
        /// <param name="warmConnect">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outcome">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sipStatus">
        /// dial_failed and refer_failed: the final SIP response code the carrier gave. Null when it gave none.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dialStatus">
        /// dial_failed and refer_failed: why the transfer target could not be reached, classified from sip_status the same way as an outbound call's dial_status.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="declineReason">
        /// declined: the agent's summary of why the transfer target declined. Null when none was given. What they actually said is in messages.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="consultEndReason">
        /// consult_closed: how the consult call ended before the caller was connected. Null when it cannot be told.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="holdStartedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="holdEndedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dialStartedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="answeredAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferredCallEndedAt">
        /// merged and referred: when the call between the caller and the transfer target ended. Null while it is still on. A cold transfer waits for the carrier's call record (up to about an hour) and stays null on imported SIP numbers.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferredCallDurationSeconds">
        /// merged and referred: how long the caller talked with the transfer target. Warm: from ended_at to transferred_call_ended_at. Cold: the carrier's call record, 0 when the target never really answered.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transferredCallEndReason">
        /// merged: how the call between the caller and the transfer target ended. caller_hangup: the caller hung up (on an outbound call, the person the agent called). transfer_target_hangup: the transfer target hung up. conversation_timeout: the call reached the agent's maximum call duration, counted from the start of the call. connection_lost: a line dropped, nobody hung up. Null when it cannot be told, and always null on a cold transfer.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="messages"></param>
        /// <param name="createdAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionTransferItem(
            string callId,
            string destination,
            global::FishAudio.AgentSessionTransferItemDestinationType destinationType,
            string target,
            global::FishAudio.AgentSessionTransferItemMode mode,
            string? type,
            global::FishAudio.AgentSessionTransferItemWarmConnect? warmConnect,
            global::FishAudio.AgentSessionTransferItemOutcome? outcome,
            int? sipStatus,
            global::FishAudio.AgentSessionTransferItemDialStatus? dialStatus,
            string? declineReason,
            global::FishAudio.AgentSessionTransferItemConsultEndReason? consultEndReason,
            string? holdStartedAt,
            string? holdEndedAt,
            string? dialStartedAt,
            string? answeredAt,
            string? endedAt,
            string? transferredCallEndedAt,
            int? transferredCallDurationSeconds,
            global::FishAudio.AgentSessionTransferItemTransferredCallEndReason? transferredCallEndReason,
            global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferMessage>? messages,
            string? createdAt)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.DestinationType = destinationType;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Mode = mode;
            this.WarmConnect = warmConnect;
            this.Outcome = outcome;
            this.SipStatus = sipStatus;
            this.DialStatus = dialStatus;
            this.DeclineReason = declineReason;
            this.ConsultEndReason = consultEndReason;
            this.HoldStartedAt = holdStartedAt;
            this.HoldEndedAt = holdEndedAt;
            this.DialStartedAt = dialStartedAt;
            this.AnsweredAt = answeredAt;
            this.EndedAt = endedAt;
            this.TransferredCallEndedAt = transferredCallEndedAt;
            this.TransferredCallDurationSeconds = transferredCallDurationSeconds;
            this.TransferredCallEndReason = transferredCallEndReason;
            this.Messages = messages;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionTransferItem" /> class.
        /// </summary>
        public AgentSessionTransferItem()
        {
        }

    }
}