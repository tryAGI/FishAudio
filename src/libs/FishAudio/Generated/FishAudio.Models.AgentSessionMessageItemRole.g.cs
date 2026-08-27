
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionMessageItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionMessageItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionMessageItemRole value)
        {
            return value switch
            {
                AgentSessionMessageItemRole.Assistant => "assistant",
                AgentSessionMessageItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionMessageItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentSessionMessageItemRole.Assistant,
                "user" => AgentSessionMessageItemRole.User,
                _ => null,
            };
        }
    }
}