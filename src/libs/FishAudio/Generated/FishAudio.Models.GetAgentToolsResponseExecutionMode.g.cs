
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: blocking
    /// </summary>
    public enum GetAgentToolsResponseExecutionMode
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
    public static class GetAgentToolsResponseExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentToolsResponseExecutionMode value)
        {
            return value switch
            {
                GetAgentToolsResponseExecutionMode.Background => "background",
                GetAgentToolsResponseExecutionMode.Blocking => "blocking",
                GetAgentToolsResponseExecutionMode.FireAndForget => "fire_and_forget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentToolsResponseExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "background" => GetAgentToolsResponseExecutionMode.Background,
                "blocking" => GetAgentToolsResponseExecutionMode.Blocking,
                "fire_and_forget" => GetAgentToolsResponseExecutionMode.FireAndForget,
                _ => null,
            };
        }
    }
}