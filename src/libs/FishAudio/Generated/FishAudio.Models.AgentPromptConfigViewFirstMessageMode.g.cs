
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: prompt
    /// </summary>
    public enum AgentPromptConfigViewFirstMessageMode
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
    public static class AgentPromptConfigViewFirstMessageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPromptConfigViewFirstMessageMode value)
        {
            return value switch
            {
                AgentPromptConfigViewFirstMessageMode.Fixed => "fixed",
                AgentPromptConfigViewFirstMessageMode.Off => "off",
                AgentPromptConfigViewFirstMessageMode.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPromptConfigViewFirstMessageMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentPromptConfigViewFirstMessageMode.Fixed,
                "off" => AgentPromptConfigViewFirstMessageMode.Off,
                "prompt" => AgentPromptConfigViewFirstMessageMode.Prompt,
                _ => null,
            };
        }
    }
}