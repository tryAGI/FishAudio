
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: balanced
    /// </summary>
    public enum AgentConversationConfigInterruptionSensitivity
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
    public static class AgentConversationConfigInterruptionSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationConfigInterruptionSensitivity value)
        {
            return value switch
            {
                AgentConversationConfigInterruptionSensitivity.Balanced => "balanced",
                AgentConversationConfigInterruptionSensitivity.High => "high",
                AgentConversationConfigInterruptionSensitivity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationConfigInterruptionSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => AgentConversationConfigInterruptionSensitivity.Balanced,
                "high" => AgentConversationConfigInterruptionSensitivity.High,
                "low" => AgentConversationConfigInterruptionSensitivity.Low,
                _ => null,
            };
        }
    }
}