
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestUpdatePayloadChannel
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
    public static class PublicAgentTestUpdatePayloadChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestUpdatePayloadChannel value)
        {
            return value switch
            {
                PublicAgentTestUpdatePayloadChannel.PhoneInbound => "phone_inbound",
                PublicAgentTestUpdatePayloadChannel.PhoneOutbound => "phone_outbound",
                PublicAgentTestUpdatePayloadChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestUpdatePayloadChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => PublicAgentTestUpdatePayloadChannel.PhoneInbound,
                "phone_outbound" => PublicAgentTestUpdatePayloadChannel.PhoneOutbound,
                "web_voice" => PublicAgentTestUpdatePayloadChannel.WebVoice,
                _ => null,
            };
        }
    }
}