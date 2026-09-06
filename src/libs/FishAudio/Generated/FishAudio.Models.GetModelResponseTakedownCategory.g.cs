
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelResponseTakedownCategory
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
    public static class GetModelResponseTakedownCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseTakedownCategory value)
        {
            return value switch
            {
                GetModelResponseTakedownCategory.Dmca => "dmca",
                GetModelResponseTakedownCategory.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseTakedownCategory? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => GetModelResponseTakedownCategory.Dmca,
                "policy" => GetModelResponseTakedownCategory.Policy,
                _ => null,
            };
        }
    }
}