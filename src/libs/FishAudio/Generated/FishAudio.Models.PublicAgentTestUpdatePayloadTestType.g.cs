
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentTestUpdatePayloadTestType
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
    public static class PublicAgentTestUpdatePayloadTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestUpdatePayloadTestType value)
        {
            return value switch
            {
                PublicAgentTestUpdatePayloadTestType.NextReply => "next_reply",
                PublicAgentTestUpdatePayloadTestType.Simulation => "simulation",
                PublicAgentTestUpdatePayloadTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestUpdatePayloadTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PublicAgentTestUpdatePayloadTestType.NextReply,
                "simulation" => PublicAgentTestUpdatePayloadTestType.Simulation,
                "tool" => PublicAgentTestUpdatePayloadTestType.Tool,
                _ => null,
            };
        }
    }
}