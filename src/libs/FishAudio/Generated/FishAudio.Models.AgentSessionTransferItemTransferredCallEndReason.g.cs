
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemTransferredCallEndReason
    {
        /// <summary>
        ///
        /// </summary>
        CallerHangup,
        /// <summary>
        ///
        /// </summary>
        ConnectionLost,
        /// <summary>
        ///
        /// </summary>
        ConversationTimeout,
        /// <summary>
        ///
        /// </summary>
        TransferTargetHangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferItemTransferredCallEndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemTransferredCallEndReason value)
        {
            return value switch
            {
                AgentSessionTransferItemTransferredCallEndReason.CallerHangup => "caller_hangup",
                AgentSessionTransferItemTransferredCallEndReason.ConnectionLost => "connection_lost",
                AgentSessionTransferItemTransferredCallEndReason.ConversationTimeout => "conversation_timeout",
                AgentSessionTransferItemTransferredCallEndReason.TransferTargetHangup => "transfer_target_hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemTransferredCallEndReason? ToEnum(string value)
        {
            return value switch
            {
                "caller_hangup" => AgentSessionTransferItemTransferredCallEndReason.CallerHangup,
                "connection_lost" => AgentSessionTransferItemTransferredCallEndReason.ConnectionLost,
                "conversation_timeout" => AgentSessionTransferItemTransferredCallEndReason.ConversationTimeout,
                "transfer_target_hangup" => AgentSessionTransferItemTransferredCallEndReason.TransferTargetHangup,
                _ => null,
            };
        }
    }
}