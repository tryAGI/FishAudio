
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentVoicePatchSpeakingLanguage
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
    public static class PublicAgentVoicePatchSpeakingLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoicePatchSpeakingLanguage value)
        {
            return value switch
            {
                PublicAgentVoicePatchSpeakingLanguage.De => "de",
                PublicAgentVoicePatchSpeakingLanguage.En => "en",
                PublicAgentVoicePatchSpeakingLanguage.Es => "es",
                PublicAgentVoicePatchSpeakingLanguage.Fr => "fr",
                PublicAgentVoicePatchSpeakingLanguage.Ja => "ja",
                PublicAgentVoicePatchSpeakingLanguage.Ko => "ko",
                PublicAgentVoicePatchSpeakingLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoicePatchSpeakingLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => PublicAgentVoicePatchSpeakingLanguage.De,
                "en" => PublicAgentVoicePatchSpeakingLanguage.En,
                "es" => PublicAgentVoicePatchSpeakingLanguage.Es,
                "fr" => PublicAgentVoicePatchSpeakingLanguage.Fr,
                "ja" => PublicAgentVoicePatchSpeakingLanguage.Ja,
                "ko" => PublicAgentVoicePatchSpeakingLanguage.Ko,
                "zh" => PublicAgentVoicePatchSpeakingLanguage.Zh,
                _ => null,
            };
        }
    }
}