
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Whose tokens: the agent, the simulated user, or the judge.
    /// </summary>
    public enum PublicAgentTestRunLLMChargeParticipant
    {
        /// <summary>
        /// the agent, the simulated user, or the judge.
        /// </summary>
        Agent,
        /// <summary>
        /// the agent, the simulated user, or the judge.
        /// </summary>
        Judge,
        /// <summary>
        ///
        /// </summary>
        SimulatedUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestRunLLMChargeParticipantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunLLMChargeParticipant value)
        {
            return value switch
            {
                PublicAgentTestRunLLMChargeParticipant.Agent => "agent",
                PublicAgentTestRunLLMChargeParticipant.Judge => "judge",
                PublicAgentTestRunLLMChargeParticipant.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunLLMChargeParticipant? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PublicAgentTestRunLLMChargeParticipant.Agent,
                "judge" => PublicAgentTestRunLLMChargeParticipant.Judge,
                "simulated_user" => PublicAgentTestRunLLMChargeParticipant.SimulatedUser,
                _ => null,
            };
        }
    }
}