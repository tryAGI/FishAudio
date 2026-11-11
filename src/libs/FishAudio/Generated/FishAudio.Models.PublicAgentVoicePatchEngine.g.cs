
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentVoicePatchEngine
    {
        /// <summary>
        ///
        /// </summary>
        FishTts,
        /// <summary>
        ///
        /// </summary>
        Live3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVoicePatchEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoicePatchEngine value)
        {
            return value switch
            {
                PublicAgentVoicePatchEngine.FishTts => "fish_tts",
                PublicAgentVoicePatchEngine.Live3 => "live3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoicePatchEngine? ToEnum(string value)
        {
            return value switch
            {
                "fish_tts" => PublicAgentVoicePatchEngine.FishTts,
                "live3" => PublicAgentVoicePatchEngine.Live3,
                _ => null,
            };
        }
    }
}