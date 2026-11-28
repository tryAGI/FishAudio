
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentPromptPatch
    {
        /// <summary>
        /// Limited to 64000 tokens (o200k_base), 32000 when `llm.model` is `google/gemma-4-26b-a4b-it`; keeping it under 2000 tokens is recommended for latency and cost.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_mode")]
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? FirstMessageMode { get; set; }

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
        /// When the opener plays. `agent_first` (default): the agent speaks as soon as the call connects. `wait_for_caller`: the agent waits for the caller to speak first and plays the opener anyway once `first_message_max_wait_ms` has passed. `wait_for_caller` needs a `fixed` or `prompt` opener: with `first_message_mode` `off` the write is rejected with 422, and the stored values stay as they were. With a `fixed` opener the agent speaks after the caller does, or when the wait runs out; with a `prompt` opener it answers what the caller said first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_start")]
        public global::FishAudio.PublicAgentPromptPatchFirstMessageStart? FirstMessageStart { get; set; }

        /// <summary>
        /// Milliseconds (1000-5000, default 3000) a `wait_for_caller` agent waits before it speaks anyway. Stored but has no effect while `first_message_start` is `agent_first`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_max_wait_ms")]
        public int? FirstMessageMaxWaitMs { get; set; }

        /// <summary>
        /// Whether the caller can cut the opener off. `true`: interruptible. `false`: protected, the opener always plays to the end and what the caller says meanwhile is dropped, not answered afterwards. `null` or omitted (default): interruptible, the same as `true`. It does not follow `conversation.interruptible`. Reads always return `true` or `false`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_interruptible")]
        public bool? FirstMessageInterruptible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentPromptPatch" /> class.
        /// </summary>
        /// <param name="systemPrompt">
        /// Limited to 64000 tokens (o200k_base), 32000 when `llm.model` is `google/gemma-4-26b-a4b-it`; keeping it under 2000 tokens is recommended for latency and cost.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageMode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessagePrompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageStart">
        /// When the opener plays. `agent_first` (default): the agent speaks as soon as the call connects. `wait_for_caller`: the agent waits for the caller to speak first and plays the opener anyway once `first_message_max_wait_ms` has passed. `wait_for_caller` needs a `fixed` or `prompt` opener: with `first_message_mode` `off` the write is rejected with 422, and the stored values stay as they were. With a `fixed` opener the agent speaks after the caller does, or when the wait runs out; with a `prompt` opener it answers what the caller said first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageMaxWaitMs">
        /// Milliseconds (1000-5000, default 3000) a `wait_for_caller` agent waits before it speaks anyway. Stored but has no effect while `first_message_start` is `agent_first`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="firstMessageInterruptible">
        /// Whether the caller can cut the opener off. `true`: interruptible. `false`: protected, the opener always plays to the end and what the caller says meanwhile is dropped, not answered afterwards. `null` or omitted (default): interruptible, the same as `true`. It does not follow `conversation.interruptible`. Reads always return `true` or `false`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentPromptPatch(
            string? systemPrompt,
            global::FishAudio.PublicAgentPromptPatchFirstMessageMode? firstMessageMode,
            string? firstMessage,
            string? firstMessagePrompt,
            global::FishAudio.PublicAgentPromptPatchFirstMessageStart? firstMessageStart,
            int? firstMessageMaxWaitMs,
            bool? firstMessageInterruptible)
        {
            this.SystemPrompt = systemPrompt;
            this.FirstMessageMode = firstMessageMode;
            this.FirstMessage = firstMessage;
            this.FirstMessagePrompt = firstMessagePrompt;
            this.FirstMessageStart = firstMessageStart;
            this.FirstMessageMaxWaitMs = firstMessageMaxWaitMs;
            this.FirstMessageInterruptible = firstMessageInterruptible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentPromptPatch" /> class.
        /// </summary>
        public PublicAgentPromptPatch()
        {
        }

    }
}