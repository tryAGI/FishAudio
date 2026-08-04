
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
        Twilio,
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
                PatchAgentPhoneNumbersResponseProvider.Twilio => "twilio",
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
                "twilio" => PatchAgentPhoneNumbersResponseProvider.Twilio,
                _ => null,
            };
        }
    }
}