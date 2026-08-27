
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicPhoneNumberEntityStatus
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
    public static class PublicPhoneNumberEntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberEntityStatus value)
        {
            return value switch
            {
                PublicPhoneNumberEntityStatus.Active => "active",
                PublicPhoneNumberEntityStatus.Error => "error",
                PublicPhoneNumberEntityStatus.Provisioning => "provisioning",
                PublicPhoneNumberEntityStatus.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberEntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PublicPhoneNumberEntityStatus.Active,
                "error" => PublicPhoneNumberEntityStatus.Error,
                "provisioning" => PublicPhoneNumberEntityStatus.Provisioning,
                "released" => PublicPhoneNumberEntityStatus.Released,
                _ => null,
            };
        }
    }
}