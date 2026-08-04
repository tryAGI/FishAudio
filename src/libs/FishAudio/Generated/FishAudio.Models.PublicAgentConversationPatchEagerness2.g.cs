
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentConversationPatchEagerness2
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
    public static class PublicAgentConversationPatchEagerness2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentConversationPatchEagerness2 value)
        {
            return value switch
            {
                PublicAgentConversationPatchEagerness2.Balanced => "balanced",
                PublicAgentConversationPatchEagerness2.Eager => "eager",
                PublicAgentConversationPatchEagerness2.Relaxed => "relaxed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentConversationPatchEagerness2? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => PublicAgentConversationPatchEagerness2.Balanced,
                "eager" => PublicAgentConversationPatchEagerness2.Eager,
                "relaxed" => PublicAgentConversationPatchEagerness2.Relaxed,
                _ => null,
            };
        }
    }
}