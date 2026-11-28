
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicPhoneNumberEntityStatusReason
    {
        /// <summary>
        ///
        /// </summary>
        OutOfCredit,
        /// <summary>
        ///
        /// </summary>
        ProvisioningFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicPhoneNumberEntityStatusReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberEntityStatusReason value)
        {
            return value switch
            {
                PublicPhoneNumberEntityStatusReason.OutOfCredit => "out_of_credit",
                PublicPhoneNumberEntityStatusReason.ProvisioningFailed => "provisioning_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberEntityStatusReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credit" => PublicPhoneNumberEntityStatusReason.OutOfCredit,
                "provisioning_failed" => PublicPhoneNumberEntityStatusReason.ProvisioningFailed,
                _ => null,
            };
        }
    }
}