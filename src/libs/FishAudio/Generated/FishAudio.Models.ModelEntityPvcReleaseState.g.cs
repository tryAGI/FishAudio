
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelEntityPvcReleaseState
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
    public static class ModelEntityPvcReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityPvcReleaseState value)
        {
            return value switch
            {
                ModelEntityPvcReleaseState.Released => "released",
                ModelEntityPvcReleaseState.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityPvcReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "released" => ModelEntityPvcReleaseState.Released,
                "retiring" => ModelEntityPvcReleaseState.Retiring,
                _ => null,
            };
        }
    }
}