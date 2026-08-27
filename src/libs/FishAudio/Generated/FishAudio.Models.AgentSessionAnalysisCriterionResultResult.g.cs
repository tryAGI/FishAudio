
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionAnalysisCriterionResultResult
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
    public static class AgentSessionAnalysisCriterionResultResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionAnalysisCriterionResultResult value)
        {
            return value switch
            {
                AgentSessionAnalysisCriterionResultResult.Failure => "failure",
                AgentSessionAnalysisCriterionResultResult.Success => "success",
                AgentSessionAnalysisCriterionResultResult.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionAnalysisCriterionResultResult? ToEnum(string value)
        {
            return value switch
            {
                "failure" => AgentSessionAnalysisCriterionResultResult.Failure,
                "success" => AgentSessionAnalysisCriterionResultResult.Success,
                "unknown" => AgentSessionAnalysisCriterionResultResult.Unknown,
                _ => null,
            };
        }
    }
}