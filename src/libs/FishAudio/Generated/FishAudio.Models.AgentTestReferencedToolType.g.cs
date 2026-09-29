
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: webhook
    /// </summary>
    public enum AgentTestReferencedToolType
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
    public static class AgentTestReferencedToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestReferencedToolType value)
        {
            return value switch
            {
                AgentTestReferencedToolType.Client => "client",
                AgentTestReferencedToolType.Integration => "integration",
                AgentTestReferencedToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestReferencedToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => AgentTestReferencedToolType.Client,
                "integration" => AgentTestReferencedToolType.Integration,
                "webhook" => AgentTestReferencedToolType.Webhook,
                _ => null,
            };
        }
    }
}