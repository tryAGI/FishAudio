
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVoiceDesignResponseItemIn
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
    public static class CreateVoiceDesignResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceDesignResponseItemIn value)
        {
            return value switch
            {
                CreateVoiceDesignResponseItemIn.Body => "body",
                CreateVoiceDesignResponseItemIn.Cookie => "cookie",
                CreateVoiceDesignResponseItemIn.Header => "header",
                CreateVoiceDesignResponseItemIn.Path => "path",
                CreateVoiceDesignResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceDesignResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => CreateVoiceDesignResponseItemIn.Body,
                "cookie" => CreateVoiceDesignResponseItemIn.Cookie,
                "header" => CreateVoiceDesignResponseItemIn.Header,
                "path" => CreateVoiceDesignResponseItemIn.Path,
                "query" => CreateVoiceDesignResponseItemIn.Query,
                _ => null,
            };
        }
    }
}