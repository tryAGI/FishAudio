
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunStatus
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
    public static class PublicAgentTestRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunStatus value)
        {
            return value switch
            {
                PublicAgentTestRunStatus.Error => "error",
                PublicAgentTestRunStatus.Failed => "failed",
                PublicAgentTestRunStatus.Passed => "passed",
                PublicAgentTestRunStatus.Queued => "queued",
                PublicAgentTestRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublicAgentTestRunStatus.Error,
                "failed" => PublicAgentTestRunStatus.Failed,
                "passed" => PublicAgentTestRunStatus.Passed,
                "queued" => PublicAgentTestRunStatus.Queued,
                "running" => PublicAgentTestRunStatus.Running,
                _ => null,
            };
        }
    }
}