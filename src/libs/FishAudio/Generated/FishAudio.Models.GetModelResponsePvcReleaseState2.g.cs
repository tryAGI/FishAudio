
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelResponsePvcReleaseState2
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
    public static class GetModelResponsePvcReleaseState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponsePvcReleaseState2 value)
        {
            return value switch
            {
                GetModelResponsePvcReleaseState2.Released => "released",
                GetModelResponsePvcReleaseState2.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponsePvcReleaseState2? ToEnum(string value)
        {
            return value switch
            {
                "released" => GetModelResponsePvcReleaseState2.Released,
                "retiring" => GetModelResponsePvcReleaseState2.Retiring,
                _ => null,
            };
        }
    }
}