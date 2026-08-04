
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: balanced
    /// </summary>
    public enum AgentConversationConfigEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        Eager,
        /// <summary>
        /// 
        /// </summary>
        Relaxed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationConfigEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationConfigEagerness value)
        {
            return value switch
            {
                AgentConversationConfigEagerness.Balanced => "balanced",
                AgentConversationConfigEagerness.Eager => "eager",
                AgentConversationConfigEagerness.Relaxed => "relaxed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationConfigEagerness? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => AgentConversationConfigEagerness.Balanced,
                "eager" => AgentConversationConfigEagerness.Eager,
                "relaxed" => AgentConversationConfigEagerness.Relaxed,
                _ => null,
            };
        }
    }
}