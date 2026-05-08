
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Timestamp information for this content chunk. Balanced streaming can produce multiple non-null alignments, one for each text chunk. Additional audio events for the same content chunk may return null.
    /// </summary>
    public sealed partial class CreateTtsStreamWithTimestampResponseAlignment
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}