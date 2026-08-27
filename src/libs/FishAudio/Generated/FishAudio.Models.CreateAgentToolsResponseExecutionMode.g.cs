
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: blocking
    /// </summary>
    public enum CreateAgentToolsResponseExecutionMode
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
    public static class CreateAgentToolsResponseExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentToolsResponseExecutionMode value)
        {
            return value switch
            {
                CreateAgentToolsResponseExecutionMode.Background => "background",
                CreateAgentToolsResponseExecutionMode.Blocking => "blocking",
                CreateAgentToolsResponseExecutionMode.FireAndForget => "fire_and_forget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentToolsResponseExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "background" => CreateAgentToolsResponseExecutionMode.Background,
                "blocking" => CreateAgentToolsResponseExecutionMode.Blocking,
                "fire_and_forget" => CreateAgentToolsResponseExecutionMode.FireAndForget,
                _ => null,
            };
        }
    }
}