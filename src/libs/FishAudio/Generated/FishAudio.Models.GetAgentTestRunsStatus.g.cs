
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsStatus
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
    public static class GetAgentTestRunsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsStatus value)
        {
            return value switch
            {
                GetAgentTestRunsStatus.Error => "error",
                GetAgentTestRunsStatus.Failed => "failed",
                GetAgentTestRunsStatus.Passed => "passed",
                GetAgentTestRunsStatus.Queued => "queued",
                GetAgentTestRunsStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentTestRunsStatus.Error,
                "failed" => GetAgentTestRunsStatus.Failed,
                "passed" => GetAgentTestRunsStatus.Passed,
                "queued" => GetAgentTestRunsStatus.Queued,
                "running" => GetAgentTestRunsStatus.Running,
                _ => null,
            };
        }
    }
}