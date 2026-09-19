
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSessionsResponseEndReason
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
    public static class GetAgentSessionsResponseEndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseEndReason value)
        {
            return value switch
            {
                GetAgentSessionsResponseEndReason.AgentHangup => "agent_hangup",
                GetAgentSessionsResponseEndReason.AgentJoinTimeout => "agent_join_timeout",
                GetAgentSessionsResponseEndReason.Cancelled => "cancelled",
                GetAgentSessionsResponseEndReason.ConversationTimeout => "conversation_timeout",
                GetAgentSessionsResponseEndReason.DialFailed => "dial_failed",
                GetAgentSessionsResponseEndReason.Escalated => "escalated",
                GetAgentSessionsResponseEndReason.HeartbeatTimeout => "heartbeat_timeout",
                GetAgentSessionsResponseEndReason.InternalError => "internal_error",
                GetAgentSessionsResponseEndReason.LlmEndpointFailure => "llm_endpoint_failure",
                GetAgentSessionsResponseEndReason.RoomJoinTimeout => "room_join_timeout",
                GetAgentSessionsResponseEndReason.UserHangup => "user_hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseEndReason? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => GetAgentSessionsResponseEndReason.AgentHangup,
                "agent_join_timeout" => GetAgentSessionsResponseEndReason.AgentJoinTimeout,
                "cancelled" => GetAgentSessionsResponseEndReason.Cancelled,
                "conversation_timeout" => GetAgentSessionsResponseEndReason.ConversationTimeout,
                "dial_failed" => GetAgentSessionsResponseEndReason.DialFailed,
                "escalated" => GetAgentSessionsResponseEndReason.Escalated,
                "heartbeat_timeout" => GetAgentSessionsResponseEndReason.HeartbeatTimeout,
                "internal_error" => GetAgentSessionsResponseEndReason.InternalError,
                "llm_endpoint_failure" => GetAgentSessionsResponseEndReason.LlmEndpointFailure,
                "room_join_timeout" => GetAgentSessionsResponseEndReason.RoomJoinTimeout,
                "user_hangup" => GetAgentSessionsResponseEndReason.UserHangup,
                _ => null,
            };
        }
    }
}