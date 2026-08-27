
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentToolsResponseToolType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAgentToolsResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentToolsResponseToolType value)
        {
            return value switch
            {
                PatchAgentToolsResponseToolType.Client => "client",
                PatchAgentToolsResponseToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentToolsResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PatchAgentToolsResponseToolType.Client,
                "webhook" => PatchAgentToolsResponseToolType.Webhook,
                _ => null,
            };
        }
    }
}