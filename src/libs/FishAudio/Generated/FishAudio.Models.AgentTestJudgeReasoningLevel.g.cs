
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestJudgeReasoningLevel
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        VeryHigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestJudgeReasoningLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestJudgeReasoningLevel value)
        {
            return value switch
            {
                AgentTestJudgeReasoningLevel.High => "high",
                AgentTestJudgeReasoningLevel.Low => "low",
                AgentTestJudgeReasoningLevel.Medium => "medium",
                AgentTestJudgeReasoningLevel.Off => "off",
                AgentTestJudgeReasoningLevel.VeryHigh => "very_high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestJudgeReasoningLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentTestJudgeReasoningLevel.High,
                "low" => AgentTestJudgeReasoningLevel.Low,
                "medium" => AgentTestJudgeReasoningLevel.Medium,
                "off" => AgentTestJudgeReasoningLevel.Off,
                "very_high" => AgentTestJudgeReasoningLevel.VeryHigh,
                _ => null,
            };
        }
    }
}