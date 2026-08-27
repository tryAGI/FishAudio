
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: prompt
    /// </summary>
    public enum AgentPromptConfigFirstMessageMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPromptConfigFirstMessageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPromptConfigFirstMessageMode value)
        {
            return value switch
            {
                AgentPromptConfigFirstMessageMode.Fixed => "fixed",
                AgentPromptConfigFirstMessageMode.Off => "off",
                AgentPromptConfigFirstMessageMode.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPromptConfigFirstMessageMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentPromptConfigFirstMessageMode.Fixed,
                "off" => AgentPromptConfigFirstMessageMode.Off,
                "prompt" => AgentPromptConfigFirstMessageMode.Prompt,
                _ => null,
            };
        }
    }
}