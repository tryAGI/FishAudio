
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestsTestType
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
    public static class GetAgentTestsTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestsTestType value)
        {
            return value switch
            {
                GetAgentTestsTestType.NextReply => "next_reply",
                GetAgentTestsTestType.Simulation => "simulation",
                GetAgentTestsTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestsTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => GetAgentTestsTestType.NextReply,
                "simulation" => GetAgentTestsTestType.Simulation,
                "tool" => GetAgentTestsTestType.Tool,
                _ => null,
            };
        }
    }
}