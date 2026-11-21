
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Output audio format.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioInfillRequestFormat
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
    public static class CreateAudioInfillRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioInfillRequestFormat value)
        {
            return value switch
            {
                CreateAudioInfillRequestFormat.Mp3 => "mp3",
                CreateAudioInfillRequestFormat.Opus => "opus",
                CreateAudioInfillRequestFormat.Pcm => "pcm",
                CreateAudioInfillRequestFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioInfillRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioInfillRequestFormat.Mp3,
                "opus" => CreateAudioInfillRequestFormat.Opus,
                "pcm" => CreateAudioInfillRequestFormat.Pcm,
                "wav" => CreateAudioInfillRequestFormat.Wav,
                _ => null,
            };
        }
    }
}