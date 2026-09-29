
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum AgentTestToolMocksStrategy
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestToolMocksStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestToolMocksStrategy value)
        {
            return value switch
            {
                AgentTestToolMocksStrategy.All => "all",
                AgentTestToolMocksStrategy.None => "none",
                AgentTestToolMocksStrategy.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestToolMocksStrategy? ToEnum(string value)
        {
            return value switch
            {
                "all" => AgentTestToolMocksStrategy.All,
                "none" => AgentTestToolMocksStrategy.None,
                "selected" => AgentTestToolMocksStrategy.Selected,
                _ => null,
            };
        }
    }
}