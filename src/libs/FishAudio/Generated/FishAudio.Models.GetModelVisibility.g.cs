
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetModelVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
        /// <summary>
        ///
        /// </summary>
        Unlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelVisibility value)
        {
            return value switch
            {
                GetModelVisibility.Private => "private",
                GetModelVisibility.Public => "public",
                GetModelVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetModelVisibility.Private,
                "public" => GetModelVisibility.Public,
                "unlist" => GetModelVisibility.Unlist,
                _ => null,
            };
        }
    }
}