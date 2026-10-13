
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemDestinationType
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
    public static class AgentSessionTransferItemDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemDestinationType value)
        {
            return value switch
            {
                AgentSessionTransferItemDestinationType.Phone => "phone",
                AgentSessionTransferItemDestinationType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => AgentSessionTransferItemDestinationType.Phone,
                "sip" => AgentSessionTransferItemDestinationType.Sip,
                _ => null,
            };
        }
    }
}