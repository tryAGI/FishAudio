
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestSummaryTestType
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
    public static class PublicAgentTestSummaryTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestSummaryTestType value)
        {
            return value switch
            {
                PublicAgentTestSummaryTestType.NextReply => "next_reply",
                PublicAgentTestSummaryTestType.Simulation => "simulation",
                PublicAgentTestSummaryTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestSummaryTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PublicAgentTestSummaryTestType.NextReply,
                "simulation" => PublicAgentTestSummaryTestType.Simulation,
                "tool" => PublicAgentTestSummaryTestType.Tool,
                _ => null,
            };
        }
    }
}