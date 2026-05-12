
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Output audio format.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum TTSStreamWithTimestampRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSStreamWithTimestampRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSStreamWithTimestampRequestFormat value)
        {
            return value switch
            {
                TTSStreamWithTimestampRequestFormat.Mp3 => "mp3",
                TTSStreamWithTimestampRequestFormat.Opus => "opus",
                TTSStreamWithTimestampRequestFormat.Pcm => "pcm",
                TTSStreamWithTimestampRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSStreamWithTimestampRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => TTSStreamWithTimestampRequestFormat.Mp3,
                "opus" => TTSStreamWithTimestampRequestFormat.Opus,
                "pcm" => TTSStreamWithTimestampRequestFormat.Pcm,
                "wav" => TTSStreamWithTimestampRequestFormat.Wav,
                _ => null,
            };
        }
    }
}