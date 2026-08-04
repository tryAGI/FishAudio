
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAgentToolsResponseErrorHandling
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
    public static class PatchAgentToolsResponseErrorHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentToolsResponseErrorHandling value)
        {
            return value switch
            {
                PatchAgentToolsResponseErrorHandling.Hide => "hide",
                PatchAgentToolsResponseErrorHandling.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentToolsResponseErrorHandling? ToEnum(string value)
        {
            return value switch
            {
                "hide" => PatchAgentToolsResponseErrorHandling.Hide,
                "passthrough" => PatchAgentToolsResponseErrorHandling.Passthrough,
                _ => null,
            };
        }
    }
}