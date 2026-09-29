
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunSummaryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Passed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestRunSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunSummaryStatus value)
        {
            return value switch
            {
                PublicAgentTestRunSummaryStatus.Error => "error",
                PublicAgentTestRunSummaryStatus.Failed => "failed",
                PublicAgentTestRunSummaryStatus.Passed => "passed",
                PublicAgentTestRunSummaryStatus.Queued => "queued",
                PublicAgentTestRunSummaryStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublicAgentTestRunSummaryStatus.Error,
                "failed" => PublicAgentTestRunSummaryStatus.Failed,
                "passed" => PublicAgentTestRunSummaryStatus.Passed,
                "queued" => PublicAgentTestRunSummaryStatus.Queued,
                "running" => PublicAgentTestRunSummaryStatus.Running,
                _ => null,
            };
        }
    }
}