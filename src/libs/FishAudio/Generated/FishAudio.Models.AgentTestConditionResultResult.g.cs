
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestConditionResultResult
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestConditionResultResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestConditionResultResult value)
        {
            return value switch
            {
                AgentTestConditionResultResult.Failure => "failure",
                AgentTestConditionResultResult.Success => "success",
                AgentTestConditionResultResult.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestConditionResultResult? ToEnum(string value)
        {
            return value switch
            {
                "failure" => AgentTestConditionResultResult.Failure,
                "success" => AgentTestConditionResultResult.Success,
                "unknown" => AgentTestConditionResultResult.Unknown,
                _ => null,
            };
        }
    }
}