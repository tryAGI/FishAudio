
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentPhoneNumbersResponseStatusReason
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
    public static class CreateAgentPhoneNumbersResponseStatusReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentPhoneNumbersResponseStatusReason value)
        {
            return value switch
            {
                CreateAgentPhoneNumbersResponseStatusReason.OutOfCredit => "out_of_credit",
                CreateAgentPhoneNumbersResponseStatusReason.ProvisioningFailed => "provisioning_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentPhoneNumbersResponseStatusReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credit" => CreateAgentPhoneNumbersResponseStatusReason.OutOfCredit,
                "provisioning_failed" => CreateAgentPhoneNumbersResponseStatusReason.ProvisioningFailed,
                _ => null,
            };
        }
    }
}