
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTtsLiveWithTimestampResponseDiscriminatorEvent
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Finish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTtsLiveWithTimestampResponseDiscriminatorEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTtsLiveWithTimestampResponseDiscriminatorEvent value)
        {
            return value switch
            {
                GetTtsLiveWithTimestampResponseDiscriminatorEvent.Audio => "audio",
                GetTtsLiveWithTimestampResponseDiscriminatorEvent.Error => "error",
                GetTtsLiveWithTimestampResponseDiscriminatorEvent.Finish => "finish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTtsLiveWithTimestampResponseDiscriminatorEvent? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GetTtsLiveWithTimestampResponseDiscriminatorEvent.Audio,
                "error" => GetTtsLiveWithTimestampResponseDiscriminatorEvent.Error,
                "finish" => GetTtsLiveWithTimestampResponseDiscriminatorEvent.Finish,
                _ => null,
            };
        }
    }
}