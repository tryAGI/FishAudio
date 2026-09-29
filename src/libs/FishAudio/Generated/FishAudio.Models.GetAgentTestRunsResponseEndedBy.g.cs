
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsResponseEndedBy
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
    public static class GetAgentTestRunsResponseEndedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsResponseEndedBy value)
        {
            return value switch
            {
                GetAgentTestRunsResponseEndedBy.Agent => "agent",
                GetAgentTestRunsResponseEndedBy.Error => "error",
                GetAgentTestRunsResponseEndedBy.MaxTurns => "max_turns",
                GetAgentTestRunsResponseEndedBy.Timeout => "timeout",
                GetAgentTestRunsResponseEndedBy.Transfer => "transfer",
                GetAgentTestRunsResponseEndedBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsResponseEndedBy? ToEnum(string value)
        {
            return value switch
            {
                "agent" => GetAgentTestRunsResponseEndedBy.Agent,
                "error" => GetAgentTestRunsResponseEndedBy.Error,
                "max_turns" => GetAgentTestRunsResponseEndedBy.MaxTurns,
                "timeout" => GetAgentTestRunsResponseEndedBy.Timeout,
                "transfer" => GetAgentTestRunsResponseEndedBy.Transfer,
                "user" => GetAgentTestRunsResponseEndedBy.User,
                _ => null,
            };
        }
    }
}