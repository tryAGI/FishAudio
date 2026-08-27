
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentPhoneNumbersResponseProvider
    {
        /// <summary>
        ///
        /// </summary>
        Livekit,
        /// <summary>
        ///
        /// </summary>
        Sip,
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentPhoneNumbersResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentPhoneNumbersResponseProvider value)
        {
            return value switch
            {
                GetAgentPhoneNumbersResponseProvider.Livekit => "livekit",
                GetAgentPhoneNumbersResponseProvider.Sip => "sip",
                GetAgentPhoneNumbersResponseProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentPhoneNumbersResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => GetAgentPhoneNumbersResponseProvider.Livekit,
                "sip" => GetAgentPhoneNumbersResponseProvider.Sip,
                "twilio" => GetAgentPhoneNumbersResponseProvider.Twilio,
                _ => null,
            };
        }
    }
}