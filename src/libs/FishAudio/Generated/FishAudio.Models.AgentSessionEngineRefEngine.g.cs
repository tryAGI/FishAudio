
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionEngineRefEngine
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
    public static class AgentSessionEngineRefEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionEngineRefEngine value)
        {
            return value switch
            {
                AgentSessionEngineRefEngine.FishTts => "fish_tts",
                AgentSessionEngineRefEngine.Live3 => "live3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionEngineRefEngine? ToEnum(string value)
        {
            return value switch
            {
                "fish_tts" => AgentSessionEngineRefEngine.FishTts,
                "live3" => AgentSessionEngineRefEngine.Live3,
                _ => null,
            };
        }
    }
}