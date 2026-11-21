
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentToolsSigningSecretRotateResponse
    {
        /// <summary>
        /// The new signing secret. Store it now: it is never returned again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Request signing state of a webhook tool. Secret values never appear in<br/>
        /// reads: the rotate call returns the new secret once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentWebhookToolSigningStatus Signing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolsSigningSecretRotateResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The new signing secret. Store it now: it is never returned again.
        /// </param>
        /// <param name="signing">
        /// Request signing state of a webhook tool. Secret values never appear in<br/>
        /// reads: the rotate call returns the new secret once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentToolsSigningSecretRotateResponse(
            string secret,
            global::FishAudio.AgentWebhookToolSigningStatus signing)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.Signing = signing ?? throw new global::System.ArgumentNullException(nameof(signing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolsSigningSecretRotateResponse" /> class.
        /// </summary>
        public CreateAgentToolsSigningSecretRotateResponse()
        {
        }

    }
}