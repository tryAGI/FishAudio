
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: s2-pro
    /// </summary>
    public enum CreateTtsStreamWithTimestampModel
    {
        /// <summary>
        /// 
        /// </summary>
        S1,
        /// <summary>
        /// 
        /// </summary>
        S2Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTtsStreamWithTimestampModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTtsStreamWithTimestampModel value)
        {
            return value switch
            {
                CreateTtsStreamWithTimestampModel.S1 => "s1",
                CreateTtsStreamWithTimestampModel.S2Pro => "s2-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTtsStreamWithTimestampModel? ToEnum(string value)
        {
            return value switch
            {
                "s1" => CreateTtsStreamWithTimestampModel.S1,
                "s2-pro" => CreateTtsStreamWithTimestampModel.S2Pro,
                _ => null,
            };
        }
    }
}