
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentToolUpdatePayloadMethod2
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
    public static class PublicAgentToolUpdatePayloadMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolUpdatePayloadMethod2 value)
        {
            return value switch
            {
                PublicAgentToolUpdatePayloadMethod2.Delete => "DELETE",
                PublicAgentToolUpdatePayloadMethod2.Get => "GET",
                PublicAgentToolUpdatePayloadMethod2.Patch => "PATCH",
                PublicAgentToolUpdatePayloadMethod2.Post => "POST",
                PublicAgentToolUpdatePayloadMethod2.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolUpdatePayloadMethod2? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PublicAgentToolUpdatePayloadMethod2.Delete,
                "GET" => PublicAgentToolUpdatePayloadMethod2.Get,
                "PATCH" => PublicAgentToolUpdatePayloadMethod2.Patch,
                "POST" => PublicAgentToolUpdatePayloadMethod2.Post,
                "PUT" => PublicAgentToolUpdatePayloadMethod2.Put,
                _ => null,
            };
        }
    }
}