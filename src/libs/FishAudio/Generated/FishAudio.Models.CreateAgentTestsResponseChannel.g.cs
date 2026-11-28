
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentTestsResponseChannel
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
    public static class CreateAgentTestsResponseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentTestsResponseChannel value)
        {
            return value switch
            {
                CreateAgentTestsResponseChannel.PhoneInbound => "phone_inbound",
                CreateAgentTestsResponseChannel.PhoneOutbound => "phone_outbound",
                CreateAgentTestsResponseChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentTestsResponseChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => CreateAgentTestsResponseChannel.PhoneInbound,
                "phone_outbound" => CreateAgentTestsResponseChannel.PhoneOutbound,
                "web_voice" => CreateAgentTestsResponseChannel.WebVoice,
                _ => null,
            };
        }
    }
}