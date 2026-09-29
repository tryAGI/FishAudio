
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsResponseChannel
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
    public static class GetAgentTestRunsResponseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsResponseChannel value)
        {
            return value switch
            {
                GetAgentTestRunsResponseChannel.PhoneInbound => "phone_inbound",
                GetAgentTestRunsResponseChannel.PhoneOutbound => "phone_outbound",
                GetAgentTestRunsResponseChannel.WebVoice => "web_voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsResponseChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone_inbound" => GetAgentTestRunsResponseChannel.PhoneInbound,
                "phone_outbound" => GetAgentTestRunsResponseChannel.PhoneOutbound,
                "web_voice" => GetAgentTestRunsResponseChannel.WebVoice,
                _ => null,
            };
        }
    }
}