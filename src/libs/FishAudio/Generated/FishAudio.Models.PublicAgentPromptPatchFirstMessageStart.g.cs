
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentPromptPatchFirstMessageStart
    {
        /// <summary>
        ///
        /// </summary>
        AgentFirst,
        /// <summary>
        ///
        /// </summary>
        WaitForCaller,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentPromptPatchFirstMessageStartExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentPromptPatchFirstMessageStart value)
        {
            return value switch
            {
                PublicAgentPromptPatchFirstMessageStart.AgentFirst => "agent_first",
                PublicAgentPromptPatchFirstMessageStart.WaitForCaller => "wait_for_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentPromptPatchFirstMessageStart? ToEnum(string value)
        {
            return value switch
            {
                "agent_first" => PublicAgentPromptPatchFirstMessageStart.AgentFirst,
                "wait_for_caller" => PublicAgentPromptPatchFirstMessageStart.WaitForCaller,
                _ => null,
            };
        }
    }
}