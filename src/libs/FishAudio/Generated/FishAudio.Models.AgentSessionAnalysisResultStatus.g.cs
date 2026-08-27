
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionAnalysisResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionAnalysisResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionAnalysisResultStatus value)
        {
            return value switch
            {
                AgentSessionAnalysisResultStatus.Completed => "completed",
                AgentSessionAnalysisResultStatus.Error => "error",
                AgentSessionAnalysisResultStatus.Queued => "queued",
                AgentSessionAnalysisResultStatus.Running => "running",
                AgentSessionAnalysisResultStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionAnalysisResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AgentSessionAnalysisResultStatus.Completed,
                "error" => AgentSessionAnalysisResultStatus.Error,
                "queued" => AgentSessionAnalysisResultStatus.Queued,
                "running" => AgentSessionAnalysisResultStatus.Running,
                "skipped" => AgentSessionAnalysisResultStatus.Skipped,
                _ => null,
            };
        }
    }
}