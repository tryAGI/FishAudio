
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Appends a text fragment to the session buffer. Send as many as you like; the server splits the buffer into chunks and synthesizes them as they become long enough.
    /// </summary>
    public sealed partial class TTSLiveTextEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "text";

        /// <summary>
        /// Text fragment appended to the session buffer, verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveTextEvent" /> class.
        /// </summary>
        /// <param name="text">
        /// Text fragment appended to the session buffer, verbatim.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveTextEvent(
            string text,
            string @event = "text")
        {
            this.Event = @event;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveTextEvent" /> class.
        /// </summary>
        public TTSLiveTextEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TTSLiveTextEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TTSLiveTextEvent FromText(string text)
        {
            return new TTSLiveTextEvent
            {
                Text = text,
            };
        }

    }
}