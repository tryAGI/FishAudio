
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionCreatePayloadLanguage2
    {
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionCreatePayloadLanguage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionCreatePayloadLanguage2 value)
        {
            return value switch
            {
                AgentSessionCreatePayloadLanguage2.De => "de",
                AgentSessionCreatePayloadLanguage2.En => "en",
                AgentSessionCreatePayloadLanguage2.Es => "es",
                AgentSessionCreatePayloadLanguage2.Fr => "fr",
                AgentSessionCreatePayloadLanguage2.Ja => "ja",
                AgentSessionCreatePayloadLanguage2.Ko => "ko",
                AgentSessionCreatePayloadLanguage2.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionCreatePayloadLanguage2? ToEnum(string value)
        {
            return value switch
            {
                "de" => AgentSessionCreatePayloadLanguage2.De,
                "en" => AgentSessionCreatePayloadLanguage2.En,
                "es" => AgentSessionCreatePayloadLanguage2.Es,
                "fr" => AgentSessionCreatePayloadLanguage2.Fr,
                "ja" => AgentSessionCreatePayloadLanguage2.Ja,
                "ko" => AgentSessionCreatePayloadLanguage2.Ko,
                "zh" => AgentSessionCreatePayloadLanguage2.Zh,
                _ => null,
            };
        }
    }
}