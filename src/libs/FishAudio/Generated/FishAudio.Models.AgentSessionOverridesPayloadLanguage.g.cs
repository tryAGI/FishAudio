
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionOverridesPayloadLanguage
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
    public static class AgentSessionOverridesPayloadLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionOverridesPayloadLanguage value)
        {
            return value switch
            {
                AgentSessionOverridesPayloadLanguage.De => "de",
                AgentSessionOverridesPayloadLanguage.En => "en",
                AgentSessionOverridesPayloadLanguage.Es => "es",
                AgentSessionOverridesPayloadLanguage.Fr => "fr",
                AgentSessionOverridesPayloadLanguage.Ja => "ja",
                AgentSessionOverridesPayloadLanguage.Ko => "ko",
                AgentSessionOverridesPayloadLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionOverridesPayloadLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => AgentSessionOverridesPayloadLanguage.De,
                "en" => AgentSessionOverridesPayloadLanguage.En,
                "es" => AgentSessionOverridesPayloadLanguage.Es,
                "fr" => AgentSessionOverridesPayloadLanguage.Fr,
                "ja" => AgentSessionOverridesPayloadLanguage.Ja,
                "ko" => AgentSessionOverridesPayloadLanguage.Ko,
                "zh" => AgentSessionOverridesPayloadLanguage.Zh,
                _ => null,
            };
        }
    }
}