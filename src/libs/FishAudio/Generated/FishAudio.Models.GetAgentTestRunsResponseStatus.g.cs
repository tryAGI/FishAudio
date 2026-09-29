
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsResponseStatus
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
    public static class GetAgentTestRunsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsResponseStatus value)
        {
            return value switch
            {
                GetAgentTestRunsResponseStatus.Error => "error",
                GetAgentTestRunsResponseStatus.Failed => "failed",
                GetAgentTestRunsResponseStatus.Passed => "passed",
                GetAgentTestRunsResponseStatus.Queued => "queued",
                GetAgentTestRunsResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentTestRunsResponseStatus.Error,
                "failed" => GetAgentTestRunsResponseStatus.Failed,
                "passed" => GetAgentTestRunsResponseStatus.Passed,
                "queued" => GetAgentTestRunsResponseStatus.Queued,
                "running" => GetAgentTestRunsResponseStatus.Running,
                _ => null,
            };
        }
    }
}