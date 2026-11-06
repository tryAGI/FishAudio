
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PronunciationDictionaryVersionCreatePayload
    {
        /// <summary>
        /// Optimistic-concurrency guard: the latest version ID the caller believes is current, or null for the first publish. A mismatch returns 409.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_latest_version_id")]
        public string? ExpectedLatestVersionId { get; set; }

        /// <summary>
        /// Optional version note (up to 1024 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete ordered rule list for the new version (up to 5000 rules). Keys must be unique within the version; order is the engine's application order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionCreatePayload" /> class.
        /// </summary>
        /// <param name="expectedLatestVersionId">
        /// Optimistic-concurrency guard: the latest version ID the caller believes is current, or null for the first publish. A mismatch returns 409.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Optional version note (up to 1024 characters).
        /// </param>
        /// <param name="items">
        /// Complete ordered rule list for the new version (up to 5000 rules). Keys must be unique within the version; order is the engine's application order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryVersionCreatePayload(
            string? expectedLatestVersionId,
            string? description,
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>? items)
        {
            this.ExpectedLatestVersionId = expectedLatestVersionId;
            this.Description = description;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionCreatePayload" /> class.
        /// </summary>
        public PronunciationDictionaryVersionCreatePayload()
        {
        }

    }
}