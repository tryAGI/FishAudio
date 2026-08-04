
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionToolResultItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionToolResultItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionToolResultItemStatus value)
        {
            return value switch
            {
                AgentSessionToolResultItemStatus.Completed => "completed",
                AgentSessionToolResultItemStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionToolResultItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AgentSessionToolResultItemStatus.Completed,
                "failed" => AgentSessionToolResultItemStatus.Failed,
                _ => null,
            };
        }
    }
}