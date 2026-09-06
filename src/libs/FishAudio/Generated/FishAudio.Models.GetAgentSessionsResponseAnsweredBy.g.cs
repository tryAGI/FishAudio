
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSessionsResponseAnsweredBy
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
    public static class GetAgentSessionsResponseAnsweredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseAnsweredBy value)
        {
            return value switch
            {
                GetAgentSessionsResponseAnsweredBy.Human => "human",
                GetAgentSessionsResponseAnsweredBy.Unknown => "unknown",
                GetAgentSessionsResponseAnsweredBy.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseAnsweredBy? ToEnum(string value)
        {
            return value switch
            {
                "human" => GetAgentSessionsResponseAnsweredBy.Human,
                "unknown" => GetAgentSessionsResponseAnsweredBy.Unknown,
                "voicemail" => GetAgentSessionsResponseAnsweredBy.Voicemail,
                _ => null,
            };
        }
    }
}