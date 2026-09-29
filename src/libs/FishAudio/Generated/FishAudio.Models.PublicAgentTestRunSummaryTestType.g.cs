
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunSummaryTestType
    {
        /// <summary>
        ///
        /// </summary>
        NextReply,
        /// <summary>
        ///
        /// </summary>
        Simulation,
        /// <summary>
        ///
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentTestRunSummaryTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunSummaryTestType value)
        {
            return value switch
            {
                PublicAgentTestRunSummaryTestType.NextReply => "next_reply",
                PublicAgentTestRunSummaryTestType.Simulation => "simulation",
                PublicAgentTestRunSummaryTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunSummaryTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PublicAgentTestRunSummaryTestType.NextReply,
                "simulation" => PublicAgentTestRunSummaryTestType.Simulation,
                "tool" => PublicAgentTestRunSummaryTestType.Tool,
                _ => null,
            };
        }
    }
}