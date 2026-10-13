
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A warm transfer's consult call, recorded apart from the caller, who<br/>
    /// was on hold meanwhile. `transfer_id` is the transfer item's `call_id`.
    /// </summary>
    public sealed partial class AgentSessionTransferRecordingEntity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransferId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionTransferRecordingEntityStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionTransferRecordingEntityStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity> Tracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionTransferRecordingEntity" /> class.
        /// </summary>
        /// <param name="transferId"></param>
        /// <param name="status"></param>
        /// <param name="tracks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionTransferRecordingEntity(
            string transferId,
            global::FishAudio.AgentSessionTransferRecordingEntityStatus status,
            global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity> tracks)
        {
            this.TransferId = transferId ?? throw new global::System.ArgumentNullException(nameof(transferId));
            this.Status = status;
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionTransferRecordingEntity" /> class.
        /// </summary>
        public AgentSessionTransferRecordingEntity()
        {
        }

    }
}