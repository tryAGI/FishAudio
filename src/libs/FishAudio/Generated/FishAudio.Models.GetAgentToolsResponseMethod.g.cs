
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentToolsResponseMethod
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
    public static class GetAgentToolsResponseMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentToolsResponseMethod value)
        {
            return value switch
            {
                GetAgentToolsResponseMethod.Delete => "DELETE",
                GetAgentToolsResponseMethod.Get => "GET",
                GetAgentToolsResponseMethod.Patch => "PATCH",
                GetAgentToolsResponseMethod.Post => "POST",
                GetAgentToolsResponseMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentToolsResponseMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => GetAgentToolsResponseMethod.Delete,
                "GET" => GetAgentToolsResponseMethod.Get,
                "PATCH" => GetAgentToolsResponseMethod.Patch,
                "POST" => GetAgentToolsResponseMethod.Post,
                "PUT" => GetAgentToolsResponseMethod.Put,
                _ => null,
            };
        }
    }
}