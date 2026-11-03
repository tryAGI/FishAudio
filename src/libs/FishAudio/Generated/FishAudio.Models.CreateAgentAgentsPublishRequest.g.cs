
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentAgentsPublishRequest
    {
        /// <summary>
        /// Optional label shown in the version history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_title")]
        public string? VersionTitle { get; set; }

        /// <summary>
        /// Optional longer note for audit and rollback context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Publish only while the draft has this config_hash. Otherwise 409 with reason `draft_changed` and nothing is written.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_config_hash")]
        public string? ExpectedConfigHash { get; set; }

        /// <summary>
        /// Draft changes to apply before publishing, same shape as Update Draft Config. The write and the publish succeed or fail together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::FishAudio.PublicAgentConfigPatchPayload? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsPublishRequest" /> class.
        /// </summary>
        /// <param name="versionTitle">
        /// Optional label shown in the version history.
        /// </param>
        /// <param name="versionDescription">
        /// Optional longer note for audit and rollback context.
        /// </param>
        /// <param name="expectedConfigHash">
        /// Publish only while the draft has this config_hash. Otherwise 409 with reason `draft_changed` and nothing is written.
        /// </param>
        /// <param name="config">
        /// Draft changes to apply before publishing, same shape as Update Draft Config. The write and the publish succeed or fail together.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentAgentsPublishRequest(
            string? versionTitle,
            string? versionDescription,
            string? expectedConfigHash,
            global::FishAudio.PublicAgentConfigPatchPayload? config)
        {
            this.VersionTitle = versionTitle;
            this.VersionDescription = versionDescription;
            this.ExpectedConfigHash = expectedConfigHash;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsPublishRequest" /> class.
        /// </summary>
        public CreateAgentAgentsPublishRequest()
        {
        }

    }
}