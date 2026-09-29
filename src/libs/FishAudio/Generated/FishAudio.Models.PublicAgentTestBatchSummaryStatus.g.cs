
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// running until every run has finished.
    /// </summary>
    public enum PublicAgentTestBatchSummaryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestBatchSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestBatchSummaryStatus value)
        {
            return value switch
            {
                PublicAgentTestBatchSummaryStatus.Completed => "completed",
                PublicAgentTestBatchSummaryStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestBatchSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PublicAgentTestBatchSummaryStatus.Completed,
                "running" => PublicAgentTestBatchSummaryStatus.Running,
                _ => null,
            };
        }
    }
}