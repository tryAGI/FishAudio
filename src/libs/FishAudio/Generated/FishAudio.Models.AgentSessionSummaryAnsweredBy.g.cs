
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionSummaryAnsweredBy
    {
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionSummaryAnsweredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryAnsweredBy value)
        {
            return value switch
            {
                AgentSessionSummaryAnsweredBy.Human => "human",
                AgentSessionSummaryAnsweredBy.Unknown => "unknown",
                AgentSessionSummaryAnsweredBy.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryAnsweredBy? ToEnum(string value)
        {
            return value switch
            {
                "human" => AgentSessionSummaryAnsweredBy.Human,
                "unknown" => AgentSessionSummaryAnsweredBy.Unknown,
                "voicemail" => AgentSessionSummaryAnsweredBy.Voicemail,
                _ => null,
            };
        }
    }
}