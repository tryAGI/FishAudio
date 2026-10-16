
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemDialStatus
    {
        /// <summary>
        ///
        /// </summary>
        Busy,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NoAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferItemDialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemDialStatus value)
        {
            return value switch
            {
                AgentSessionTransferItemDialStatus.Busy => "busy",
                AgentSessionTransferItemDialStatus.Failed => "failed",
                AgentSessionTransferItemDialStatus.NoAnswer => "no_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemDialStatus? ToEnum(string value)
        {
            return value switch
            {
                "busy" => AgentSessionTransferItemDialStatus.Busy,
                "failed" => AgentSessionTransferItemDialStatus.Failed,
                "no_answer" => AgentSessionTransferItemDialStatus.NoAnswer,
                _ => null,
            };
        }
    }
}