
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestMessageRole
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
    public static class PublicAgentTestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestMessageRole value)
        {
            return value switch
            {
                PublicAgentTestMessageRole.Agent => "agent",
                PublicAgentTestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PublicAgentTestMessageRole.Agent,
                "user" => PublicAgentTestMessageRole.User,
                _ => null,
            };
        }
    }
}