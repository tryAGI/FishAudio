
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentPhoneNumbersResponseStatus
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
    public static class PatchAgentPhoneNumbersResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentPhoneNumbersResponseStatus value)
        {
            return value switch
            {
                PatchAgentPhoneNumbersResponseStatus.Active => "active",
                PatchAgentPhoneNumbersResponseStatus.Error => "error",
                PatchAgentPhoneNumbersResponseStatus.Provisioning => "provisioning",
                PatchAgentPhoneNumbersResponseStatus.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentPhoneNumbersResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PatchAgentPhoneNumbersResponseStatus.Active,
                "error" => PatchAgentPhoneNumbersResponseStatus.Error,
                "provisioning" => PatchAgentPhoneNumbersResponseStatus.Provisioning,
                "released" => PatchAgentPhoneNumbersResponseStatus.Released,
                _ => null,
            };
        }
    }
}