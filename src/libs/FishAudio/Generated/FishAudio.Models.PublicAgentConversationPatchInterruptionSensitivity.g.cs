
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentConversationPatchInterruptionSensitivity
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
    public static class PublicAgentConversationPatchInterruptionSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentConversationPatchInterruptionSensitivity value)
        {
            return value switch
            {
                PublicAgentConversationPatchInterruptionSensitivity.Balanced => "balanced",
                PublicAgentConversationPatchInterruptionSensitivity.High => "high",
                PublicAgentConversationPatchInterruptionSensitivity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentConversationPatchInterruptionSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => PublicAgentConversationPatchInterruptionSensitivity.Balanced,
                "high" => PublicAgentConversationPatchInterruptionSensitivity.High,
                "low" => PublicAgentConversationPatchInterruptionSensitivity.Low,
                _ => null,
            };
        }
    }
}