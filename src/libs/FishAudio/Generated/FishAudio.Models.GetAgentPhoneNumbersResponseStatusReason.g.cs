
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentPhoneNumbersResponseStatusReason
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
    public static class GetAgentPhoneNumbersResponseStatusReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentPhoneNumbersResponseStatusReason value)
        {
            return value switch
            {
                GetAgentPhoneNumbersResponseStatusReason.OutOfCredit => "out_of_credit",
                GetAgentPhoneNumbersResponseStatusReason.ProvisioningFailed => "provisioning_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentPhoneNumbersResponseStatusReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credit" => GetAgentPhoneNumbersResponseStatusReason.OutOfCredit,
                "provisioning_failed" => GetAgentPhoneNumbersResponseStatusReason.ProvisioningFailed,
                _ => null,
            };
        }
    }
}