
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelEntityTakedownCategory2
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
    public static class ModelEntityTakedownCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityTakedownCategory2 value)
        {
            return value switch
            {
                ModelEntityTakedownCategory2.Dmca => "dmca",
                ModelEntityTakedownCategory2.Policy => "policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityTakedownCategory2? ToEnum(string value)
        {
            return value switch
            {
                "dmca" => ModelEntityTakedownCategory2.Dmca,
                "policy" => ModelEntityTakedownCategory2.Policy,
                _ => null,
            };
        }
    }
}