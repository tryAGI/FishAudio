
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: s2.1-pro
    /// </summary>
    public enum AgentVoiceConfigViewTtsModel
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
    public static class AgentVoiceConfigViewTtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceConfigViewTtsModel value)
        {
            return value switch
            {
                AgentVoiceConfigViewTtsModel.Drama3 => "drama-3",
                AgentVoiceConfigViewTtsModel.S21Pro => "s2.1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceConfigViewTtsModel? ToEnum(string value)
        {
            return value switch
            {
                "drama-3" => AgentVoiceConfigViewTtsModel.Drama3,
                "s2.1-pro" => AgentVoiceConfigViewTtsModel.S21Pro,
                _ => null,
            };
        }
    }
}