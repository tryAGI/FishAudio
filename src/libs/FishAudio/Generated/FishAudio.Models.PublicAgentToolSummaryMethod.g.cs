
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentToolSummaryMethod
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
    public static class PublicAgentToolSummaryMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolSummaryMethod value)
        {
            return value switch
            {
                PublicAgentToolSummaryMethod.Delete => "DELETE",
                PublicAgentToolSummaryMethod.Get => "GET",
                PublicAgentToolSummaryMethod.Patch => "PATCH",
                PublicAgentToolSummaryMethod.Post => "POST",
                PublicAgentToolSummaryMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolSummaryMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PublicAgentToolSummaryMethod.Delete,
                "GET" => PublicAgentToolSummaryMethod.Get,
                "PATCH" => PublicAgentToolSummaryMethod.Patch,
                "POST" => PublicAgentToolSummaryMethod.Post,
                "PUT" => PublicAgentToolSummaryMethod.Put,
                _ => null,
            };
        }
    }
}