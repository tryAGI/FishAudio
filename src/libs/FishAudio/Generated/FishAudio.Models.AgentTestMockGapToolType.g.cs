
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestMockGapToolType
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
    public static class AgentTestMockGapToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestMockGapToolType value)
        {
            return value switch
            {
                AgentTestMockGapToolType.Client => "client",
                AgentTestMockGapToolType.Integration => "integration",
                AgentTestMockGapToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestMockGapToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => AgentTestMockGapToolType.Client,
                "integration" => AgentTestMockGapToolType.Integration,
                "webhook" => AgentTestMockGapToolType.Webhook,
                _ => null,
            };
        }
    }
}