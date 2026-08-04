
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: en
    /// </summary>
    public enum AgentVoiceConfigSpeakingLanguage
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
    public static class AgentVoiceConfigSpeakingLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceConfigSpeakingLanguage value)
        {
            return value switch
            {
                AgentVoiceConfigSpeakingLanguage.De => "de",
                AgentVoiceConfigSpeakingLanguage.En => "en",
                AgentVoiceConfigSpeakingLanguage.Es => "es",
                AgentVoiceConfigSpeakingLanguage.Fr => "fr",
                AgentVoiceConfigSpeakingLanguage.Ja => "ja",
                AgentVoiceConfigSpeakingLanguage.Ko => "ko",
                AgentVoiceConfigSpeakingLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceConfigSpeakingLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => AgentVoiceConfigSpeakingLanguage.De,
                "en" => AgentVoiceConfigSpeakingLanguage.En,
                "es" => AgentVoiceConfigSpeakingLanguage.Es,
                "fr" => AgentVoiceConfigSpeakingLanguage.Fr,
                "ja" => AgentVoiceConfigSpeakingLanguage.Ja,
                "ko" => AgentVoiceConfigSpeakingLanguage.Ko,
                "zh" => AgentVoiceConfigSpeakingLanguage.Zh,
                _ => null,
            };
        }
    }
}