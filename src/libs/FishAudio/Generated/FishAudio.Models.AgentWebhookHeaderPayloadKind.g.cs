
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: custom
    /// </summary>
    public enum AgentWebhookHeaderPayloadKind
    {
        /// <summary>
        ///
        /// </summary>
        AuthorizationBasic,
        /// <summary>
        ///
        /// </summary>
        AuthorizationBearer,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentWebhookHeaderPayloadKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentWebhookHeaderPayloadKind value)
        {
            return value switch
            {
                AgentWebhookHeaderPayloadKind.AuthorizationBasic => "authorization_basic",
                AgentWebhookHeaderPayloadKind.AuthorizationBearer => "authorization_bearer",
                AgentWebhookHeaderPayloadKind.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentWebhookHeaderPayloadKind? ToEnum(string value)
        {
            return value switch
            {
                "authorization_basic" => AgentWebhookHeaderPayloadKind.AuthorizationBasic,
                "authorization_bearer" => AgentWebhookHeaderPayloadKind.AuthorizationBearer,
                "custom" => AgentWebhookHeaderPayloadKind.Custom,
                _ => null,
            };
        }
    }
}