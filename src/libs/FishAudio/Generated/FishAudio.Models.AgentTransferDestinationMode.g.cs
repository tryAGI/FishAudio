
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: cold
    /// </summary>
    public enum AgentTransferDestinationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Cold,
        /// <summary>
        /// 
        /// </summary>
        Warm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTransferDestinationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationMode value)
        {
            return value switch
            {
                AgentTransferDestinationMode.Cold => "cold",
                AgentTransferDestinationMode.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationMode? ToEnum(string value)
        {
            return value switch
            {
                "cold" => AgentTransferDestinationMode.Cold,
                "warm" => AgentTransferDestinationMode.Warm,
                _ => null,
            };
        }
    }
}