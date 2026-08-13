
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: blocking
    /// </summary>
    public enum PatchAgentToolsResponseExecutionMode
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
    public static class PatchAgentToolsResponseExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentToolsResponseExecutionMode value)
        {
            return value switch
            {
                PatchAgentToolsResponseExecutionMode.Background => "background",
                PatchAgentToolsResponseExecutionMode.Blocking => "blocking",
                PatchAgentToolsResponseExecutionMode.FireAndForget => "fire_and_forget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentToolsResponseExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "background" => PatchAgentToolsResponseExecutionMode.Background,
                "blocking" => PatchAgentToolsResponseExecutionMode.Blocking,
                "fire_and_forget" => PatchAgentToolsResponseExecutionMode.FireAndForget,
                _ => null,
            };
        }
    }
}