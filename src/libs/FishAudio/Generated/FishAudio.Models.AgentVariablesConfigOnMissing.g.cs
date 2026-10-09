
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: keep
    /// </summary>
    public enum AgentVariablesConfigOnMissing
    {
        /// <summary>
        ///
        /// </summary>
        Empty,
        /// <summary>
        ///
        /// </summary>
        Keep,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentVariablesConfigOnMissingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVariablesConfigOnMissing value)
        {
            return value switch
            {
                AgentVariablesConfigOnMissing.Empty => "empty",
                AgentVariablesConfigOnMissing.Keep => "keep",
                AgentVariablesConfigOnMissing.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVariablesConfigOnMissing? ToEnum(string value)
        {
            return value switch
            {
                "empty" => AgentVariablesConfigOnMissing.Empty,
                "keep" => AgentVariablesConfigOnMissing.Keep,
                "reject" => AgentVariablesConfigOnMissing.Reject,
                _ => null,
            };
        }
    }
}