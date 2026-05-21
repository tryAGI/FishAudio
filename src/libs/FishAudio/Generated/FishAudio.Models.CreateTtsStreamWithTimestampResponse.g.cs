
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One Server-Sent Events message payload for streaming TTS with timestamps. Each event contains one audio chunk. Concatenate all `audio_base64` chunks in arrival order to reconstruct the complete audio. `alignment` is the latest cumulative timestamp snapshot for the reported `chunk_seq`; clients should replace the previous snapshot for that chunk instead of appending segments.
    /// </summary>
    public sealed partial class CreateTtsStreamWithTimestampResponse
    {
        /// <summary>
        /// Base64 encoded audio chunk. Concatenate every chunk in event order to reconstruct the full audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Text content described by this event's latest alignment snapshot. Long input may be split into multiple content chunks in one stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Latest cumulative timestamp snapshot for `chunk_seq`. When present, replace the previous alignment for the same `chunk_seq`; do not append segments. Null means no alignment snapshot has been produced yet or alignment is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::FishAudio.TTSTimestampAlignment? Alignment { get; set; }

        /// <summary>
        /// Sequence number of the text chunk described by `alignment`. Clients should bucket alignment snapshots by this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_seq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkSeq { get; set; }

        /// <summary>
        /// Absolute start time of this text chunk within the full audio, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_audio_offset_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChunkAudioOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTtsStreamWithTimestampResponse" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio chunk. Concatenate every chunk in event order to reconstruct the full audio.
        /// </param>
        /// <param name="content">
        /// Text content described by this event's latest alignment snapshot. Long input may be split into multiple content chunks in one stream.
        /// </param>
        /// <param name="chunkSeq">
        /// Sequence number of the text chunk described by `alignment`. Clients should bucket alignment snapshots by this value.
        /// </param>
        /// <param name="chunkAudioOffsetSec">
        /// Absolute start time of this text chunk within the full audio, in seconds.
        /// </param>
        /// <param name="alignment">
        /// Latest cumulative timestamp snapshot for `chunk_seq`. When present, replace the previous alignment for the same `chunk_seq`; do not append segments. Null means no alignment snapshot has been produced yet or alignment is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTtsStreamWithTimestampResponse(
            string audioBase64,
            string content,
            int chunkSeq,
            double chunkAudioOffsetSec,
            global::FishAudio.TTSTimestampAlignment? alignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Alignment = alignment;
            this.ChunkSeq = chunkSeq;
            this.ChunkAudioOffsetSec = chunkAudioOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTtsStreamWithTimestampResponse" /> class.
        /// </summary>
        public CreateTtsStreamWithTimestampResponse()
        {
        }

    }
}