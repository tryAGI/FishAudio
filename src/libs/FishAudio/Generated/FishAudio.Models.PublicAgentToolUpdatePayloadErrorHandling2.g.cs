
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentToolUpdatePayloadErrorHandling2
    {
        /// <summary>
        /// 
        /// </summary>
        Hide,
        /// <summary>
        /// 
        /// </summary>
        Passthrough,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentToolUpdatePayloadErrorHandling2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolUpdatePayloadErrorHandling2 value)
        {
            return value switch
            {
                PublicAgentToolUpdatePayloadErrorHandling2.Hide => "hide",
                PublicAgentToolUpdatePayloadErrorHandling2.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolUpdatePayloadErrorHandling2? ToEnum(string value)
        {
            return value switch
            {
                "hide" => PublicAgentToolUpdatePayloadErrorHandling2.Hide,
                "passthrough" => PublicAgentToolUpdatePayloadErrorHandling2.Passthrough,
                _ => null,
            };
        }
    }
}