
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsResponseTestType
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
    public static class GetAgentTestRunsResponseTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsResponseTestType value)
        {
            return value switch
            {
                GetAgentTestRunsResponseTestType.NextReply => "next_reply",
                GetAgentTestRunsResponseTestType.Simulation => "simulation",
                GetAgentTestRunsResponseTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsResponseTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => GetAgentTestRunsResponseTestType.NextReply,
                "simulation" => GetAgentTestRunsResponseTestType.Simulation,
                "tool" => GetAgentTestRunsResponseTestType.Tool,
                _ => null,
            };
        }
    }
}