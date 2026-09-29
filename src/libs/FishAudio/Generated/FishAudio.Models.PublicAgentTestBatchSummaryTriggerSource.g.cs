
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Where the batch was started: the console or the API.
    /// </summary>
    public enum PublicAgentTestBatchSummaryTriggerSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        /// the console or the API.
        /// </summary>
        Console,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestBatchSummaryTriggerSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestBatchSummaryTriggerSource value)
        {
            return value switch
            {
                PublicAgentTestBatchSummaryTriggerSource.Api => "api",
                PublicAgentTestBatchSummaryTriggerSource.Console => "console",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestBatchSummaryTriggerSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => PublicAgentTestBatchSummaryTriggerSource.Api,
                "console" => PublicAgentTestBatchSummaryTriggerSource.Console,
                _ => null,
            };
        }
    }
}