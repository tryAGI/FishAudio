
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Ends the session. The server synthesizes whatever text is still buffered, emits any trailing `audio` events, then a `finish` event with `reason: "stop"`.
    /// </summary>
    public sealed partial class TTSLiveStopEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"stop"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "stop";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveStopEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveStopEvent(
            string @event = "stop")
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveStopEvent" /> class.
        /// </summary>
        public TTSLiveStopEvent()
        {
        }

    }
}