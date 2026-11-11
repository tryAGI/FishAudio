
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentToolPreToolSpeechMode
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolPreToolSpeechModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolPreToolSpeechMode value)
        {
            return value switch
            {
                AgentToolPreToolSpeechMode.Auto => "auto",
                AgentToolPreToolSpeechMode.Off => "off",
                AgentToolPreToolSpeechMode.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolPreToolSpeechMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AgentToolPreToolSpeechMode.Auto,
                "off" => AgentToolPreToolSpeechMode.Off,
                "static" => AgentToolPreToolSpeechMode.Static,
                _ => null,
            };
        }
    }
}