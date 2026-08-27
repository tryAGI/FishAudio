
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: confirm
    /// </summary>
    public enum AgentTransferDestinationWarmConnect
    {
        /// <summary>
        ///
        /// </summary>
        Confirm,
        /// <summary>
        ///
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTransferDestinationWarmConnectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationWarmConnect value)
        {
            return value switch
            {
                AgentTransferDestinationWarmConnect.Confirm => "confirm",
                AgentTransferDestinationWarmConnect.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationWarmConnect? ToEnum(string value)
        {
            return value switch
            {
                "confirm" => AgentTransferDestinationWarmConnect.Confirm,
                "direct" => AgentTransferDestinationWarmConnect.Direct,
                _ => null,
            };
        }
    }
}