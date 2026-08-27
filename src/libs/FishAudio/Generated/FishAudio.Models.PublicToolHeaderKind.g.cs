
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicToolHeaderKind
    {
        /// <summary>
        ///
        /// </summary>
        AuthorizationBasic,
        /// <summary>
        ///
        /// </summary>
        AuthorizationBearer,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicToolHeaderKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicToolHeaderKind value)
        {
            return value switch
            {
                PublicToolHeaderKind.AuthorizationBasic => "authorization_basic",
                PublicToolHeaderKind.AuthorizationBearer => "authorization_bearer",
                PublicToolHeaderKind.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicToolHeaderKind? ToEnum(string value)
        {
            return value switch
            {
                "authorization_basic" => PublicToolHeaderKind.AuthorizationBasic,
                "authorization_bearer" => PublicToolHeaderKind.AuthorizationBearer,
                "custom" => PublicToolHeaderKind.Custom,
                _ => null,
            };
        }
    }
}