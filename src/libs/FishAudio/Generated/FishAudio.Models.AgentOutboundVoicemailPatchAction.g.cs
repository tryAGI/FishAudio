
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: hangup
    /// </summary>
    public enum AgentOutboundVoicemailPatchAction
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
    public static class AgentOutboundVoicemailPatchActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutboundVoicemailPatchAction value)
        {
            return value switch
            {
                AgentOutboundVoicemailPatchAction.Hangup => "hangup",
                AgentOutboundVoicemailPatchAction.LeaveMessage => "leave_message",
                AgentOutboundVoicemailPatchAction.LeavePromptMessage => "leave_prompt_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutboundVoicemailPatchAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AgentOutboundVoicemailPatchAction.Hangup,
                "leave_message" => AgentOutboundVoicemailPatchAction.LeaveMessage,
                "leave_prompt_message" => AgentOutboundVoicemailPatchAction.LeavePromptMessage,
                _ => null,
            };
        }
    }
}