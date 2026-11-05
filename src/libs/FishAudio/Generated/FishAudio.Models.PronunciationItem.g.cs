
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A single key/value entry in a pronunciation dictionary. The inference engine replaces every occurrence of `key` in the request text with `value` during synthesis. With the default `type: "phoneme"` the value is spoken as a phonetic form; with `type: "alias"` it is substituted as plain text.
    /// </summary>
    public sealed partial class PronunciationItem
    {
        /// <summary>
        /// Source substring to match. Pure substring match — no tokenization, no regex. Overlapping matches resolve leftmost-longest. For CJK text include enough context to disambiguate. For `type: "alias"` the key must not start or end with whitespace and must not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Replacement for the key during synthesis. For `type: "phoneme"` this is a phonetic representation; dictionary authors should NOT include the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers themselves, because the inference engine wraps the value with those markers internally so the body is treated as phonemes rather than orthographic text. For `type: "alias"` this is plain text substituted verbatim (then normalized with the rest of the request text) and must not contain `&lt;|` or `|&gt;`. Requests whose key or value contain either phoneme marker are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// How `value` replaces `key`. `phoneme` (default) speaks the value as a phonetic form. `alias` substitutes the literal text, which then goes through the same text normalization as the rest of the request. Omitted or `null` means `phoneme`, so existing dictionaries and clients keep their behaviour. Any other value is rejected. Usage is billed on the text actually synthesized, with alias replacements counted: an alias that expands a key is billed for the longer text, one that shortens it is billed for the shorter text; phoneme rules never change billing.<br/>
        /// Default Value: phoneme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PronunciationItemTypeJsonConverter))]
        public global::FishAudio.PronunciationItemType? Type { get; set; }

        /// <summary>
        /// When true the match is case-sensitive; when false ASCII case folding is applied.<br/>
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
        /// Initializes a new instance of the <see cref="PronunciationItem" /> class.
        /// </summary>
        /// <param name="key">
        /// Source substring to match. Pure substring match — no tokenization, no regex. Overlapping matches resolve leftmost-longest. For CJK text include enough context to disambiguate. For `type: "alias"` the key must not start or end with whitespace and must not contain control characters, `&lt;`, `&gt;`, `(`, `)`, `[` or `]`.
        /// </param>
        /// <param name="value">
        /// Replacement for the key during synthesis. For `type: "phoneme"` this is a phonetic representation; dictionary authors should NOT include the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers themselves, because the inference engine wraps the value with those markers internally so the body is treated as phonemes rather than orthographic text. For `type: "alias"` this is plain text substituted verbatim (then normalized with the rest of the request text) and must not contain `&lt;|` or `|&gt;`. Requests whose key or value contain either phoneme marker are rejected.
        /// </param>
        /// <param name="type">
        /// How `value` replaces `key`. `phoneme` (default) speaks the value as a phonetic form. `alias` substitutes the literal text, which then goes through the same text normalization as the rest of the request. Omitted or `null` means `phoneme`, so existing dictionaries and clients keep their behaviour. Any other value is rejected. Usage is billed on the text actually synthesized, with alias replacements counted: an alias that expands a key is billed for the longer text, one that shortens it is billed for the shorter text; phoneme rules never change billing.<br/>
        /// Default Value: phoneme
        /// </param>
        /// <param name="caseSensitive">
        /// When true the match is case-sensitive; when false ASCII case folding is applied.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationItem(
            string key,
            string value,
            global::FishAudio.PronunciationItemType? type,
            bool? caseSensitive)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationItem" /> class.
        /// </summary>
        public PronunciationItem()
        {
        }

    }
}