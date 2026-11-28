
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentWebhookToolSigningSecretRotatePayload
    {
        /// <summary>
        /// The new signing secret. Omit it to have one generated (`whsec_` plus 256 random bits), which is the recommended way.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// How long the replaced secret keeps signing next to the new one, as a second `v1`. Default 24 hours, at most 7 days. 0 switches at once. Ignored when signing was off.<br/>
        /// Default Value: 86400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_secret_expires_in_seconds")]
        public int? PreviousSecretExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookToolSigningSecretRotatePayload" /> class.
        /// </summary>
        /// <param name="secret">
        /// The new signing secret. Omit it to have one generated (`whsec_` plus 256 random bits), which is the recommended way.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="previousSecretExpiresInSeconds">
        /// How long the replaced secret keeps signing next to the new one, as a second `v1`. Default 24 hours, at most 7 days. 0 switches at once. Ignored when signing was off.<br/>
        /// Default Value: 86400
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWebhookToolSigningSecretRotatePayload(
            string? secret,
            int? previousSecretExpiresInSeconds)
        {
            this.Secret = secret;
            this.PreviousSecretExpiresInSeconds = previousSecretExpiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWebhookToolSigningSecretRotatePayload" /> class.
        /// </summary>
        public AgentWebhookToolSigningSecretRotatePayload()
        {
        }

    }
}