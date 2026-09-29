
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunEndedBy
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        MaxTurns,
        /// <summary>
        ///
        /// </summary>
        Timeout,
        /// <summary>
        ///
        /// </summary>
        Transfer,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestRunEndedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunEndedBy value)
        {
            return value switch
            {
                PublicAgentTestRunEndedBy.Agent => "agent",
                PublicAgentTestRunEndedBy.Error => "error",
                PublicAgentTestRunEndedBy.MaxTurns => "max_turns",
                PublicAgentTestRunEndedBy.Timeout => "timeout",
                PublicAgentTestRunEndedBy.Transfer => "transfer",
                PublicAgentTestRunEndedBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunEndedBy? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PublicAgentTestRunEndedBy.Agent,
                "error" => PublicAgentTestRunEndedBy.Error,
                "max_turns" => PublicAgentTestRunEndedBy.MaxTurns,
                "timeout" => PublicAgentTestRunEndedBy.Timeout,
                "transfer" => PublicAgentTestRunEndedBy.Transfer,
                "user" => PublicAgentTestRunEndedBy.User,
                _ => null,
            };
        }
    }
}