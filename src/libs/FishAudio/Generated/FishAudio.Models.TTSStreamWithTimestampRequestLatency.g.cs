
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
    /// Default Value: normal
    /// </summary>
    public enum TTSStreamWithTimestampRequestLatency
    {
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        Balanced,
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        Low,
        /// <summary>
        /// best quality, balanced: reduced latency, low: lowest latency.
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSStreamWithTimestampRequestLatencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSStreamWithTimestampRequestLatency value)
        {
            return value switch
            {
                TTSStreamWithTimestampRequestLatency.Balanced => "balanced",
                TTSStreamWithTimestampRequestLatency.Low => "low",
                TTSStreamWithTimestampRequestLatency.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSStreamWithTimestampRequestLatency? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => TTSStreamWithTimestampRequestLatency.Balanced,
                "low" => TTSStreamWithTimestampRequestLatency.Low,
                "normal" => TTSStreamWithTimestampRequestLatency.Normal,
                _ => null,
            };
        }
    }
}