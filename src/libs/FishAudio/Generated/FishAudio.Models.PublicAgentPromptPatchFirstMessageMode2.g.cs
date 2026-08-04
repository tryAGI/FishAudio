
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentPromptPatchFirstMessageMode2
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
    public static class PublicAgentPromptPatchFirstMessageMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentPromptPatchFirstMessageMode2 value)
        {
            return value switch
            {
                PublicAgentPromptPatchFirstMessageMode2.Fixed => "fixed",
                PublicAgentPromptPatchFirstMessageMode2.Off => "off",
                PublicAgentPromptPatchFirstMessageMode2.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentPromptPatchFirstMessageMode2? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => PublicAgentPromptPatchFirstMessageMode2.Fixed,
                "off" => PublicAgentPromptPatchFirstMessageMode2.Off,
                "prompt" => PublicAgentPromptPatchFirstMessageMode2.Prompt,
                _ => null,
            };
        }
    }
}