
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelEntityTakedownCategory
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
    public static class ModelEntityTakedownCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityTakedownCategory value)
        {
            return value switch
            {
                ModelEntityTakedownCategory.Dmca => "dmca",
                ModelEntityTakedownCategory.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityTakedownCategory? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => ModelEntityTakedownCategory.Dmca,
                "policy" => ModelEntityTakedownCategory.Policy,
                _ => null,
            };
        }
    }
}