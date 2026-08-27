
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: passthrough
    /// </summary>
    public enum PublicAgentToolCreatePayloadErrorHandling
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
    public static class PublicAgentToolCreatePayloadErrorHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolCreatePayloadErrorHandling value)
        {
            return value switch
            {
                PublicAgentToolCreatePayloadErrorHandling.Hide => "hide",
                PublicAgentToolCreatePayloadErrorHandling.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolCreatePayloadErrorHandling? ToEnum(string value)
        {
            return value switch
            {
                "hide" => PublicAgentToolCreatePayloadErrorHandling.Hide,
                "passthrough" => PublicAgentToolCreatePayloadErrorHandling.Passthrough,
                _ => null,
            };
        }
    }
}