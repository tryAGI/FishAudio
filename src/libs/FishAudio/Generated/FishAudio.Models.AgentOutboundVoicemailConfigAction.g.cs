
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: hangup
    /// </summary>
    public enum AgentOutboundVoicemailConfigAction
    {
        /// <summary>
        ///
        /// </summary>
        Hangup,
        /// <summary>
        ///
        /// </summary>
        LeaveMessage,
        /// <summary>
        ///
        /// </summary>
        LeavePromptMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOutboundVoicemailConfigActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutboundVoicemailConfigAction value)
        {
            return value switch
            {
                AgentOutboundVoicemailConfigAction.Hangup => "hangup",
                AgentOutboundVoicemailConfigAction.LeaveMessage => "leave_message",
                AgentOutboundVoicemailConfigAction.LeavePromptMessage => "leave_prompt_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutboundVoicemailConfigAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AgentOutboundVoicemailConfigAction.Hangup,
                "leave_message" => AgentOutboundVoicemailConfigAction.LeaveMessage,
                "leave_prompt_message" => AgentOutboundVoicemailConfigAction.LeavePromptMessage,
                _ => null,
            };
        }
    }
}