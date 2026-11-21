
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PutAgentPhoneNumbersSipConfigResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Provisioning,
        /// <summary>
        ///
        /// </summary>
        Released,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutAgentPhoneNumbersSipConfigResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAgentPhoneNumbersSipConfigResponseStatus value)
        {
            return value switch
            {
                PutAgentPhoneNumbersSipConfigResponseStatus.Active => "active",
                PutAgentPhoneNumbersSipConfigResponseStatus.Error => "error",
                PutAgentPhoneNumbersSipConfigResponseStatus.Provisioning => "provisioning",
                PutAgentPhoneNumbersSipConfigResponseStatus.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAgentPhoneNumbersSipConfigResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PutAgentPhoneNumbersSipConfigResponseStatus.Active,
                "error" => PutAgentPhoneNumbersSipConfigResponseStatus.Error,
                "provisioning" => PutAgentPhoneNumbersSipConfigResponseStatus.Provisioning,
                "released" => PutAgentPhoneNumbersSipConfigResponseStatus.Released,
                _ => null,
            };
        }
    }
}