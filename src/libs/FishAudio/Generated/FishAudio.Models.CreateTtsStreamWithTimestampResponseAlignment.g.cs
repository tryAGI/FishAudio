
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Latest cumulative timestamp snapshot for `chunk_seq`. When present, replace the previous alignment for the same `chunk_seq`; do not append segments. Null means no alignment snapshot has been produced yet or alignment is unavailable.
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