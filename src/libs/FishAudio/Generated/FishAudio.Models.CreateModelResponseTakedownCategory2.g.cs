
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelResponseTakedownCategory2
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
    public static class CreateModelResponseTakedownCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseTakedownCategory2 value)
        {
            return value switch
            {
                CreateModelResponseTakedownCategory2.Dmca => "dmca",
                CreateModelResponseTakedownCategory2.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseTakedownCategory2? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => CreateModelResponseTakedownCategory2.Dmca,
                "policy" => CreateModelResponseTakedownCategory2.Policy,
                _ => null,
            };
        }
    }
}