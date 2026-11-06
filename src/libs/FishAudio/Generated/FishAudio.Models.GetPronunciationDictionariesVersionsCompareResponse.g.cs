
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Row-level diff between two versions of one dictionary.
    /// </summary>
    public sealed partial class GetPronunciationDictionariesVersionsCompareResponse
    {
        /// <summary>
        /// Target (viewed) version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Base version the target is compared against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseVersionId { get; set; }

        /// <summary>
        /// Number of added rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Added { get; set; }

        /// <summary>
        /// Number of removed rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Removed { get; set; }

        /// <summary>
        /// Number of changed rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Changed { get; set; }

        /// <summary>
        /// Per-rule diff rows in target order, with removed rows last.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1CompareRow> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesVersionsCompareResponse" /> class.
        /// </summary>
        /// <param name="versionId">
        /// Target (viewed) version.
        /// </param>
        /// <param name="baseVersionId">
        /// Base version the target is compared against.
        /// </param>
        /// <param name="added">
        /// Number of added rows.
        /// </param>
        /// <param name="removed">
        /// Number of removed rows.
        /// </param>
        /// <param name="changed">
        /// Number of changed rows.
        /// </param>
        /// <param name="rows">
        /// Per-rule diff rows in target order, with removed rows last.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionariesVersionsCompareResponse(
            string versionId,
            string baseVersionId,
            int added,
            int removed,
            int changed,
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1CompareRow> rows)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.BaseVersionId = baseVersionId ?? throw new global::System.ArgumentNullException(nameof(baseVersionId));
            this.Added = added;
            this.Removed = removed;
            this.Changed = changed;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesVersionsCompareResponse" /> class.
        /// </summary>
        public GetPronunciationDictionariesVersionsCompareResponse()
        {
        }

    }
}