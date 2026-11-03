
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: s2.1-pro
    /// </summary>
    public enum PublicAgentVoiceConfigTtsModel
    {
        /// <summary>
        ///
        /// </summary>
        Drama3,
        /// <summary>
        ///
        /// </summary>
        S21Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVoiceConfigTtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoiceConfigTtsModel value)
        {
            return value switch
            {
                PublicAgentVoiceConfigTtsModel.Drama3 => "drama-3",
                PublicAgentVoiceConfigTtsModel.S21Pro => "s2.1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoiceConfigTtsModel? ToEnum(string value)
        {
            return value switch
            {
                "drama-3" => PublicAgentVoiceConfigTtsModel.Drama3,
                "s2.1-pro" => PublicAgentVoiceConfigTtsModel.S21Pro,
                _ => null,
            };
        }
    }
}