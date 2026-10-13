
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferRecordingEntityStatus
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
    public static class AgentSessionTransferRecordingEntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferRecordingEntityStatus value)
        {
            return value switch
            {
                AgentSessionTransferRecordingEntityStatus.Complete => "complete",
                AgentSessionTransferRecordingEntityStatus.Failed => "failed",
                AgentSessionTransferRecordingEntityStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferRecordingEntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => AgentSessionTransferRecordingEntityStatus.Complete,
                "failed" => AgentSessionTransferRecordingEntityStatus.Failed,
                "processing" => AgentSessionTransferRecordingEntityStatus.Processing,
                _ => null,
            };
        }
    }
}