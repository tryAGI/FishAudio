
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentPhoneNumbersResponseStatus
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
    public static class GetAgentPhoneNumbersResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentPhoneNumbersResponseStatus value)
        {
            return value switch
            {
                GetAgentPhoneNumbersResponseStatus.Active => "active",
                GetAgentPhoneNumbersResponseStatus.Error => "error",
                GetAgentPhoneNumbersResponseStatus.Provisioning => "provisioning",
                GetAgentPhoneNumbersResponseStatus.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentPhoneNumbersResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetAgentPhoneNumbersResponseStatus.Active,
                "error" => GetAgentPhoneNumbersResponseStatus.Error,
                "provisioning" => GetAgentPhoneNumbersResponseStatus.Provisioning,
                "released" => GetAgentPhoneNumbersResponseStatus.Released,
                _ => null,
            };
        }
    }
}