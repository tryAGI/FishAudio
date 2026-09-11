
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Forces the buffered text through generation without waiting for the chunk to fill. A text-splitting control only: the session stays open and you may keep sending `text` events afterwards.
    /// </summary>
    public sealed partial class TTSLiveFlushEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"flush"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "flush";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveFlushEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveFlushEvent(
            string @event = "flush")
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveFlushEvent" /> class.
        /// </summary>
        public TTSLiveFlushEvent()
        {
        }

    }
}