
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// What the agent says before a silence hangup. `off` (default) hangs up without a word, `generated` says a short goodbye, `fixed` says hangup_farewell_message. A `fixed` mode with an empty message falls back to `generated`. If the caller speaks during the goodbye, the call goes on.<br/>
    /// Default Value: off
    /// </summary>
    public enum AgentConversationConfigHangupFarewellMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Generated,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationConfigHangupFarewellModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationConfigHangupFarewellMode value)
        {
            return value switch
            {
                AgentConversationConfigHangupFarewellMode.Fixed => "fixed",
                AgentConversationConfigHangupFarewellMode.Generated => "generated",
                AgentConversationConfigHangupFarewellMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationConfigHangupFarewellMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentConversationConfigHangupFarewellMode.Fixed,
                "generated" => AgentConversationConfigHangupFarewellMode.Generated,
                "off" => AgentConversationConfigHangupFarewellMode.Off,
                _ => null,
            };
        }
    }
}