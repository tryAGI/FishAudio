
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionSummaryDialStatus
    {
        /// <summary>
        ///
        /// </summary>
        Answered,
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
    public static class AgentSessionSummaryDialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryDialStatus value)
        {
            return value switch
            {
                AgentSessionSummaryDialStatus.Answered => "answered",
                AgentSessionSummaryDialStatus.Busy => "busy",
                AgentSessionSummaryDialStatus.Failed => "failed",
                AgentSessionSummaryDialStatus.NoAnswer => "no_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryDialStatus? ToEnum(string value)
        {
            return value switch
            {
                "answered" => AgentSessionSummaryDialStatus.Answered,
                "busy" => AgentSessionSummaryDialStatus.Busy,
                "failed" => AgentSessionSummaryDialStatus.Failed,
                "no_answer" => AgentSessionSummaryDialStatus.NoAnswer,
                _ => null,
            };
        }
    }
}