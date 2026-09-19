
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionSummaryEndReason
    {
        /// <summary>
        ///
        /// </summary>
        AgentHangup,
        /// <summary>
        ///
        /// </summary>
        AgentJoinTimeout,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        ConversationTimeout,
        /// <summary>
        ///
        /// </summary>
        DialFailed,
        /// <summary>
        ///
        /// </summary>
        Escalated,
        /// <summary>
        ///
        /// </summary>
        HeartbeatTimeout,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        LlmEndpointFailure,
        /// <summary>
        ///
        /// </summary>
        RoomJoinTimeout,
        /// <summary>
        ///
        /// </summary>
        UserHangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionSummaryEndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryEndReason value)
        {
            return value switch
            {
                AgentSessionSummaryEndReason.AgentHangup => "agent_hangup",
                AgentSessionSummaryEndReason.AgentJoinTimeout => "agent_join_timeout",
                AgentSessionSummaryEndReason.Cancelled => "cancelled",
                AgentSessionSummaryEndReason.ConversationTimeout => "conversation_timeout",
                AgentSessionSummaryEndReason.DialFailed => "dial_failed",
                AgentSessionSummaryEndReason.Escalated => "escalated",
                AgentSessionSummaryEndReason.HeartbeatTimeout => "heartbeat_timeout",
                AgentSessionSummaryEndReason.InternalError => "internal_error",
                AgentSessionSummaryEndReason.LlmEndpointFailure => "llm_endpoint_failure",
                AgentSessionSummaryEndReason.RoomJoinTimeout => "room_join_timeout",
                AgentSessionSummaryEndReason.UserHangup => "user_hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryEndReason? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => AgentSessionSummaryEndReason.AgentHangup,
                "agent_join_timeout" => AgentSessionSummaryEndReason.AgentJoinTimeout,
                "cancelled" => AgentSessionSummaryEndReason.Cancelled,
                "conversation_timeout" => AgentSessionSummaryEndReason.ConversationTimeout,
                "dial_failed" => AgentSessionSummaryEndReason.DialFailed,
                "escalated" => AgentSessionSummaryEndReason.Escalated,
                "heartbeat_timeout" => AgentSessionSummaryEndReason.HeartbeatTimeout,
                "internal_error" => AgentSessionSummaryEndReason.InternalError,
                "llm_endpoint_failure" => AgentSessionSummaryEndReason.LlmEndpointFailure,
                "room_join_timeout" => AgentSessionSummaryEndReason.RoomJoinTimeout,
                "user_hangup" => AgentSessionSummaryEndReason.UserHangup,
                _ => null,
            };
        }
    }
}