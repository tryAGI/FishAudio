
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PutAgentPhoneNumbersSipConfigResponseProvider
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
    public static class PutAgentPhoneNumbersSipConfigResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAgentPhoneNumbersSipConfigResponseProvider value)
        {
            return value switch
            {
                PutAgentPhoneNumbersSipConfigResponseProvider.Livekit => "livekit",
                PutAgentPhoneNumbersSipConfigResponseProvider.Sip => "sip",
                PutAgentPhoneNumbersSipConfigResponseProvider.Twilio => "twilio",
                PutAgentPhoneNumbersSipConfigResponseProvider.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAgentPhoneNumbersSipConfigResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => PutAgentPhoneNumbersSipConfigResponseProvider.Livekit,
                "sip" => PutAgentPhoneNumbersSipConfigResponseProvider.Sip,
                "twilio" => PutAgentPhoneNumbersSipConfigResponseProvider.Twilio,
                "whatsapp" => PutAgentPhoneNumbersSipConfigResponseProvider.Whatsapp,
                _ => null,
            };
        }
    }
}