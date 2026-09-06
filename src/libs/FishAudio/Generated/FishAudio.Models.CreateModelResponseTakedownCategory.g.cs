
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelResponseTakedownCategory
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
    public static class CreateModelResponseTakedownCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseTakedownCategory value)
        {
            return value switch
            {
                CreateModelResponseTakedownCategory.Dmca => "dmca",
                CreateModelResponseTakedownCategory.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseTakedownCategory? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => CreateModelResponseTakedownCategory.Dmca,
                "policy" => CreateModelResponseTakedownCategory.Policy,
                _ => null,
            };
        }
    }
}