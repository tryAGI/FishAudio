
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSTimestampAlignment
    {
        /// <summary>
        /// Ordered text timing segments for the generated audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment> Segments { get; set; }

        /// <summary>
        /// Audio duration in seconds for this alignment's content chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSTimestampAlignment" /> class.
        /// </summary>
        /// <param name="segments">
        /// Ordered text timing segments for the generated audio.
        /// </param>
        /// <param name="audioDuration">
        /// Audio duration in seconds for this alignment's content chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSTimestampAlignment(
            global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment> segments,
            double audioDuration)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.AudioDuration = audioDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSTimestampAlignment" /> class.
        /// </summary>
        public TTSTimestampAlignment()
        {
        }

    }
}