
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentSessionsResponseSource
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Dashboard,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentSessionsResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseSource value)
        {
            return value switch
            {
                GetAgentSessionsResponseSource.ApiKey => "api_key",
                GetAgentSessionsResponseSource.Dashboard => "dashboard",
                GetAgentSessionsResponseSource.Phone => "phone",
                GetAgentSessionsResponseSource.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GetAgentSessionsResponseSource.ApiKey,
                "dashboard" => GetAgentSessionsResponseSource.Dashboard,
                "phone" => GetAgentSessionsResponseSource.Phone,
                "public" => GetAgentSessionsResponseSource.Public,
                _ => null,
            };
        }
    }
}