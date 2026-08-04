
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionSummaryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryStatus value)
        {
            return value switch
            {
                AgentSessionSummaryStatus.Active => "active",
                AgentSessionSummaryStatus.Completed => "completed",
                AgentSessionSummaryStatus.Failed => "failed",
                AgentSessionSummaryStatus.Pending => "pending",
                AgentSessionSummaryStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AgentSessionSummaryStatus.Active,
                "completed" => AgentSessionSummaryStatus.Completed,
                "failed" => AgentSessionSummaryStatus.Failed,
                "pending" => AgentSessionSummaryStatus.Pending,
                "unknown" => AgentSessionSummaryStatus.Unknown,
                _ => null,
            };
        }
    }
}