
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelResponsePvcReleaseState
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
    public static class GetModelResponsePvcReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponsePvcReleaseState value)
        {
            return value switch
            {
                GetModelResponsePvcReleaseState.Released => "released",
                GetModelResponsePvcReleaseState.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponsePvcReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "released" => GetModelResponsePvcReleaseState.Released,
                "retiring" => GetModelResponsePvcReleaseState.Retiring,
                _ => null,
            };
        }
    }
}