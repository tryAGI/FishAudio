
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum PublicAgentToolCreatePayloadMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentToolCreatePayloadMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolCreatePayloadMethod value)
        {
            return value switch
            {
                PublicAgentToolCreatePayloadMethod.Delete => "DELETE",
                PublicAgentToolCreatePayloadMethod.Get => "GET",
                PublicAgentToolCreatePayloadMethod.Patch => "PATCH",
                PublicAgentToolCreatePayloadMethod.Post => "POST",
                PublicAgentToolCreatePayloadMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolCreatePayloadMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PublicAgentToolCreatePayloadMethod.Delete,
                "GET" => PublicAgentToolCreatePayloadMethod.Get,
                "PATCH" => PublicAgentToolCreatePayloadMethod.Patch,
                "POST" => PublicAgentToolCreatePayloadMethod.Post,
                "PUT" => PublicAgentToolCreatePayloadMethod.Put,
                _ => null,
            };
        }
    }
}