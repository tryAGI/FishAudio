
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentToolUpdatePayloadErrorHandling
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
    public static class PublicAgentToolUpdatePayloadErrorHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolUpdatePayloadErrorHandling value)
        {
            return value switch
            {
                PublicAgentToolUpdatePayloadErrorHandling.Hide => "hide",
                PublicAgentToolUpdatePayloadErrorHandling.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolUpdatePayloadErrorHandling? ToEnum(string value)
        {
            return value switch
            {
                "hide" => PublicAgentToolUpdatePayloadErrorHandling.Hide,
                "passthrough" => PublicAgentToolUpdatePayloadErrorHandling.Passthrough,
                _ => null,
            };
        }
    }
}