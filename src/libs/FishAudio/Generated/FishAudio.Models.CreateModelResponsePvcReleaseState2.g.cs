
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelResponsePvcReleaseState2
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
    public static class CreateModelResponsePvcReleaseState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponsePvcReleaseState2 value)
        {
            return value switch
            {
                CreateModelResponsePvcReleaseState2.Released => "released",
                CreateModelResponsePvcReleaseState2.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponsePvcReleaseState2? ToEnum(string value)
        {
            return value switch
            {
                "released" => CreateModelResponsePvcReleaseState2.Released,
                "retiring" => CreateModelResponsePvcReleaseState2.Retiring,
                _ => null,
            };
        }
    }
}