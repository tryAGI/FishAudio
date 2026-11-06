
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One page of pronunciation-dictionary versions.
    /// </summary>
    public sealed partial class GetPronunciationDictionariesVersionsResponse
    {
        /// <summary>
        /// Versions in this page, newest published first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1VersionEntity> Versions { get; set; }

        /// <summary>
        /// Whether another page exists after this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor for the next page; pass it as `cursor`. Null when there is no next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Rows matching the filters across all pages. Always set in page mode; set on the cursor path only with `include_total=true`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesVersionsResponse" /> class.
        /// </summary>
        /// <param name="versions">
        /// Versions in this page, newest published first.
        /// </param>
        /// <param name="hasMore">
        /// Whether another page exists after this one.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor for the next page; pass it as `cursor`. Null when there is no next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="total">
        /// Rows matching the filters across all pages. Always set in page mode; set on the cursor path only with `include_total=true`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionariesVersionsResponse(
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1VersionEntity> versions,
            bool hasMore,
            string? nextCursor,
            int? total)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesVersionsResponse" /> class.
        /// </summary>
        public GetPronunciationDictionariesVersionsResponse()
        {
        }

    }
}