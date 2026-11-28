
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentTestsResponseChannel
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
    public static class PatchAgentTestsResponseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentTestsResponseChannel value)
        {
            return value switch
            {
                PatchAgentTestsResponseChannel.PhoneInbound => "phone_inbound",
                PatchAgentTestsResponseChannel.PhoneOutbound => "phone_outbound",
                PatchAgentTestsResponseChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentTestsResponseChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => PatchAgentTestsResponseChannel.PhoneInbound,
                "phone_outbound" => PatchAgentTestsResponseChannel.PhoneOutbound,
                "web_voice" => PatchAgentTestsResponseChannel.WebVoice,
                _ => null,
            };
        }
    }
}