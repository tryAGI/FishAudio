
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
    /// Default Value: public
    /// </summary>
    public enum CreateModelRequestVisibility4
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
    public static class CreateModelRequestVisibility4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestVisibility4 value)
        {
            return value switch
            {
                CreateModelRequestVisibility4.Private => "private",
                CreateModelRequestVisibility4.Public => "public",
                CreateModelRequestVisibility4.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestVisibility4? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelRequestVisibility4.Private,
                "public" => CreateModelRequestVisibility4.Public,
                "unlist" => CreateModelRequestVisibility4.Unlist,
                _ => null,
            };
        }
    }
}