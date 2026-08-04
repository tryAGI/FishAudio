
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentVoicePatchSpeakingLanguage2
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
    public static class PublicAgentVoicePatchSpeakingLanguage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoicePatchSpeakingLanguage2 value)
        {
            return value switch
            {
                PublicAgentVoicePatchSpeakingLanguage2.De => "de",
                PublicAgentVoicePatchSpeakingLanguage2.En => "en",
                PublicAgentVoicePatchSpeakingLanguage2.Es => "es",
                PublicAgentVoicePatchSpeakingLanguage2.Fr => "fr",
                PublicAgentVoicePatchSpeakingLanguage2.Ja => "ja",
                PublicAgentVoicePatchSpeakingLanguage2.Ko => "ko",
                PublicAgentVoicePatchSpeakingLanguage2.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoicePatchSpeakingLanguage2? ToEnum(string value)
        {
            return value switch
            {
                "de" => PublicAgentVoicePatchSpeakingLanguage2.De,
                "en" => PublicAgentVoicePatchSpeakingLanguage2.En,
                "es" => PublicAgentVoicePatchSpeakingLanguage2.Es,
                "fr" => PublicAgentVoicePatchSpeakingLanguage2.Fr,
                "ja" => PublicAgentVoicePatchSpeakingLanguage2.Ja,
                "ko" => PublicAgentVoicePatchSpeakingLanguage2.Ko,
                "zh" => PublicAgentVoicePatchSpeakingLanguage2.Zh,
                _ => null,
            };
        }
    }
}