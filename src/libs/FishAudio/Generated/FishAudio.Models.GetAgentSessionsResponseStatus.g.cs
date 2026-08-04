
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentSessionsResponseStatus
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
    public static class GetAgentSessionsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseStatus value)
        {
            return value switch
            {
                GetAgentSessionsResponseStatus.Active => "active",
                GetAgentSessionsResponseStatus.Completed => "completed",
                GetAgentSessionsResponseStatus.Failed => "failed",
                GetAgentSessionsResponseStatus.Pending => "pending",
                GetAgentSessionsResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetAgentSessionsResponseStatus.Active,
                "completed" => GetAgentSessionsResponseStatus.Completed,
                "failed" => GetAgentSessionsResponseStatus.Failed,
                "pending" => GetAgentSessionsResponseStatus.Pending,
                "unknown" => GetAgentSessionsResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}