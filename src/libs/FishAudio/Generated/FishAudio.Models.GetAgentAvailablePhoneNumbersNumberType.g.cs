
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: local
    /// </summary>
    public enum GetAgentAvailablePhoneNumbersNumberType
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        TollFree,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentAvailablePhoneNumbersNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAvailablePhoneNumbersNumberType value)
        {
            return value switch
            {
                GetAgentAvailablePhoneNumbersNumberType.Local => "local",
                GetAgentAvailablePhoneNumbersNumberType.TollFree => "toll_free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAvailablePhoneNumbersNumberType? ToEnum(string value)
        {
            return value switch
            {
                "local" => GetAgentAvailablePhoneNumbersNumberType.Local,
                "toll_free" => GetAgentAvailablePhoneNumbersNumberType.TollFree,
                _ => null,
            };
        }
    }
}