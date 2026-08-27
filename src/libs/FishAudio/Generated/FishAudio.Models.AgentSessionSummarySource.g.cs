
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionSummarySource
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
    public static class AgentSessionSummarySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummarySource value)
        {
            return value switch
            {
                AgentSessionSummarySource.ApiKey => "api_key",
                AgentSessionSummarySource.Dashboard => "dashboard",
                AgentSessionSummarySource.Phone => "phone",
                AgentSessionSummarySource.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummarySource? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => AgentSessionSummarySource.ApiKey,
                "dashboard" => AgentSessionSummarySource.Dashboard,
                "phone" => AgentSessionSummarySource.Phone,
                "public" => AgentSessionSummarySource.Public,
                _ => null,
            };
        }
    }
}