
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum LLMMessageUsageStatus
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMMessageUsageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMMessageUsageStatus value)
        {
            return value switch
            {
                LLMMessageUsageStatus.Complete => "complete",
                LLMMessageUsageStatus.Pending => "pending",
                LLMMessageUsageStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMMessageUsageStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => LLMMessageUsageStatus.Complete,
                "pending" => LLMMessageUsageStatus.Pending,
                "unavailable" => LLMMessageUsageStatus.Unavailable,
                _ => null,
            };
        }
    }
}