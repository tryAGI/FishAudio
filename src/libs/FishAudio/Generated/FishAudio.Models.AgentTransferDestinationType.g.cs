
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: phone
    /// </summary>
    public enum AgentTransferDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTransferDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationType value)
        {
            return value switch
            {
                AgentTransferDestinationType.Phone => "phone",
                AgentTransferDestinationType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => AgentTransferDestinationType.Phone,
                "sip" => AgentTransferDestinationType.Sip,
                _ => null,
            };
        }
    }
}