
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentToolsResponseMethod
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
    public static class CreateAgentToolsResponseMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentToolsResponseMethod value)
        {
            return value switch
            {
                CreateAgentToolsResponseMethod.Delete => "DELETE",
                CreateAgentToolsResponseMethod.Get => "GET",
                CreateAgentToolsResponseMethod.Patch => "PATCH",
                CreateAgentToolsResponseMethod.Post => "POST",
                CreateAgentToolsResponseMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentToolsResponseMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => CreateAgentToolsResponseMethod.Delete,
                "GET" => CreateAgentToolsResponseMethod.Get,
                "PATCH" => CreateAgentToolsResponseMethod.Patch,
                "POST" => CreateAgentToolsResponseMethod.Post,
                "PUT" => CreateAgentToolsResponseMethod.Put,
                _ => null,
            };
        }
    }
}