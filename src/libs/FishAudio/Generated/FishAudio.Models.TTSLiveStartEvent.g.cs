
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Opens a synthesis session. Send this first, once per session. `request` carries the same fields as the `POST /v1/tts` body.
    /// </summary>
    public sealed partial class TTSLiveStartEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"start"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "start";

        /// <summary>
        /// Synthesis parameters for this session, identical to the `POST /v1/tts` request body. `text` may be an empty string here; text sent later with `text` events is appended to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.TTSRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveStartEvent" /> class.
        /// </summary>
        /// <param name="request">
        /// Synthesis parameters for this session, identical to the `POST /v1/tts` request body. `text` may be an empty string here; text sent later with `text` events is appended to it.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveStartEvent(
            global::FishAudio.TTSRequest request,
            string @event = "start")
        {
            this.Event = @event;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveStartEvent" /> class.
        /// </summary>
        public TTSLiveStartEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TTSLiveStartEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TTSLiveStartEvent FromRequest(global::FishAudio.TTSRequest request)
        {
            return new TTSLiveStartEvent
            {
                Request = request,
            };
        }

    }
}