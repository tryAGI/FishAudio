
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemConsultEndReason
    {
        /// <summary>
        ///
        /// </summary>
        ConnectionLost,
        /// <summary>
        ///
        /// </summary>
        TransferTargetHangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferItemConsultEndReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemConsultEndReason value)
        {
            return value switch
            {
                AgentSessionTransferItemConsultEndReason.ConnectionLost => "connection_lost",
                AgentSessionTransferItemConsultEndReason.TransferTargetHangup => "transfer_target_hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemConsultEndReason? ToEnum(string value)
        {
            return value switch
            {
                "connection_lost" => AgentSessionTransferItemConsultEndReason.ConnectionLost,
                "transfer_target_hangup" => AgentSessionTransferItemConsultEndReason.TransferTargetHangup,
                _ => null,
            };
        }
    }
}