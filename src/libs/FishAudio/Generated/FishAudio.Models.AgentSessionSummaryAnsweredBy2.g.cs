
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionSummaryAnsweredBy2
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
    public static class AgentSessionSummaryAnsweredBy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryAnsweredBy2 value)
        {
            return value switch
            {
                AgentSessionSummaryAnsweredBy2.Human => "human",
                AgentSessionSummaryAnsweredBy2.Unknown => "unknown",
                AgentSessionSummaryAnsweredBy2.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryAnsweredBy2? ToEnum(string value)
        {
            return value switch
            {
                "human" => AgentSessionSummaryAnsweredBy2.Human,
                "unknown" => AgentSessionSummaryAnsweredBy2.Unknown,
                "voicemail" => AgentSessionSummaryAnsweredBy2.Voicemail,
                _ => null,
            };
        }
    }
}