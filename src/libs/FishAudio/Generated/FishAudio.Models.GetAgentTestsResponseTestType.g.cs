
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentTestsResponseTestType
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
    public static class GetAgentTestsResponseTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentTestsResponseTestType value)
        {
            return value switch
            {
                GetAgentTestsResponseTestType.NextReply => "next_reply",
                GetAgentTestsResponseTestType.Simulation => "simulation",
                GetAgentTestsResponseTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentTestsResponseTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => GetAgentTestsResponseTestType.NextReply,
                "simulation" => GetAgentTestsResponseTestType.Simulation,
                "tool" => GetAgentTestsResponseTestType.Tool,
                _ => null,
            };
        }
    }
}