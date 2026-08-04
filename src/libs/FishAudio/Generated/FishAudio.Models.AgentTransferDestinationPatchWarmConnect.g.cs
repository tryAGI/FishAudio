
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: confirm
    /// </summary>
    public enum AgentTransferDestinationPatchWarmConnect
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
    public static class AgentTransferDestinationPatchWarmConnectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationPatchWarmConnect value)
        {
            return value switch
            {
                AgentTransferDestinationPatchWarmConnect.Confirm => "confirm",
                AgentTransferDestinationPatchWarmConnect.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationPatchWarmConnect? ToEnum(string value)
        {
            return value switch
            {
                "confirm" => AgentTransferDestinationPatchWarmConnect.Confirm,
                "direct" => AgentTransferDestinationPatchWarmConnect.Direct,
                _ => null,
            };
        }
    }
}