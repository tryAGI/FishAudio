
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentConversationPatchInterruptionSensitivity2
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentConversationPatchInterruptionSensitivity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentConversationPatchInterruptionSensitivity2 value)
        {
            return value switch
            {
                PublicAgentConversationPatchInterruptionSensitivity2.Balanced => "balanced",
                PublicAgentConversationPatchInterruptionSensitivity2.High => "high",
                PublicAgentConversationPatchInterruptionSensitivity2.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentConversationPatchInterruptionSensitivity2? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => PublicAgentConversationPatchInterruptionSensitivity2.Balanced,
                "high" => PublicAgentConversationPatchInterruptionSensitivity2.High,
                "low" => PublicAgentConversationPatchInterruptionSensitivity2.Low,
                _ => null,
            };
        }
    }
}