
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestCreatePayloadChannel
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
    public static class PublicAgentTestCreatePayloadChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestCreatePayloadChannel value)
        {
            return value switch
            {
                PublicAgentTestCreatePayloadChannel.PhoneInbound => "phone_inbound",
                PublicAgentTestCreatePayloadChannel.PhoneOutbound => "phone_outbound",
                PublicAgentTestCreatePayloadChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestCreatePayloadChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => PublicAgentTestCreatePayloadChannel.PhoneInbound,
                "phone_outbound" => PublicAgentTestCreatePayloadChannel.PhoneOutbound,
                "web_voice" => PublicAgentTestCreatePayloadChannel.WebVoice,
                _ => null,
            };
        }
    }
}