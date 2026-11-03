
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentLLMFallbackMode
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
    public static class PublicAgentLLMFallbackModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentLLMFallbackMode value)
        {
            return value switch
            {
                PublicAgentLLMFallbackMode.Manual => "manual",
                PublicAgentLLMFallbackMode.Off => "off",
                PublicAgentLLMFallbackMode.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentLLMFallbackMode? ToEnum(string value)
        {
            return value switch
            {
                "manual" => PublicAgentLLMFallbackMode.Manual,
                "off" => PublicAgentLLMFallbackMode.Off,
                "platform" => PublicAgentLLMFallbackMode.Platform,
                _ => null,
            };
        }
    }
}