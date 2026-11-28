
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestToolChannel
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
    public static class PublicAgentTestToolChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestToolChannel value)
        {
            return value switch
            {
                PublicAgentTestToolChannel.PhoneInbound => "phone_inbound",
                PublicAgentTestToolChannel.PhoneOutbound => "phone_outbound",
                PublicAgentTestToolChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestToolChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => PublicAgentTestToolChannel.PhoneInbound,
                "phone_outbound" => PublicAgentTestToolChannel.PhoneOutbound,
                "web_voice" => PublicAgentTestToolChannel.WebVoice,
                _ => null,
            };
        }
    }
}