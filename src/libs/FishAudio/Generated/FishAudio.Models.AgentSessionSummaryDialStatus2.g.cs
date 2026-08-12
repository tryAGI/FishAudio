
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionSummaryDialStatus2
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
    public static class AgentSessionSummaryDialStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryDialStatus2 value)
        {
            return value switch
            {
                AgentSessionSummaryDialStatus2.Answered => "answered",
                AgentSessionSummaryDialStatus2.Busy => "busy",
                AgentSessionSummaryDialStatus2.Failed => "failed",
                AgentSessionSummaryDialStatus2.NoAnswer => "no_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryDialStatus2? ToEnum(string value)
        {
            return value switch
            {
                "answered" => AgentSessionSummaryDialStatus2.Answered,
                "busy" => AgentSessionSummaryDialStatus2.Busy,
                "failed" => AgentSessionSummaryDialStatus2.Failed,
                "no_answer" => AgentSessionSummaryDialStatus2.NoAnswer,
                _ => null,
            };
        }
    }
}