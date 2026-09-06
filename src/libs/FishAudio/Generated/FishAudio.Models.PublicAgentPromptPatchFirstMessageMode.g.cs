
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentPromptPatchFirstMessageMode
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
    public static class PublicAgentPromptPatchFirstMessageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentPromptPatchFirstMessageMode value)
        {
            return value switch
            {
                PublicAgentPromptPatchFirstMessageMode.Fixed => "fixed",
                PublicAgentPromptPatchFirstMessageMode.Off => "off",
                PublicAgentPromptPatchFirstMessageMode.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentPromptPatchFirstMessageMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => PublicAgentPromptPatchFirstMessageMode.Fixed,
                "off" => PublicAgentPromptPatchFirstMessageMode.Off,
                "prompt" => PublicAgentPromptPatchFirstMessageMode.Prompt,
                _ => null,
            };
        }
    }
}