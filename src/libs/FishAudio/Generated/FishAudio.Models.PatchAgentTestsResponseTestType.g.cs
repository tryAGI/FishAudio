
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentTestsResponseTestType
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
    public static class PatchAgentTestsResponseTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentTestsResponseTestType value)
        {
            return value switch
            {
                PatchAgentTestsResponseTestType.NextReply => "next_reply",
                PatchAgentTestsResponseTestType.Simulation => "simulation",
                PatchAgentTestsResponseTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentTestsResponseTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PatchAgentTestsResponseTestType.NextReply,
                "simulation" => PatchAgentTestsResponseTestType.Simulation,
                "tool" => PatchAgentTestsResponseTestType.Tool,
                _ => null,
            };
        }
    }
}