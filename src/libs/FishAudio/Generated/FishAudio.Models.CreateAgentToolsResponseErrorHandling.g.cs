
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentToolsResponseErrorHandling
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
    public static class CreateAgentToolsResponseErrorHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentToolsResponseErrorHandling value)
        {
            return value switch
            {
                CreateAgentToolsResponseErrorHandling.Hide => "hide",
                CreateAgentToolsResponseErrorHandling.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentToolsResponseErrorHandling? ToEnum(string value)
        {
            return value switch
            {
                "hide" => CreateAgentToolsResponseErrorHandling.Hide,
                "passthrough" => CreateAgentToolsResponseErrorHandling.Passthrough,
                _ => null,
            };
        }
    }
}