
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSessionsResponseDialStatus
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
    public static class GetAgentSessionsResponseDialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseDialStatus value)
        {
            return value switch
            {
                GetAgentSessionsResponseDialStatus.Answered => "answered",
                GetAgentSessionsResponseDialStatus.Busy => "busy",
                GetAgentSessionsResponseDialStatus.Failed => "failed",
                GetAgentSessionsResponseDialStatus.NoAnswer => "no_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseDialStatus? ToEnum(string value)
        {
            return value switch
            {
                "answered" => GetAgentSessionsResponseDialStatus.Answered,
                "busy" => GetAgentSessionsResponseDialStatus.Busy,
                "failed" => GetAgentSessionsResponseDialStatus.Failed,
                "no_answer" => GetAgentSessionsResponseDialStatus.NoAnswer,
                _ => null,
            };
        }
    }
}