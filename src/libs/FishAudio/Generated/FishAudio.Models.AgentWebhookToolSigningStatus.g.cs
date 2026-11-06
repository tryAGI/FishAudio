
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Request signing state of a webhook tool. Secret values never appear in<br/>
    /// reads: the rotate call returns the new secret once.
    /// </summary>
    public sealed partial class AgentWebhookToolSigningStatus
    {
        /// <summary>
        /// Whether requests carry `X-Fish-Webhook-Signature` (HMAC-SHA256 over `{t}.{body}`, the post-call webhook scheme).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_created_at")]
        public global::System.DateTime? SecretCreatedAt { get; set; }

        /// <summary>
        /// Set while the rotated-out secret still signs as a second `v1`; null once it expired or was revoked.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_secret_expires_at")]
        public global::System.DateTime? PreviousSecretExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookToolSigningStatus" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether requests carry `X-Fish-Webhook-Signature` (HMAC-SHA256 over `{t}.{body}`, the post-call webhook scheme).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="secretCreatedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="previousSecretExpiresAt">
        /// Set while the rotated-out secret still signs as a second `v1`; null once it expired or was revoked.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWebhookToolSigningStatus(
            bool? enabled,
            global::System.DateTime? secretCreatedAt,
            global::System.DateTime? previousSecretExpiresAt)
        {
            this.Enabled = enabled;
            this.SecretCreatedAt = secretCreatedAt;
            this.PreviousSecretExpiresAt = previousSecretExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookToolSigningStatus" /> class.
        /// </summary>
        public AgentWebhookToolSigningStatus()
        {
        }

    }
}