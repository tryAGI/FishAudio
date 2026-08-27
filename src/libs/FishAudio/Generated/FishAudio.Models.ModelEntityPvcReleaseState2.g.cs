
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelEntityPvcReleaseState2
    {
        /// <summary>
        ///
        /// </summary>
        Released,
        /// <summary>
        ///
        /// </summary>
        Retiring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEntityPvcReleaseState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityPvcReleaseState2 value)
        {
            return value switch
            {
                ModelEntityPvcReleaseState2.Released => "released",
                ModelEntityPvcReleaseState2.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityPvcReleaseState2? ToEnum(string value)
        {
            return value switch
            {
                "released" => ModelEntityPvcReleaseState2.Released,
                "retiring" => ModelEntityPvcReleaseState2.Retiring,
                _ => null,
            };
        }
    }
}