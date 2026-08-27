
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: blocking
    /// </summary>
    public enum PublicAgentToolCreatePayloadExecutionMode
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
    public static class PublicAgentToolCreatePayloadExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolCreatePayloadExecutionMode value)
        {
            return value switch
            {
                PublicAgentToolCreatePayloadExecutionMode.Background => "background",
                PublicAgentToolCreatePayloadExecutionMode.Blocking => "blocking",
                PublicAgentToolCreatePayloadExecutionMode.FireAndForget => "fire_and_forget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolCreatePayloadExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "background" => PublicAgentToolCreatePayloadExecutionMode.Background,
                "blocking" => PublicAgentToolCreatePayloadExecutionMode.Blocking,
                "fire_and_forget" => PublicAgentToolCreatePayloadExecutionMode.FireAndForget,
                _ => null,
            };
        }
    }
}