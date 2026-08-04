
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentAgentsPublishResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_title")]
        public string? VersionTitle { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsPublishResponse" /> class.
        /// </summary>
        /// <param name="versionNumber"></param>
        /// <param name="configHash"></param>
        /// <param name="publishedAt"></param>
        /// <param name="versionTitle">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="versionDescription">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentAgentsPublishResponse(
            int versionNumber,
            string configHash,
            global::System.DateTime publishedAt,
            string? versionTitle,
            string? versionDescription)
        {
            this.VersionNumber = versionNumber;
            this.VersionTitle = versionTitle;
            this.VersionDescription = versionDescription;
            this.ConfigHash = configHash ?? throw new global::System.ArgumentNullException(nameof(configHash));
            this.PublishedAt = publishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsPublishResponse" /> class.
        /// </summary>
        public CreateAgentAgentsPublishResponse()
        {
        }

    }
}