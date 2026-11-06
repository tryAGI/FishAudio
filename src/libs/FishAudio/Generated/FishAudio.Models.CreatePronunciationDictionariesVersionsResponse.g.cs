
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A version with its full ordered rule list.
    /// </summary>
    public sealed partial class CreatePronunciationDictionariesVersionsResponse
    {
        /// <summary>
        /// Stable version identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Dictionary this version belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DictionaryId { get; set; }

        /// <summary>
        /// Version note entered when publishing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Monotonic version number within the dictionary. Null only for versions published before version numbers existed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// Rules added relative to the previous version.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_count")]
        public int? AddedCount { get; set; }

        /// <summary>
        /// Rules removed relative to the previous version.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_count")]
        public int? RemovedCount { get; set; }

        /// <summary>
        /// Rules whose key, value, type or case sensitivity changed.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_count")]
        public int? ChangedCount { get; set; }

        /// <summary>
        /// Total number of rules in this version.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// Publish time (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Rules in application order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Item> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictionariesVersionsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable version identifier.
        /// </param>
        /// <param name="dictionaryId">
        /// Dictionary this version belongs to.
        /// </param>
        /// <param name="description">
        /// Version note entered when publishing.
        /// </param>
        /// <param name="createdAt">
        /// Publish time (UTC).
        /// </param>
        /// <param name="items">
        /// Rules in application order.
        /// </param>
        /// <param name="versionNumber">
        /// Monotonic version number within the dictionary. Null only for versions published before version numbers existed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="addedCount">
        /// Rules added relative to the previous version.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="removedCount">
        /// Rules removed relative to the previous version.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="changedCount">
        /// Rules whose key, value, type or case sensitivity changed.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="itemCount">
        /// Total number of rules in this version.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePronunciationDictionariesVersionsResponse(
            string id,
            string dictionaryId,
            string description,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Item> items,
            int? versionNumber,
            int? addedCount,
            int? removedCount,
            int? changedCount,
            int? itemCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DictionaryId = dictionaryId ?? throw new global::System.ArgumentNullException(nameof(dictionaryId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.VersionNumber = versionNumber;
            this.AddedCount = addedCount;
            this.RemovedCount = removedCount;
            this.ChangedCount = changedCount;
            this.ItemCount = itemCount;
            this.CreatedAt = createdAt;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationDictionariesVersionsResponse" /> class.
        /// </summary>
        public CreatePronunciationDictionariesVersionsResponse()
        {
        }

    }
}