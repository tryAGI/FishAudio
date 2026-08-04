
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicPhoneNumberEntityProvider
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
    public static class PublicPhoneNumberEntityProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberEntityProvider value)
        {
            return value switch
            {
                PublicPhoneNumberEntityProvider.Livekit => "livekit",
                PublicPhoneNumberEntityProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberEntityProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => PublicPhoneNumberEntityProvider.Livekit,
                "twilio" => PublicPhoneNumberEntityProvider.Twilio,
                _ => null,
            };
        }
    }
}