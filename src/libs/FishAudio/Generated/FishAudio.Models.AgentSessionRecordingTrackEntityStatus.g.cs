
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionRecordingTrackEntityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Requested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionRecordingTrackEntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionRecordingTrackEntityStatus value)
        {
            return value switch
            {
                AgentSessionRecordingTrackEntityStatus.Active => "active",
                AgentSessionRecordingTrackEntityStatus.Complete => "complete",
                AgentSessionRecordingTrackEntityStatus.Failed => "failed",
                AgentSessionRecordingTrackEntityStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionRecordingTrackEntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AgentSessionRecordingTrackEntityStatus.Active,
                "complete" => AgentSessionRecordingTrackEntityStatus.Complete,
                "failed" => AgentSessionRecordingTrackEntityStatus.Failed,
                "requested" => AgentSessionRecordingTrackEntityStatus.Requested,
                _ => null,
            };
        }
    }
}