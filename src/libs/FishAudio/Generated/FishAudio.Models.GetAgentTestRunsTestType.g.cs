
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestRunsTestType
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
    public static class GetAgentTestRunsTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestRunsTestType value)
        {
            return value switch
            {
                GetAgentTestRunsTestType.NextReply => "next_reply",
                GetAgentTestRunsTestType.Simulation => "simulation",
                GetAgentTestRunsTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestRunsTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => GetAgentTestRunsTestType.NextReply,
                "simulation" => GetAgentTestRunsTestType.Simulation,
                "tool" => GetAgentTestRunsTestType.Tool,
                _ => null,
            };
        }
    }
}