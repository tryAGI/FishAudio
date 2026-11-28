
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicKnowledgeFolderPayload
    {
        /// <summary>
        /// 1-120 characters after leading and trailing whitespace is removed (a blank name is rejected). Unique within the workspace, case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKnowledgeFolderPayload" /> class.
        /// </summary>
        /// <param name="name">
        /// 1-120 characters after leading and trailing whitespace is removed (a blank name is rejected). Unique within the workspace, case-sensitive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicKnowledgeFolderPayload(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKnowledgeFolderPayload" /> class.
        /// </summary>
        public PublicKnowledgeFolderPayload()
        {
        }

    }
}