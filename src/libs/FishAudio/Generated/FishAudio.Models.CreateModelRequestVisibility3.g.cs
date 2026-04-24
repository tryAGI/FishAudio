
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
    /// Default Value: public
    /// </summary>
    public enum CreateModelRequestVisibility3
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
    public static class CreateModelRequestVisibility3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestVisibility3 value)
        {
            return value switch
            {
                CreateModelRequestVisibility3.Private => "private",
                CreateModelRequestVisibility3.Public => "public",
                CreateModelRequestVisibility3.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestVisibility3? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelRequestVisibility3.Private,
                "public" => CreateModelRequestVisibility3.Public,
                "unlist" => CreateModelRequestVisibility3.Unlist,
                _ => null,
            };
        }
    }
}