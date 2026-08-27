
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentToolsResponseToolType
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
    public static class CreateAgentToolsResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentToolsResponseToolType value)
        {
            return value switch
            {
                CreateAgentToolsResponseToolType.Client => "client",
                CreateAgentToolsResponseToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentToolsResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => CreateAgentToolsResponseToolType.Client,
                "webhook" => CreateAgentToolsResponseToolType.Webhook,
                _ => null,
            };
        }
    }
}