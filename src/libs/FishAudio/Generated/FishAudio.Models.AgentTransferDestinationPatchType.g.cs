
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: phone
    /// </summary>
    public enum AgentTransferDestinationPatchType
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
    public static class AgentTransferDestinationPatchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationPatchType value)
        {
            return value switch
            {
                AgentTransferDestinationPatchType.Phone => "phone",
                AgentTransferDestinationPatchType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationPatchType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => AgentTransferDestinationPatchType.Phone,
                "sip" => AgentTransferDestinationPatchType.Sip,
                _ => null,
            };
        }
    }
}