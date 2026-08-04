
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: webhook
    /// </summary>
    public enum PublicAgentToolCreatePayloadToolType
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
    public static class PublicAgentToolCreatePayloadToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentToolCreatePayloadToolType value)
        {
            return value switch
            {
                PublicAgentToolCreatePayloadToolType.Client => "client",
                PublicAgentToolCreatePayloadToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentToolCreatePayloadToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PublicAgentToolCreatePayloadToolType.Client,
                "webhook" => PublicAgentToolCreatePayloadToolType.Webhook,
                _ => null,
            };
        }
    }
}