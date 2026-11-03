
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: platform
    /// </summary>
    public enum AgentLLMFallbackRedactedMode
    {
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentLLMFallbackRedactedModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMFallbackRedactedMode value)
        {
            return value switch
            {
                AgentLLMFallbackRedactedMode.Manual => "manual",
                AgentLLMFallbackRedactedMode.Off => "off",
                AgentLLMFallbackRedactedMode.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMFallbackRedactedMode? ToEnum(string value)
        {
            return value switch
            {
                "manual" => AgentLLMFallbackRedactedMode.Manual,
                "off" => AgentLLMFallbackRedactedMode.Off,
                "platform" => AgentLLMFallbackRedactedMode.Platform,
                _ => null,
            };
        }
    }
}