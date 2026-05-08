
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One Server-Sent Events message payload for streaming TTS with timestamps. Each event contains one audio chunk. Concatenate all `audio_base64` chunks in arrival order to reconstruct the complete audio. Long input may be split into multiple content chunks. Each chunk can have its own non-null `alignment`, followed by additional audio-only events for that chunk where `alignment` is null. Collect every non-null `alignment` in order.
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
        /// Text content covered by this event's text chunk. Long input may be split into multiple content chunks in one stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Timestamp information for this content chunk. Balanced streaming can produce multiple non-null alignments, one for each text chunk. Additional audio events for the same content chunk may return null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::FishAudio.TTSTimestampAlignment? Alignment { get; set; }

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
        /// Text content covered by this event's text chunk. Long input may be split into multiple content chunks in one stream.
        /// </param>
        /// <param name="alignment">
        /// Timestamp information for this content chunk. Balanced streaming can produce multiple non-null alignments, one for each text chunk. Additional audio events for the same content chunk may return null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTtsStreamWithTimestampResponse(
            string audioBase64,
            string content,
            global::FishAudio.TTSTimestampAlignment? alignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Alignment = alignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTtsStreamWithTimestampResponse" /> class.
        /// </summary>
        public CreateTtsStreamWithTimestampResponse()
        {
        }
    }
}