
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PronunciationDictionaryItemPayload
    {
        /// <summary>
        /// Substring to match in the request text (1-256 characters). Alias rules may not start or end with whitespace and may not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Replacement text (1-1024 characters). For phoneme rules this is the phonetic form without the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers; for alias rules it is plain text. Neither may contain `&lt;|` or `|&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Replacement mode: `phoneme` (default, and also the meaning of an omitted or null value) speaks the value as a phonetic form; `alias` substitutes the literal text. Other values return 422.<br/>
        /// Default Value: phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PronunciationDictionaryItemPayloadTypeJsonConverter))]
        public global::FishAudio.PronunciationDictionaryItemPayloadType? Type { get; set; }

        /// <summary>
        /// When true, matching is case-sensitive; when false, ASCII case folding is applied.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryItemPayload" /> class.
        /// </summary>
        /// <param name="key">
        /// Substring to match in the request text (1-256 characters). Alias rules may not start or end with whitespace and may not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </param>
        /// <param name="value">
        /// Replacement text (1-1024 characters). For phoneme rules this is the phonetic form without the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers; for alias rules it is plain text. Neither may contain `&lt;|` or `|&gt;`.
        /// </param>
        /// <param name="type">
        /// Replacement mode: `phoneme` (default, and also the meaning of an omitted or null value) speaks the value as a phonetic form; `alias` substitutes the literal text. Other values return 422.<br/>
        /// Default Value: phoneme
        /// </param>
        /// <param name="caseSensitive">
        /// When true, matching is case-sensitive; when false, ASCII case folding is applied.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryItemPayload(
            string key,
            string value,
            global::FishAudio.PronunciationDictionaryItemPayloadType? type,
            bool? caseSensitive)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryItemPayload" /> class.
        /// </summary>
        public PronunciationDictionaryItemPayload()
        {
        }

    }
}