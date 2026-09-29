
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum AgentTestToolMocksFallback
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Real,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestToolMocksFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestToolMocksFallback value)
        {
            return value switch
            {
                AgentTestToolMocksFallback.Error => "error",
                AgentTestToolMocksFallback.Real => "real",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestToolMocksFallback? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentTestToolMocksFallback.Error,
                "real" => AgentTestToolMocksFallback.Real,
                _ => null,
            };
        }
    }
}