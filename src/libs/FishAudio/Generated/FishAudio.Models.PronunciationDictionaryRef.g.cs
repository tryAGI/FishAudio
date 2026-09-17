
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Reference to a server-managed pronunciation dictionary. The server resolves contents via the platform pronunciation-dictionaries API and forwards the full merged dictionary to the inference engine, which performs the substitution.
    /// </summary>
    public sealed partial class PronunciationDictionaryRef
    {
        /// <summary>
        /// Dictionary identifier as registered on the platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Immutable version identifier for the dictionary. Version is required — there is no implicit `latest`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryRef" /> class.
        /// </summary>
        /// <param name="id">
        /// Dictionary identifier as registered on the platform.
        /// </param>
        /// <param name="version">
        /// Immutable version identifier for the dictionary. Version is required — there is no implicit `latest`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryRef(
            string id,
            string version)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryRef" /> class.
        /// </summary>
        public PronunciationDictionaryRef()
        {
        }

    }
}