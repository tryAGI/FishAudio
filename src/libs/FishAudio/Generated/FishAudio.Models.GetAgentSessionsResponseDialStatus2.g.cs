
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSessionsResponseDialStatus2
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
    public static class GetAgentSessionsResponseDialStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseDialStatus2 value)
        {
            return value switch
            {
                GetAgentSessionsResponseDialStatus2.Answered => "answered",
                GetAgentSessionsResponseDialStatus2.Busy => "busy",
                GetAgentSessionsResponseDialStatus2.Failed => "failed",
                GetAgentSessionsResponseDialStatus2.NoAnswer => "no_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseDialStatus2? ToEnum(string value)
        {
            return value switch
            {
                "answered" => GetAgentSessionsResponseDialStatus2.Answered,
                "busy" => GetAgentSessionsResponseDialStatus2.Busy,
                "failed" => GetAgentSessionsResponseDialStatus2.Failed,
                "no_answer" => GetAgentSessionsResponseDialStatus2.NoAnswer,
                _ => null,
            };
        }
    }
}