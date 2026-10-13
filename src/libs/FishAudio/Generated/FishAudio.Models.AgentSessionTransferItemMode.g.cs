
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemMode
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
    public static class AgentSessionTransferItemModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemMode value)
        {
            return value switch
            {
                AgentSessionTransferItemMode.Cold => "cold",
                AgentSessionTransferItemMode.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemMode? ToEnum(string value)
        {
            return value switch
            {
                "cold" => AgentSessionTransferItemMode.Cold,
                "warm" => AgentSessionTransferItemMode.Warm,
                _ => null,
            };
        }
    }
}