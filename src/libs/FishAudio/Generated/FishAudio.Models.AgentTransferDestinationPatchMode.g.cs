
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: cold
    /// </summary>
    public enum AgentTransferDestinationPatchMode
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
    public static class AgentTransferDestinationPatchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationPatchMode value)
        {
            return value switch
            {
                AgentTransferDestinationPatchMode.Cold => "cold",
                AgentTransferDestinationPatchMode.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationPatchMode? ToEnum(string value)
        {
            return value switch
            {
                "cold" => AgentTransferDestinationPatchMode.Cold,
                "warm" => AgentTransferDestinationPatchMode.Warm,
                _ => null,
            };
        }
    }
}