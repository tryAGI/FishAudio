
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentAgentsPublishRequest(
            string? versionTitle,
            string? versionDescription)
        {
            this.VersionTitle = versionTitle;
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsPublishRequest" /> class.
        /// </summary>
        public CreateAgentAgentsPublishRequest()
        {
        }

    }
}