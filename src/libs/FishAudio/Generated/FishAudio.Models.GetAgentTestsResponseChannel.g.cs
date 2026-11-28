
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestsResponseChannel
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
    public static class GetAgentTestsResponseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestsResponseChannel value)
        {
            return value switch
            {
                GetAgentTestsResponseChannel.PhoneInbound => "phone_inbound",
                GetAgentTestsResponseChannel.PhoneOutbound => "phone_outbound",
                GetAgentTestsResponseChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestsResponseChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => GetAgentTestsResponseChannel.PhoneInbound,
                "phone_outbound" => GetAgentTestsResponseChannel.PhoneOutbound,
                "web_voice" => GetAgentTestsResponseChannel.WebVoice,
                _ => null,
            };
        }
    }
}