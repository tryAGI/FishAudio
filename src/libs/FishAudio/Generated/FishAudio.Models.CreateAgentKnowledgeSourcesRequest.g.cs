
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentKnowledgeSourcesRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourcename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sourcename { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Put the source in this knowledge folder, which must be in the workspace the source is created in (your default workspace). Omit it, or send `root` (or an empty value), to create it outside any folder. 404 if the folder does not exist there.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentKnowledgeSourcesRequest" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="sourcename"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description"></param>
        /// <param name="folderId">
        /// Put the source in this knowledge folder, which must be in the workspace the source is created in (your default workspace). Omit it, or send `root` (or an empty value), to create it outside any folder. 404 if the folder does not exist there.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentKnowledgeSourcesRequest(
            byte[] source,
            string sourcename,
            string? name,
            string? description,
            string? folderId)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Sourcename = sourcename ?? throw new global::System.ArgumentNullException(nameof(sourcename));
            this.Name = name;
            this.Description = description;
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentKnowledgeSourcesRequest" /> class.
        /// </summary>
        public CreateAgentKnowledgeSourcesRequest()
        {
        }

    }
}