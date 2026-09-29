
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunChannel
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
    public static class PublicAgentTestRunChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunChannel value)
        {
            return value switch
            {
                PublicAgentTestRunChannel.PhoneInbound => "phone_inbound",
                PublicAgentTestRunChannel.PhoneOutbound => "phone_outbound",
                PublicAgentTestRunChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => PublicAgentTestRunChannel.PhoneInbound,
                "phone_outbound" => PublicAgentTestRunChannel.PhoneOutbound,
                "web_voice" => PublicAgentTestRunChannel.WebVoice,
                _ => null,
            };
        }
    }
}