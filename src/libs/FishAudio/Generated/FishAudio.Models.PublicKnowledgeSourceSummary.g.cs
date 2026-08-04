
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicKnowledgeSourceSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkCount { get; set; }

        /// <summary>
        /// Increments every time the content is replaced. Drafts always use the newest revision; published versions pin the revision current at publish time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RevisionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKnowledgeSourceSummary" /> class.
        /// </summary>
        /// <param name="knowledgeSourceId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="fileName"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="chunkCount"></param>
        /// <param name="revisionNumber">
        /// Increments every time the content is replaced. Drafts always use the newest revision; published versions pin the revision current at publish time.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicKnowledgeSourceSummary(
            string knowledgeSourceId,
            string workspaceId,
            string name,
            string fileName,
            long sizeBytes,
            int chunkCount,
            int revisionNumber,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.KnowledgeSourceId = knowledgeSourceId ?? throw new global::System.ArgumentNullException(nameof(knowledgeSourceId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.SizeBytes = sizeBytes;
            this.ChunkCount = chunkCount;
            this.RevisionNumber = revisionNumber;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKnowledgeSourceSummary" /> class.
        /// </summary>
        public PublicKnowledgeSourceSummary()
        {
        }

    }
}