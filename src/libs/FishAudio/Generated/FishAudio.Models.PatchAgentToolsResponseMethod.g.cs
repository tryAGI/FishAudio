
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAgentToolsResponseMethod
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
    public static class PatchAgentToolsResponseMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentToolsResponseMethod value)
        {
            return value switch
            {
                PatchAgentToolsResponseMethod.Delete => "DELETE",
                PatchAgentToolsResponseMethod.Get => "GET",
                PatchAgentToolsResponseMethod.Patch => "PATCH",
                PatchAgentToolsResponseMethod.Post => "POST",
                PatchAgentToolsResponseMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentToolsResponseMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PatchAgentToolsResponseMethod.Delete,
                "GET" => PatchAgentToolsResponseMethod.Get,
                "PATCH" => PatchAgentToolsResponseMethod.Patch,
                "POST" => PatchAgentToolsResponseMethod.Post,
                "PUT" => PatchAgentToolsResponseMethod.Put,
                _ => null,
            };
        }
    }
}