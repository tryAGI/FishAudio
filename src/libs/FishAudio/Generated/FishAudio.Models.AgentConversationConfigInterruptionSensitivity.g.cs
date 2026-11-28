
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How much caller speech counts as an interruption while the agent speaks. With `low` the agent stops only for a firm, worded interjection and talks through background noise and short acknowledgements. `balanced` (default) interrupts on normal speech. With `high` the agent stops on the caller's first word. With `immediate` the agent stops at the caller's first sound, so backchannels such as "okay" and "yeah" stop it too, and it picks up where it stopped when the caller was only backchanneling or did not take the turn. `immediate` is only available to teams it has been enabled for, other teams get a 403 when they set it.<br/>
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
        Immediate,
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
                AgentConversationConfigInterruptionSensitivity.Immediate => "immediate",
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
                "immediate" => AgentConversationConfigInterruptionSensitivity.Immediate,
                "low" => AgentConversationConfigInterruptionSensitivity.Low,
                _ => null,
            };
        }
    }
}