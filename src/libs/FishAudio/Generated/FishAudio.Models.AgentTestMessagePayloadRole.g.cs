
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestMessagePayloadRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestMessagePayloadRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestMessagePayloadRole value)
        {
            return value switch
            {
                AgentTestMessagePayloadRole.Agent => "agent",
                AgentTestMessagePayloadRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestMessagePayloadRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentTestMessagePayloadRole.Agent,
                "user" => AgentTestMessagePayloadRole.User,
                _ => null,
            };
        }
    }
}