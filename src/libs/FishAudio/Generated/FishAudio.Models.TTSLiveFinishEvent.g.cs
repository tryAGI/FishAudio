
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Terminal event for the session. `reason: "stop"` follows a clean `stop`; `reason: "error"` reports a server-side failure and carries `message`. No further events arrive for the session.
    /// </summary>
    public sealed partial class TTSLiveFinishEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"finish"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = "finish";

        /// <summary>
        /// `stop` when the session ended cleanly, `error` when the server aborted it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.TTSLiveFinishEventReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.TTSLiveFinishEventReason Reason { get; set; }

        /// <summary>
        /// Failure detail. Present only when `reason` is `error`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

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
        /// Initializes a new instance of the <see cref="TTSLiveFinishEvent" /> class.
        /// </summary>
        /// <param name="reason">
        /// `stop` when the session ended cleanly, `error` when the server aborted it.
        /// </param>
        /// <param name="message">
        /// Failure detail. Present only when `reason` is `error`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="time">
        /// Milliseconds since the server began the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSLiveFinishEvent(
            global::FishAudio.TTSLiveFinishEventReason reason,
            string? message,
            double? time,
            string @event = "finish")
        {
            this.Event = @event;
            this.Reason = reason;
            this.Message = message;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSLiveFinishEvent" /> class.
        /// </summary>
        public TTSLiveFinishEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TTSLiveFinishEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TTSLiveFinishEvent FromReason(global::FishAudio.TTSLiveFinishEventReason reason)
        {
            return new TTSLiveFinishEvent
            {
                Reason = reason,
            };
        }

    }
}