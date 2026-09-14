
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum LLMMessageTokenCostCategory
    {
        /// <summary>
        ///
        /// </summary>
        CacheRead,
        /// <summary>
        ///
        /// </summary>
        CacheWrite1h,
        /// <summary>
        ///
        /// </summary>
        CacheWrite5m,
        /// <summary>
        ///
        /// </summary>
        Input,
        /// <summary>
        ///
        /// </summary>
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMMessageTokenCostCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMMessageTokenCostCategory value)
        {
            return value switch
            {
                LLMMessageTokenCostCategory.CacheRead => "cache_read",
                LLMMessageTokenCostCategory.CacheWrite1h => "cache_write_1h",
                LLMMessageTokenCostCategory.CacheWrite5m => "cache_write_5m",
                LLMMessageTokenCostCategory.Input => "input",
                LLMMessageTokenCostCategory.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMMessageTokenCostCategory? ToEnum(string value)
        {
            return value switch
            {
                "cache_read" => LLMMessageTokenCostCategory.CacheRead,
                "cache_write_1h" => LLMMessageTokenCostCategory.CacheWrite1h,
                "cache_write_5m" => LLMMessageTokenCostCategory.CacheWrite5m,
                "input" => LLMMessageTokenCostCategory.Input,
                "output" => LLMMessageTokenCostCategory.Output,
                _ => null,
            };
        }
    }
}