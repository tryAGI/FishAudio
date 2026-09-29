
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestSimulationAssertionsEndedBy
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Any,
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
    public static class AgentTestSimulationAssertionsEndedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestSimulationAssertionsEndedBy value)
        {
            return value switch
            {
                AgentTestSimulationAssertionsEndedBy.Agent => "agent",
                AgentTestSimulationAssertionsEndedBy.Any => "any",
                AgentTestSimulationAssertionsEndedBy.Transfer => "transfer",
                AgentTestSimulationAssertionsEndedBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestSimulationAssertionsEndedBy? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentTestSimulationAssertionsEndedBy.Agent,
                "any" => AgentTestSimulationAssertionsEndedBy.Any,
                "transfer" => AgentTestSimulationAssertionsEndedBy.Transfer,
                "user" => AgentTestSimulationAssertionsEndedBy.User,
                _ => null,
            };
        }
    }
}