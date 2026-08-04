
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentPhoneNumbersResponseStatus
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
    public static class CreateAgentPhoneNumbersResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentPhoneNumbersResponseStatus value)
        {
            return value switch
            {
                CreateAgentPhoneNumbersResponseStatus.Active => "active",
                CreateAgentPhoneNumbersResponseStatus.Error => "error",
                CreateAgentPhoneNumbersResponseStatus.Provisioning => "provisioning",
                CreateAgentPhoneNumbersResponseStatus.Released => "released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentPhoneNumbersResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateAgentPhoneNumbersResponseStatus.Active,
                "error" => CreateAgentPhoneNumbersResponseStatus.Error,
                "provisioning" => CreateAgentPhoneNumbersResponseStatus.Provisioning,
                "released" => CreateAgentPhoneNumbersResponseStatus.Released,
                _ => null,
            };
        }
    }
}