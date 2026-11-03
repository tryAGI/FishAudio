
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentPhoneNumbersResponseProvider
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
        /// <summary>
        ///
        /// </summary>
        Whatsapp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAgentPhoneNumbersResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentPhoneNumbersResponseProvider value)
        {
            return value switch
            {
                PatchAgentPhoneNumbersResponseProvider.Livekit => "livekit",
                PatchAgentPhoneNumbersResponseProvider.Sip => "sip",
                PatchAgentPhoneNumbersResponseProvider.Twilio => "twilio",
                PatchAgentPhoneNumbersResponseProvider.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentPhoneNumbersResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => PatchAgentPhoneNumbersResponseProvider.Livekit,
                "sip" => PatchAgentPhoneNumbersResponseProvider.Sip,
                "twilio" => PatchAgentPhoneNumbersResponseProvider.Twilio,
                "whatsapp" => PatchAgentPhoneNumbersResponseProvider.Whatsapp,
                _ => null,
            };
        }
    }
}