
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTtsStreamWithTimestampResponseItemIn
    {
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Path,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTtsStreamWithTimestampResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTtsStreamWithTimestampResponseItemIn value)
        {
            return value switch
            {
                CreateTtsStreamWithTimestampResponseItemIn.Body => "body",
                CreateTtsStreamWithTimestampResponseItemIn.Cookie => "cookie",
                CreateTtsStreamWithTimestampResponseItemIn.Header => "header",
                CreateTtsStreamWithTimestampResponseItemIn.Path => "path",
                CreateTtsStreamWithTimestampResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTtsStreamWithTimestampResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => CreateTtsStreamWithTimestampResponseItemIn.Body,
                "cookie" => CreateTtsStreamWithTimestampResponseItemIn.Cookie,
                "header" => CreateTtsStreamWithTimestampResponseItemIn.Header,
                "path" => CreateTtsStreamWithTimestampResponseItemIn.Path,
                "query" => CreateTtsStreamWithTimestampResponseItemIn.Query,
                _ => null,
            };
        }
    }
}