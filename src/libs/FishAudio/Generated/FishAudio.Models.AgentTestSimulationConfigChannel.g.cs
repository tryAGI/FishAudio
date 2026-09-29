
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestSimulationConfigChannel
    {
        /// <summary>
        ///
        /// </summary>
        PhoneInbound,
        /// <summary>
        ///
        /// </summary>
        PhoneOutbound,
        /// <summary>
        ///
        /// </summary>
        WebVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestSimulationConfigChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestSimulationConfigChannel value)
        {
            return value switch
            {
                AgentTestSimulationConfigChannel.PhoneInbound => "phone_inbound",
                AgentTestSimulationConfigChannel.PhoneOutbound => "phone_outbound",
                AgentTestSimulationConfigChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestSimulationConfigChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => AgentTestSimulationConfigChannel.PhoneInbound,
                "phone_outbound" => AgentTestSimulationConfigChannel.PhoneOutbound,
                "web_voice" => AgentTestSimulationConfigChannel.WebVoice,
                _ => null,
            };
        }
    }
}