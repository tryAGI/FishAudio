
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestAssertionResultToolType
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
    public static class AgentTestAssertionResultToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestAssertionResultToolType value)
        {
            return value switch
            {
                AgentTestAssertionResultToolType.Client => "client",
                AgentTestAssertionResultToolType.Integration => "integration",
                AgentTestAssertionResultToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestAssertionResultToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => AgentTestAssertionResultToolType.Client,
                "integration" => AgentTestAssertionResultToolType.Integration,
                "webhook" => AgentTestAssertionResultToolType.Webhook,
                _ => null,
            };
        }
    }
}