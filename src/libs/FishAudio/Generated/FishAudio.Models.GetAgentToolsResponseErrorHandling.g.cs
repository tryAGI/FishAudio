
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentToolsResponseErrorHandling
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
    public static class GetAgentToolsResponseErrorHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentToolsResponseErrorHandling value)
        {
            return value switch
            {
                GetAgentToolsResponseErrorHandling.Hide => "hide",
                GetAgentToolsResponseErrorHandling.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentToolsResponseErrorHandling? ToEnum(string value)
        {
            return value switch
            {
                "hide" => GetAgentToolsResponseErrorHandling.Hide,
                "passthrough" => GetAgentToolsResponseErrorHandling.Passthrough,
                _ => null,
            };
        }
    }
}