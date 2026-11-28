
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicLLMTestJudgeLevelLevel
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
    public static class PublicLLMTestJudgeLevelLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicLLMTestJudgeLevelLevel value)
        {
            return value switch
            {
                PublicLLMTestJudgeLevelLevel.High => "high",
                PublicLLMTestJudgeLevelLevel.Low => "low",
                PublicLLMTestJudgeLevelLevel.Medium => "medium",
                PublicLLMTestJudgeLevelLevel.Off => "off",
                PublicLLMTestJudgeLevelLevel.VeryHigh => "very_high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicLLMTestJudgeLevelLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => PublicLLMTestJudgeLevelLevel.High,
                "low" => PublicLLMTestJudgeLevelLevel.Low,
                "medium" => PublicLLMTestJudgeLevelLevel.Medium,
                "off" => PublicLLMTestJudgeLevelLevel.Off,
                "very_high" => PublicLLMTestJudgeLevelLevel.VeryHigh,
                _ => null,
            };
        }
    }
}