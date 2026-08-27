
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentPhoneNumbersResponseProvider
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
    public static class CreateAgentPhoneNumbersResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentPhoneNumbersResponseProvider value)
        {
            return value switch
            {
                CreateAgentPhoneNumbersResponseProvider.Livekit => "livekit",
                CreateAgentPhoneNumbersResponseProvider.Sip => "sip",
                CreateAgentPhoneNumbersResponseProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentPhoneNumbersResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => CreateAgentPhoneNumbersResponseProvider.Livekit,
                "sip" => CreateAgentPhoneNumbersResponseProvider.Sip,
                "twilio" => CreateAgentPhoneNumbersResponseProvider.Twilio,
                _ => null,
            };
        }
    }
}