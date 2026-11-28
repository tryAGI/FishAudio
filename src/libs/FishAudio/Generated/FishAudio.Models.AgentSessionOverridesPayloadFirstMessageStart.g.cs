
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionOverridesPayloadFirstMessageStart
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
    public static class AgentSessionOverridesPayloadFirstMessageStartExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionOverridesPayloadFirstMessageStart value)
        {
            return value switch
            {
                AgentSessionOverridesPayloadFirstMessageStart.AgentFirst => "agent_first",
                AgentSessionOverridesPayloadFirstMessageStart.WaitForCaller => "wait_for_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionOverridesPayloadFirstMessageStart? ToEnum(string value)
        {
            return value switch
            {
                "agent_first" => AgentSessionOverridesPayloadFirstMessageStart.AgentFirst,
                "wait_for_caller" => AgentSessionOverridesPayloadFirstMessageStart.WaitForCaller,
                _ => null,
            };
        }
    }
}