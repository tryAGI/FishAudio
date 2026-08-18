
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: medium
    /// </summary>
    public enum AgentLLMConfigRedactedTier
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
    public static class AgentLLMConfigRedactedTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMConfigRedactedTier value)
        {
            return value switch
            {
                AgentLLMConfigRedactedTier.High => "high",
                AgentLLMConfigRedactedTier.Instant => "instant",
                AgentLLMConfigRedactedTier.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMConfigRedactedTier? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentLLMConfigRedactedTier.High,
                "instant" => AgentLLMConfigRedactedTier.Instant,
                "medium" => AgentLLMConfigRedactedTier.Medium,
                _ => null,
            };
        }
    }
}