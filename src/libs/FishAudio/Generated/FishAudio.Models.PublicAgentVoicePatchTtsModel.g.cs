
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentVoicePatchTtsModel
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
    public static class PublicAgentVoicePatchTtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoicePatchTtsModel value)
        {
            return value switch
            {
                PublicAgentVoicePatchTtsModel.Drama3 => "drama-3",
                PublicAgentVoicePatchTtsModel.S21Pro => "s2.1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoicePatchTtsModel? ToEnum(string value)
        {
            return value switch
            {
                "drama-3" => PublicAgentVoicePatchTtsModel.Drama3,
                "s2.1-pro" => PublicAgentVoicePatchTtsModel.S21Pro,
                _ => null,
            };
        }
    }
}