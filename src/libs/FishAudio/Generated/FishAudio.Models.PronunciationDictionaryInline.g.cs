
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Inline literal pronunciation dictionary. The server forwards the entries directly to the inference engine without contacting the platform.
    /// </summary>
    public sealed partial class PronunciationDictionaryInline
    {
        /// <summary>
        /// Replacement entries for this dictionary. See the top-level `pronunciation_dictionary` field description for replacement semantics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryInline" /> class.
        /// </summary>
        /// <param name="items">
        /// Replacement entries for this dictionary. See the top-level `pronunciation_dictionary` field description for replacement semantics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryInline(
            global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryInline" /> class.
        /// </summary>
        public PronunciationDictionaryInline()
        {
        }

    }
}