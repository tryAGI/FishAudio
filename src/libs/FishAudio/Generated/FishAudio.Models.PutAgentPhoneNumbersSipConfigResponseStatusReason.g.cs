
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PutAgentPhoneNumbersSipConfigResponseStatusReason
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
    public static class PutAgentPhoneNumbersSipConfigResponseStatusReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAgentPhoneNumbersSipConfigResponseStatusReason value)
        {
            return value switch
            {
                PutAgentPhoneNumbersSipConfigResponseStatusReason.OutOfCredit => "out_of_credit",
                PutAgentPhoneNumbersSipConfigResponseStatusReason.ProvisioningFailed => "provisioning_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAgentPhoneNumbersSipConfigResponseStatusReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credit" => PutAgentPhoneNumbersSipConfigResponseStatusReason.OutOfCredit,
                "provisioning_failed" => PutAgentPhoneNumbersSipConfigResponseStatusReason.ProvisioningFailed,
                _ => null,
            };
        }
    }
}