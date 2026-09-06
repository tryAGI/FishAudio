
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentToolUpdatePayloadMethod
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
    public static class PublicAgentToolUpdatePayloadMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolUpdatePayloadMethod value)
        {
            return value switch
            {
                PublicAgentToolUpdatePayloadMethod.Delete => "DELETE",
                PublicAgentToolUpdatePayloadMethod.Get => "GET",
                PublicAgentToolUpdatePayloadMethod.Patch => "PATCH",
                PublicAgentToolUpdatePayloadMethod.Post => "POST",
                PublicAgentToolUpdatePayloadMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolUpdatePayloadMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PublicAgentToolUpdatePayloadMethod.Delete,
                "GET" => PublicAgentToolUpdatePayloadMethod.Get,
                "PATCH" => PublicAgentToolUpdatePayloadMethod.Patch,
                "POST" => PublicAgentToolUpdatePayloadMethod.Post,
                "PUT" => PublicAgentToolUpdatePayloadMethod.Put,
                _ => null,
            };
        }
    }
}