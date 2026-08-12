
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentSessionsResponseAnsweredBy2
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
    public static class GetAgentSessionsResponseAnsweredBy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseAnsweredBy2 value)
        {
            return value switch
            {
                GetAgentSessionsResponseAnsweredBy2.Human => "human",
                GetAgentSessionsResponseAnsweredBy2.Unknown => "unknown",
                GetAgentSessionsResponseAnsweredBy2.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseAnsweredBy2? ToEnum(string value)
        {
            return value switch
            {
                "human" => GetAgentSessionsResponseAnsweredBy2.Human,
                "unknown" => GetAgentSessionsResponseAnsweredBy2.Unknown,
                "voicemail" => GetAgentSessionsResponseAnsweredBy2.Voicemail,
                _ => null,
            };
        }
    }
}