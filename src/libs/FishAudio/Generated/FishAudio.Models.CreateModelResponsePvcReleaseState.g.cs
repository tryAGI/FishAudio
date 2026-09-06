
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelResponsePvcReleaseState
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
    public static class CreateModelResponsePvcReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponsePvcReleaseState value)
        {
            return value switch
            {
                CreateModelResponsePvcReleaseState.Released => "released",
                CreateModelResponsePvcReleaseState.Retiring => "retiring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponsePvcReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "released" => CreateModelResponsePvcReleaseState.Released,
                "retiring" => CreateModelResponsePvcReleaseState.Retiring,
                _ => null,
            };
        }
    }
}