
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A single key/value entry in a pronunciation dictionary. The inference engine replaces every occurrence of `key` in the request text with the phoneme form `value` during synthesis.
    /// </summary>
    public sealed partial class PronunciationItem
    {
        /// <summary>
        /// Source substring to match. Pure substring match — no tokenization, no regex. Overlapping matches resolve leftmost-longest. For CJK text include enough context to disambiguate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Phonetic representation that replaces the key during synthesis. Dictionary authors should NOT include the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers themselves; the inference engine wraps the value with those markers internally so the body is treated as phonemes rather than orthographic text. Requests whose key or value contain either marker are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

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
        /// Source substring to match. Pure substring match — no tokenization, no regex. Overlapping matches resolve leftmost-longest. For CJK text include enough context to disambiguate.
        /// </param>
        /// <param name="value">
        /// Phonetic representation that replaces the key during synthesis. Dictionary authors should NOT include the `&lt;|phoneme_start|&gt;` / `&lt;|phoneme_end|&gt;` markers themselves; the inference engine wraps the value with those markers internally so the body is treated as phonemes rather than orthographic text. Requests whose key or value contain either marker are rejected.
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
            bool? caseSensitive)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
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