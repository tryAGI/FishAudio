
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One audio chunk plus the latest word-level alignment snapshot. Concatenate every `audio` payload in arrival order to reconstruct the complete audio. `alignment` is the cumulative snapshot for `chunk_seq`: replace the stored alignment for that chunk instead of appending to it. Segment times are relative to the chunk, so the absolute time of a word is `chunk_audio_offset_sec + segment.start`.
    /// </summary>
    public sealed partial class TTSLiveWithTimestampAudioEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "audio";

        /// <summary>
        /// Raw audio chunk, carried as a MessagePack `bin` value — not base64, unlike the SSE `/v1/tts/stream/with-timestamp` endpoint. Concatenate every chunk in arrival order to reconstruct the full audio. May be empty on a trailing frame whose only purpose is to deliver a final `alignment` correction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Raw audio chunk, carried as a MessagePack `bin` value — not base64, unlike the SSE `/v1/tts/stream/with-timestamp` endpoint. Concatenate every chunk in arrival order to reconstruct the full audio. May be empty on a trailing frame whose only purpose is to deliver a final `alignment` correction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Text content of the chunk identified by `chunk_seq`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Cumulative word-level alignment snapshot for `chunk_seq`, with segment times relative to the start of that chunk. Always present on the wire; `null` means the alignment for this chunk has not changed yet (normal early in a chunk, while the aligner is still committing words). When non-null, replace the snapshot you stored for `chunk_seq` — never append to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::FishAudio.TTSTimestampAlignment? Alignment { get; set; }

        /// <summary>
        /// Sequence number of the text chunk that `alignment` and `content` describe. Monotonically non-decreasing. Bucket alignment snapshots by this value. Note that a frame may be labelled with the previous chunk's `chunk_seq` while carrying the next chunk's audio bytes, so do not use it to attribute audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_seq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ChunkSeq { get; set; }

        /// <summary>
        /// Start time of this text chunk within the full audio, in seconds — the sum of the audio durations of every earlier chunk. Add it to a segment's `start`/`end` to get absolute timestamps. Monotonically non-decreasing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_audio_offset_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChunkAudioOffsetSec { get; set; }

        /// <summary>
        /// Milliseconds since the server began the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveWithTimestampAudioEvent" /> class.
        /// </summary>
        /// <param name="audio">
        /// Raw audio chunk, carried as a MessagePack `bin` value — not base64, unlike the SSE `/v1/tts/stream/with-timestamp` endpoint. Concatenate every chunk in arrival order to reconstruct the full audio. May be empty on a trailing frame whose only purpose is to deliver a final `alignment` correction.
        /// </param>
        /// <param name="audioname">
        /// Raw audio chunk, carried as a MessagePack `bin` value — not base64, unlike the SSE `/v1/tts/stream/with-timestamp` endpoint. Concatenate every chunk in arrival order to reconstruct the full audio. May be empty on a trailing frame whose only purpose is to deliver a final `alignment` correction.
        /// </param>
        /// <param name="content">
        /// Text content of the chunk identified by `chunk_seq`.
        /// </param>
        /// <param name="chunkSeq">
        /// Sequence number of the text chunk that `alignment` and `content` describe. Monotonically non-decreasing. Bucket alignment snapshots by this value. Note that a frame may be labelled with the previous chunk's `chunk_seq` while carrying the next chunk's audio bytes, so do not use it to attribute audio.
        /// </param>
        /// <param name="chunkAudioOffsetSec">
        /// Start time of this text chunk within the full audio, in seconds — the sum of the audio durations of every earlier chunk. Add it to a segment's `start`/`end` to get absolute timestamps. Monotonically non-decreasing.
        /// </param>
        /// <param name="alignment">
        /// Cumulative word-level alignment snapshot for `chunk_seq`, with segment times relative to the start of that chunk. Always present on the wire; `null` means the alignment for this chunk has not changed yet (normal early in a chunk, while the aligner is still committing words). When non-null, replace the snapshot you stored for `chunk_seq` — never append to it.
        /// </param>
        /// <param name="time">
        /// Milliseconds since the server began the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveWithTimestampAudioEvent(
            byte[] audio,
            string audioname,
            string content,
            long chunkSeq,
            double chunkAudioOffsetSec,
            global::FishAudio.TTSTimestampAlignment? alignment,
            double? time,
            string @event = "audio")
        {
            this.Event = @event;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Alignment = alignment;
            this.ChunkSeq = chunkSeq;
            this.ChunkAudioOffsetSec = chunkAudioOffsetSec;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveWithTimestampAudioEvent" /> class.
        /// </summary>
        public TTSLiveWithTimestampAudioEvent()
        {
        }

    }
}