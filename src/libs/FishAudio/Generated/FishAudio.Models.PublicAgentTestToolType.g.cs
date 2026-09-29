
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestToolType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Integration,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestToolType value)
        {
            return value switch
            {
                PublicAgentTestToolType.Client => "client",
                PublicAgentTestToolType.Integration => "integration",
                PublicAgentTestToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PublicAgentTestToolType.Client,
                "integration" => PublicAgentTestToolType.Integration,
                "webhook" => PublicAgentTestToolType.Webhook,
                _ => null,
            };
        }
    }
}