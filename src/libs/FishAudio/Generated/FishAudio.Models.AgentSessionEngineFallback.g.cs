
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One time the session did not speak with the speech engine or the voice<br/>
    /// its agent is set up with. `from` is what it was set up with, `to` is what<br/>
    /// spoke instead.<br/>
    /// - unsupported_language: the speech engine does not speak the session's<br/>
    ///   language (live3 speaks English only), so the whole session was spoken<br/>
    ///   by the agent's text-to-speech model. `detail` is the session's language.<br/>
    /// - invalid_config: the speech engine refused the agent's voice settings,<br/>
    ///   so the whole session was spoken by the agent's text-to-speech model.<br/>
    ///   `message` is what the engine said.<br/>
    /// - engine_unavailable: the speech engine was not available, when the<br/>
    ///   session started or from `occurred_at` during it. Replies from<br/>
    ///   `occurred_at` on were spoken by the agent's text-to-speech model, which<br/>
    ///   is the whole session when the engine could not take it.<br/>
    /// - voice_unusable: the speech engine could not use the agent's voice, so<br/>
    ///   the session stayed on the engine and spoke in the voice `to` names.<br/>
    ///   When the cause is the voice itself, `detail` names it (for example<br/>
    ///   no_transcript, too_long, text_mismatch, no_clip or not_found) and<br/>
    ///   `message` is what the engine said.
    /// </summary>
    public sealed partial class AgentSessionEngineFallback
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurred_at")]
        public string? OccurredAt { get; set; }

        /// <summary>
        /// What a session speaks with, in the terms of the agent's `voice`<br/>
        /// settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionEngineRef From { get; set; }

        /// <summary>
        /// What a session speaks with, in the terms of the agent's `voice`<br/>
        /// settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionEngineRef To { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionEngineFallbackReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionEngineFallbackReason Reason { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionEngineFallback" /> class.
        /// </summary>
        /// <param name="from">
        /// What a session speaks with, in the terms of the agent's `voice`<br/>
        /// settings.
        /// </param>
        /// <param name="to">
        /// What a session speaks with, in the terms of the agent's `voice`<br/>
        /// settings.
        /// </param>
        /// <param name="reason"></param>
        /// <param name="occurredAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="detail">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="message">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionEngineFallback(
            global::FishAudio.AgentSessionEngineRef from,
            global::FishAudio.AgentSessionEngineRef to,
            global::FishAudio.AgentSessionEngineFallbackReason reason,
            string? occurredAt,
            string? detail,
            string? message)
        {
            this.OccurredAt = occurredAt;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Reason = reason;
            this.Detail = detail;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionEngineFallback" /> class.
        /// </summary>
        public AgentSessionEngineFallback()
        {
        }

    }
}