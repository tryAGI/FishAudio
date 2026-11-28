
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentPhoneNumbersResponseStatusReason
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
    public static class PatchAgentPhoneNumbersResponseStatusReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentPhoneNumbersResponseStatusReason value)
        {
            return value switch
            {
                PatchAgentPhoneNumbersResponseStatusReason.OutOfCredit => "out_of_credit",
                PatchAgentPhoneNumbersResponseStatusReason.ProvisioningFailed => "provisioning_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentPhoneNumbersResponseStatusReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credit" => PatchAgentPhoneNumbersResponseStatusReason.OutOfCredit,
                "provisioning_failed" => PatchAgentPhoneNumbersResponseStatusReason.ProvisioningFailed,
                _ => null,
            };
        }
    }
}