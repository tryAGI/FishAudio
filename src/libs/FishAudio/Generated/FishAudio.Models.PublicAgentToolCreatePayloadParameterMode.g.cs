
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentToolCreatePayloadParameterMode
    {
        /// <summary>
        ///
        /// </summary>
        Legacy,
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentToolCreatePayloadParameterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolCreatePayloadParameterMode value)
        {
            return value switch
            {
                PublicAgentToolCreatePayloadParameterMode.Legacy => "legacy",
                PublicAgentToolCreatePayloadParameterMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolCreatePayloadParameterMode? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => PublicAgentToolCreatePayloadParameterMode.Legacy,
                "strict" => PublicAgentToolCreatePayloadParameterMode.Strict,
                _ => null,
            };
        }
    }
}