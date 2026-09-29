
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentTestsResponseTestType
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
    public static class CreateAgentTestsResponseTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentTestsResponseTestType value)
        {
            return value switch
            {
                CreateAgentTestsResponseTestType.NextReply => "next_reply",
                CreateAgentTestsResponseTestType.Simulation => "simulation",
                CreateAgentTestsResponseTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentTestsResponseTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => CreateAgentTestsResponseTestType.NextReply,
                "simulation" => CreateAgentTestsResponseTestType.Simulation,
                "tool" => CreateAgentTestsResponseTestType.Tool,
                _ => null,
            };
        }
    }
}