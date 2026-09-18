
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: transcribe-1
    /// </summary>
    public enum CreateAsrModel
    {
        /// <summary>
        ///
        /// </summary>
        Transcribe1,
        /// <summary>
        ///
        /// </summary>
        Transcribe1Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsrModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsrModel value)
        {
            return value switch
            {
                CreateAsrModel.Transcribe1 => "transcribe-1",
                CreateAsrModel.Transcribe1Pro => "transcribe-1-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsrModel? ToEnum(string value)
        {
            return value switch
            {
                "transcribe-1" => CreateAsrModel.Transcribe1,
                "transcribe-1-pro" => CreateAsrModel.Transcribe1Pro,
                _ => null,
            };
        }
    }
}