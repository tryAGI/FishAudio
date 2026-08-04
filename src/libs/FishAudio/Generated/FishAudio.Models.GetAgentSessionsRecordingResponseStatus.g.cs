
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentSessionsRecordingResponseStatus
    {
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
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentSessionsRecordingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsRecordingResponseStatus value)
        {
            return value switch
            {
                GetAgentSessionsRecordingResponseStatus.Complete => "complete",
                GetAgentSessionsRecordingResponseStatus.Failed => "failed",
                GetAgentSessionsRecordingResponseStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsRecordingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GetAgentSessionsRecordingResponseStatus.Complete,
                "failed" => GetAgentSessionsRecordingResponseStatus.Failed,
                "processing" => GetAgentSessionsRecordingResponseStatus.Processing,
                _ => null,
            };
        }
    }
}