
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionOverridesPayloadLanguage2
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
    public static class AgentSessionOverridesPayloadLanguage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionOverridesPayloadLanguage2 value)
        {
            return value switch
            {
                AgentSessionOverridesPayloadLanguage2.De => "de",
                AgentSessionOverridesPayloadLanguage2.En => "en",
                AgentSessionOverridesPayloadLanguage2.Es => "es",
                AgentSessionOverridesPayloadLanguage2.Fr => "fr",
                AgentSessionOverridesPayloadLanguage2.Ja => "ja",
                AgentSessionOverridesPayloadLanguage2.Ko => "ko",
                AgentSessionOverridesPayloadLanguage2.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionOverridesPayloadLanguage2? ToEnum(string value)
        {
            return value switch
            {
                "de" => AgentSessionOverridesPayloadLanguage2.De,
                "en" => AgentSessionOverridesPayloadLanguage2.En,
                "es" => AgentSessionOverridesPayloadLanguage2.Es,
                "fr" => AgentSessionOverridesPayloadLanguage2.Fr,
                "ja" => AgentSessionOverridesPayloadLanguage2.Ja,
                "ko" => AgentSessionOverridesPayloadLanguage2.Ko,
                "zh" => AgentSessionOverridesPayloadLanguage2.Zh,
                _ => null,
            };
        }
    }
}