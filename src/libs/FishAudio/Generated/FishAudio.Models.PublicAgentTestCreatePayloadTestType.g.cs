
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: next_reply
    /// </summary>
    public enum PublicAgentTestCreatePayloadTestType
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
    public static class PublicAgentTestCreatePayloadTestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentTestCreatePayloadTestType value)
        {
            return value switch
            {
                PublicAgentTestCreatePayloadTestType.NextReply => "next_reply",
                PublicAgentTestCreatePayloadTestType.Simulation => "simulation",
                PublicAgentTestCreatePayloadTestType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentTestCreatePayloadTestType? ToEnum(string value)
        {
            return value switch
            {
                "next_reply" => PublicAgentTestCreatePayloadTestType.NextReply,
                "simulation" => PublicAgentTestCreatePayloadTestType.Simulation,
                "tool" => PublicAgentTestCreatePayloadTestType.Tool,
                _ => null,
            };
        }
    }
}