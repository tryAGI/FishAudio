
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentLLMPatchTier2
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Instant,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentLLMPatchTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentLLMPatchTier2 value)
        {
            return value switch
            {
                PublicAgentLLMPatchTier2.High => "high",
                PublicAgentLLMPatchTier2.Instant => "instant",
                PublicAgentLLMPatchTier2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentLLMPatchTier2? ToEnum(string value)
        {
            return value switch
            {
                "high" => PublicAgentLLMPatchTier2.High,
                "instant" => PublicAgentLLMPatchTier2.Instant,
                "medium" => PublicAgentLLMPatchTier2.Medium,
                _ => null,
            };
        }
    }
}