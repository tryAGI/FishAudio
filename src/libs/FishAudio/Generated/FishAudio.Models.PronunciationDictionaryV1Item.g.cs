
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One key/value rule in a published version.
    /// </summary>
    public sealed partial class PronunciationDictionaryV1Item
    {
        /// <summary>
        /// Substring to match in the request text. 1-256 characters. Alias rules may not start or end with whitespace and may not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Replacement text. 1-1024 characters. For phoneme rules it is the phonetic form (without the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers); for alias rules it is plain text. Neither type may contain `&lt;|` or `|&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// How the key is replaced: `phoneme` (default) speaks the value as a phonetic form; `alias` substitutes the literal text, which is then read like the rest of the request.<br/>
        /// Default Value: phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PronunciationDictionaryV1ItemTypeJsonConverter))]
        public global::FishAudio.PronunciationDictionaryV1ItemType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="PronunciationDictionaryV1Item" /> class.
        /// </summary>
        /// <param name="key">
        /// Substring to match in the request text. 1-256 characters. Alias rules may not start or end with whitespace and may not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </param>
        /// <param name="value">
        /// Replacement text. 1-1024 characters. For phoneme rules it is the phonetic form (without the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers); for alias rules it is plain text. Neither type may contain `&lt;|` or `|&gt;`.
        /// </param>
        /// <param name="type">
        /// How the key is replaced: `phoneme` (default) speaks the value as a phonetic form; `alias` substitutes the literal text, which is then read like the rest of the request.<br/>
        /// Default Value: phoneme
        /// </param>
        /// <param name="caseSensitive">
        /// When true, matching is case-sensitive; when false, ASCII case folding is applied.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryV1Item(
            string key,
            string value,
            global::FishAudio.PronunciationDictionaryV1ItemType? type,
            bool? caseSensitive)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryV1Item" /> class.
        /// </summary>
        public PronunciationDictionaryV1Item()
        {
        }

    }
}