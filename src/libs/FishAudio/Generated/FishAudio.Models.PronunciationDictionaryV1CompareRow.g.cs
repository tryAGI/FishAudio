
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One rule row in a version comparison.
    /// </summary>
    public sealed partial class PronunciationDictionaryV1CompareRow
    {
        /// <summary>
        /// Key in the target version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Value in the target version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Replacement type in the target version.<br/>
        /// Default Value: phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowTypeJsonConverter))]
        public global::FishAudio.PronunciationDictionaryV1CompareRowType? Type { get; set; }

        /// <summary>
        /// Case sensitivity in the target version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CaseSensitive { get; set; }

        /// <summary>
        /// Position in the target version; null for a removed row (the rule only exists in the base version).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Change relative to the base version: `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PronunciationDictionaryV1CompareRowStatus Status { get; set; }

        /// <summary>
        /// Key in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_key")]
        public string? BaseKey { get; set; }

        /// <summary>
        /// Value in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_value")]
        public string? BaseValue { get; set; }

        /// <summary>
        /// Replacement type in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_type")]
        public global::FishAudio.PronunciationDictionaryV1CompareRowBaseType? BaseType { get; set; }

        /// <summary>
        /// Case sensitivity in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_case_sensitive")]
        public bool? BaseCaseSensitive { get; set; }

        /// <summary>
        /// Position in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_order")]
        public int? BaseOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryV1CompareRow" /> class.
        /// </summary>
        /// <param name="key">
        /// Key in the target version.
        /// </param>
        /// <param name="value">
        /// Value in the target version.
        /// </param>
        /// <param name="caseSensitive">
        /// Case sensitivity in the target version.
        /// </param>
        /// <param name="status">
        /// Change relative to the base version: `added` only in target, `removed` only in base, `changed` with different content, `moved` with identical content but a different position, `unchanged`.
        /// </param>
        /// <param name="type">
        /// Replacement type in the target version.<br/>
        /// Default Value: phoneme
        /// </param>
        /// <param name="order">
        /// Position in the target version; null for a removed row (the rule only exists in the base version).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseKey">
        /// Key in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseValue">
        /// Value in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseType">
        /// Replacement type in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseCaseSensitive">
        /// Case sensitivity in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseOrder">
        /// Position in the base version; only for changed, moved or removed rows.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryV1CompareRow(
            string key,
            string value,
            bool caseSensitive,
            global::FishAudio.PronunciationDictionaryV1CompareRowStatus status,
            global::FishAudio.PronunciationDictionaryV1CompareRowType? type,
            int? order,
            string? baseKey,
            string? baseValue,
            global::FishAudio.PronunciationDictionaryV1CompareRowBaseType? baseType,
            bool? baseCaseSensitive,
            int? baseOrder)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.CaseSensitive = caseSensitive;
            this.Order = order;
            this.Status = status;
            this.BaseKey = baseKey;
            this.BaseValue = baseValue;
            this.BaseType = baseType;
            this.BaseCaseSensitive = baseCaseSensitive;
            this.BaseOrder = baseOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryV1CompareRow" /> class.
        /// </summary>
        public PronunciationDictionaryV1CompareRow()
        {
        }

    }
}