
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestRunTestType
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
    public static class PublicAgentTestRunTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestRunTestType value)
        {
            return value switch
            {
                PublicAgentTestRunTestType.NextReply => "next_reply",
                PublicAgentTestRunTestType.Simulation => "simulation",
                PublicAgentTestRunTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestRunTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PublicAgentTestRunTestType.NextReply,
                "simulation" => PublicAgentTestRunTestType.Simulation,
                "tool" => PublicAgentTestRunTestType.Tool,
                _ => null,
            };
        }
    }
}