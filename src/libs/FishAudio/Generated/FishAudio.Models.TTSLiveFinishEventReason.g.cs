
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `stop` when the session ended cleanly, `error` when the server aborted it.
    /// </summary>
    public enum TTSLiveFinishEventReason
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSLiveFinishEventReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSLiveFinishEventReason value)
        {
            return value switch
            {
                TTSLiveFinishEventReason.Error => "error",
                TTSLiveFinishEventReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSLiveFinishEventReason? ToEnum(string value)
        {
            return value switch
            {
                "error" => TTSLiveFinishEventReason.Error,
                "stop" => TTSLiveFinishEventReason.Stop,
                _ => null,
            };
        }
    }
}