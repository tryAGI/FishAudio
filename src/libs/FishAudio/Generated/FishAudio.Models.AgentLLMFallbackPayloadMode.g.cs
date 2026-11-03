
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentLLMFallbackPayloadMode
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
    public static class AgentLLMFallbackPayloadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMFallbackPayloadMode value)
        {
            return value switch
            {
                AgentLLMFallbackPayloadMode.Manual => "manual",
                AgentLLMFallbackPayloadMode.Off => "off",
                AgentLLMFallbackPayloadMode.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMFallbackPayloadMode? ToEnum(string value)
        {
            return value switch
            {
                "manual" => AgentLLMFallbackPayloadMode.Manual,
                "off" => AgentLLMFallbackPayloadMode.Off,
                "platform" => AgentLLMFallbackPayloadMode.Platform,
                _ => null,
            };
        }
    }
}