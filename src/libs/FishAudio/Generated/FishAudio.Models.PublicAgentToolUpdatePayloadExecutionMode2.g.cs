
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentToolUpdatePayloadExecutionMode2
    {
        /// <summary>
        ///
        /// </summary>
        Background,
        /// <summary>
        ///
        /// </summary>
        Blocking,
        /// <summary>
        ///
        /// </summary>
        FireAndForget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentToolUpdatePayloadExecutionMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolUpdatePayloadExecutionMode2 value)
        {
            return value switch
            {
                PublicAgentToolUpdatePayloadExecutionMode2.Background => "background",
                PublicAgentToolUpdatePayloadExecutionMode2.Blocking => "blocking",
                PublicAgentToolUpdatePayloadExecutionMode2.FireAndForget => "fire_and_forget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolUpdatePayloadExecutionMode2? ToEnum(string value)
        {
            return value switch
            {
                "background" => PublicAgentToolUpdatePayloadExecutionMode2.Background,
                "blocking" => PublicAgentToolUpdatePayloadExecutionMode2.Blocking,
                "fire_and_forget" => PublicAgentToolUpdatePayloadExecutionMode2.FireAndForget,
                _ => null,
            };
        }
    }
}