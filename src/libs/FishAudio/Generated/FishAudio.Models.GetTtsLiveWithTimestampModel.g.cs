
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: s2.1-pro
    /// </summary>
    public enum GetTtsLiveWithTimestampModel
    {
        /// <summary>
        ///
        /// </summary>
        Drama3Preview,
        /// <summary>
        ///
        /// </summary>
        S1,
        /// <summary>
        ///
        /// </summary>
        S2Pro,
        /// <summary>
        ///
        /// </summary>
        S21Pro,
        /// <summary>
        ///
        /// </summary>
        S21ProFree,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTtsLiveWithTimestampModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTtsLiveWithTimestampModel value)
        {
            return value switch
            {
                GetTtsLiveWithTimestampModel.Drama3Preview => "drama-3-preview",
                GetTtsLiveWithTimestampModel.S1 => "s1",
                GetTtsLiveWithTimestampModel.S2Pro => "s2-pro",
                GetTtsLiveWithTimestampModel.S21Pro => "s2.1-pro",
                GetTtsLiveWithTimestampModel.S21ProFree => "s2.1-pro-free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTtsLiveWithTimestampModel? ToEnum(string value)
        {
            return value switch
            {
                "drama-3-preview" => GetTtsLiveWithTimestampModel.Drama3Preview,
                "s1" => GetTtsLiveWithTimestampModel.S1,
                "s2-pro" => GetTtsLiveWithTimestampModel.S2Pro,
                "s2.1-pro" => GetTtsLiveWithTimestampModel.S21Pro,
                "s2.1-pro-free" => GetTtsLiveWithTimestampModel.S21ProFree,
                _ => null,
            };
        }
    }
}