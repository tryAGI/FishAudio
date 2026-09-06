
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentConversationPatchEagerness
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Eager,
        /// <summary>
        ///
        /// </summary>
        Relaxed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentConversationPatchEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentConversationPatchEagerness value)
        {
            return value switch
            {
                PublicAgentConversationPatchEagerness.Balanced => "balanced",
                PublicAgentConversationPatchEagerness.Eager => "eager",
                PublicAgentConversationPatchEagerness.Relaxed => "relaxed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentConversationPatchEagerness? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => PublicAgentConversationPatchEagerness.Balanced,
                "eager" => PublicAgentConversationPatchEagerness.Eager,
                "relaxed" => PublicAgentConversationPatchEagerness.Relaxed,
                _ => null,
            };
        }
    }
}