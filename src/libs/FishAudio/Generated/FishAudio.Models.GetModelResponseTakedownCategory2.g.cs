
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelResponseTakedownCategory2
    {
        /// <summary>
        ///
        /// </summary>
        Dmca,
        /// <summary>
        ///
        /// </summary>
        Policy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelResponseTakedownCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseTakedownCategory2 value)
        {
            return value switch
            {
                GetModelResponseTakedownCategory2.Dmca => "dmca",
                GetModelResponseTakedownCategory2.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseTakedownCategory2? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => GetModelResponseTakedownCategory2.Dmca,
                "policy" => GetModelResponseTakedownCategory2.Policy,
                _ => null,
            };
        }
    }
}