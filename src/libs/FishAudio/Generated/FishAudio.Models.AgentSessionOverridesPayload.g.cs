
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Wire twin of @fishaudio/agent-protocol `SessionOverrides` (session.ts).<br/>
    /// Every field must be allow-listed in Agent.overrides_allowed; unauthorized<br/>
    /// fields fail session creation loudly rather than being silently dropped.
    /// </summary>
    public sealed partial class AgentSessionOverridesPayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_prompt")]
        public string? FirstMessagePrompt { get; set; }

        /// <summary>
        /// When the opener plays in this session instead of the agent's `prompt.first_message_start`: `agent_first` or `wait_for_caller`. Rides the same `first_message` override switch. `wait_for_caller` is rejected with 422 when the agent's opener is off and the session brings no `first_message` or `first_message_prompt`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_start")]
        public global::FishAudio.AgentSessionOverridesPayloadFirstMessageStart? FirstMessageStart { get; set; }

        /// <summary>
        /// Milliseconds (1000-5000) a `wait_for_caller` session waits before it speaks anyway, instead of the agent's `prompt.first_message_max_wait_ms`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_max_wait_ms")]
        public int? FirstMessageMaxWaitMs { get; set; }

        /// <summary>
        /// Whether the caller can cut the opener off in this session, instead of the agent's `prompt.first_message_interruptible`. `false` protects it: it always plays to the end and what the caller says meanwhile is dropped. Omit it or send `null` to keep the agent's value.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_interruptible")]
        public bool? FirstMessageInterruptible { get; set; }

        /// <summary>
        /// Limited to 64000 tokens (o200k_base), 32000 when `llm.model` is `google/gemma-4-26b-a4b-it` (the agent's), same budget as the configured prompt it replaces.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The voice this session speaks instead of the agent's: a Voice Library voice or one of your clones by id, or one of the live3 speech model's own voices by its lowercase name (clara, nora, ...). A name on a session that runs on Fish TTS speaks the Voice Library counterpart of that voice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::FishAudio.AgentSessionOverridesPayloadLanguage? Language { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::FishAudio.AgentSessionAsrOverridesPayload? Asr { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::FishAudio.AgentSessionLlmOverridesPayload? Llm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionOverridesPayload" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessagePrompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageStart">
        /// When the opener plays in this session instead of the agent's `prompt.first_message_start`: `agent_first` or `wait_for_caller`. Rides the same `first_message` override switch. `wait_for_caller` is rejected with 422 when the agent's opener is off and the session brings no `first_message` or `first_message_prompt`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageMaxWaitMs">
        /// Milliseconds (1000-5000) a `wait_for_caller` session waits before it speaks anyway, instead of the agent's `prompt.first_message_max_wait_ms`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageInterruptible">
        /// Whether the caller can cut the opener off in this session, instead of the agent's `prompt.first_message_interruptible`. `false` protects it: it always plays to the end and what the caller says meanwhile is dropped. Omit it or send `null` to keep the agent's value.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemPrompt">
        /// Limited to 64000 tokens (o200k_base), 32000 when `llm.model` is `google/gemma-4-26b-a4b-it` (the agent's), same budget as the configured prompt it replaces.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voiceId">
        /// The voice this session speaks instead of the agent's: a Voice Library voice or one of your clones by id, or one of the live3 speech model's own voices by its lowercase name (clara, nora, ...). A name on a session that runs on Fish TTS speaks the Voice Library counterpart of that voice.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="asr">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="llm">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionOverridesPayload(
            string? firstMessage,
            string? firstMessagePrompt,
            global::FishAudio.AgentSessionOverridesPayloadFirstMessageStart? firstMessageStart,
            int? firstMessageMaxWaitMs,
            bool? firstMessageInterruptible,
            string? systemPrompt,
            string? voiceId,
            global::FishAudio.AgentSessionOverridesPayloadLanguage? language,
            global::FishAudio.AgentSessionAsrOverridesPayload? asr,
            global::FishAudio.AgentSessionLlmOverridesPayload? llm)
        {
            this.FirstMessage = firstMessage;
            this.FirstMessagePrompt = firstMessagePrompt;
            this.FirstMessageStart = firstMessageStart;
            this.FirstMessageMaxWaitMs = firstMessageMaxWaitMs;
            this.FirstMessageInterruptible = firstMessageInterruptible;
            this.SystemPrompt = systemPrompt;
            this.VoiceId = voiceId;
            this.Language = language;
            this.Asr = asr;
            this.Llm = llm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionOverridesPayload" /> class.
        /// </summary>
        public AgentSessionOverridesPayload()
        {
        }

    }
}