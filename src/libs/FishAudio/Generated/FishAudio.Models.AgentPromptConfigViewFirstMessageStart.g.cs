
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// When the opener plays. `agent_first` (default): the agent speaks as soon as the call connects. `wait_for_caller`: the agent waits for the caller to speak first and plays the opener anyway once `first_message_max_wait_ms` has passed. `wait_for_caller` needs a `fixed` or `prompt` opener: with `first_message_mode` `off` the write is rejected with 422, and the stored values stay as they were. With a `fixed` opener the agent speaks after the caller does, or when the wait runs out; with a `prompt` opener it answers what the caller said first.<br/>
    /// Default Value: agent_first
    /// </summary>
    public enum AgentPromptConfigViewFirstMessageStart
    {
        /// <summary>
        /// the agent speaks as soon as the call connects. `wait_for_caller`: the agent waits for the caller to speak first and plays the opener anyway once `first_message_max_wait_ms` has passed. `wait_for_caller` needs a `fixed` or `prompt` opener: with `first_message_mode` `off` the write is rejected with 422, and the stored values stay as they were. With a `fixed` opener the agent speaks after the caller does, or when the wait runs out; with a `prompt` opener it answers what the caller said first.
        /// </summary>
        AgentFirst,
        /// <summary>
        /// the agent speaks as soon as the call connects. `wait_for_caller`: the agent waits for the caller to speak first and plays the opener anyway once `first_message_max_wait_ms` has passed. `wait_for_caller` needs a `fixed` or `prompt` opener: with `first_message_mode` `off` the write is rejected with 422, and the stored values stay as they were. With a `fixed` opener the agent speaks after the caller does, or when the wait runs out; with a `prompt` opener it answers what the caller said first.
        /// </summary>
        WaitForCaller,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPromptConfigViewFirstMessageStartExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPromptConfigViewFirstMessageStart value)
        {
            return value switch
            {
                AgentPromptConfigViewFirstMessageStart.AgentFirst => "agent_first",
                AgentPromptConfigViewFirstMessageStart.WaitForCaller => "wait_for_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPromptConfigViewFirstMessageStart? ToEnum(string value)
        {
            return value switch
            {
                "agent_first" => AgentPromptConfigViewFirstMessageStart.AgentFirst,
                "wait_for_caller" => AgentPromptConfigViewFirstMessageStart.WaitForCaller,
                _ => null,
            };
        }
    }
}