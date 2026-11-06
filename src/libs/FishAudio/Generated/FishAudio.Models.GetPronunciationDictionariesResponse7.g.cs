
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A pronunciation dictionary owned by the caller's team.
    /// </summary>
    public sealed partial class GetPronunciationDictionariesResponse7
    {
        /// <summary>
        /// Stable dictionary identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name for the dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-form description shown in the web app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Identifier of the latest published version, or null when the dictionary has never been published.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        public string? LatestVersionId { get; set; }

        /// <summary>
        /// Number of rules in the latest published version.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// Voice model last used by the dictionary's preview player, or null when it was never previewed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_voice_id")]
        public string? PreviewVoiceId { get; set; }

        /// <summary>
        /// TTS model last used by the dictionary's preview player, or null when it was never previewed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_model")]
        public string? PreviewModel { get; set; }

        /// <summary>
        /// Creation time (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last content or metadata update time (UTC).
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
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesResponse7" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable dictionary identifier.
        /// </param>
        /// <param name="name">
        /// Display name for the dictionary.
        /// </param>
        /// <param name="description">
        /// Free-form description shown in the web app.
        /// </param>
        /// <param name="createdAt">
        /// Creation time (UTC).
        /// </param>
        /// <param name="updatedAt">
        /// Last content or metadata update time (UTC).
        /// </param>
        /// <param name="latestVersionId">
        /// Identifier of the latest published version, or null when the dictionary has never been published.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="itemCount">
        /// Number of rules in the latest published version.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="previewVoiceId">
        /// Voice model last used by the dictionary's preview player, or null when it was never previewed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="previewModel">
        /// TTS model last used by the dictionary's preview player, or null when it was never previewed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionariesResponse7(
            string id,
            string name,
            string description,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? latestVersionId,
            int? itemCount,
            string? previewVoiceId,
            string? previewModel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.LatestVersionId = latestVersionId;
            this.ItemCount = itemCount;
            this.PreviewVoiceId = previewVoiceId;
            this.PreviewModel = previewModel;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesResponse7" /> class.
        /// </summary>
        public GetPronunciationDictionariesResponse7()
        {
        }

    }
}