
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentToolsResponseToolType
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
    public static class GetAgentToolsResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentToolsResponseToolType value)
        {
            return value switch
            {
                GetAgentToolsResponseToolType.Client => "client",
                GetAgentToolsResponseToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentToolsResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => GetAgentToolsResponseToolType.Client,
                "webhook" => GetAgentToolsResponseToolType.Webhook,
                _ => null,
            };
        }
    }
}