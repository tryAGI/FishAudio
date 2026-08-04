
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentToolSummaryToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentToolSummaryToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolSummaryToolType value)
        {
            return value switch
            {
                PublicAgentToolSummaryToolType.Client => "client",
                PublicAgentToolSummaryToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolSummaryToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PublicAgentToolSummaryToolType.Client,
                "webhook" => PublicAgentToolSummaryToolType.Webhook,
                _ => null,
            };
        }
    }
}