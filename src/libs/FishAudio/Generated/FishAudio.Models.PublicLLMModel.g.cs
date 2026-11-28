
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicLLMModel
    {
        /// <summary>
        /// The model id, as set in `llm.model` on an agent's config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicLLMModelIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicLLMModelId Id { get; set; }

        /// <summary>
        /// Whether the conversation rate covers this model's tokens. When true, a conversation on the model has no LLM charge, and its rates apply where no conversation rate is charged, such as Simulation tests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_in_conversation_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludedInConversationRate { get; set; }

        /// <summary>
        /// What the model's tokens cost in USD per one million tokens, by token category, as decimal strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usd_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicLLMTokenRates UsdPerMillionTokens { get; set; }

        /// <summary>
        /// Rates that replace `usd_per_million_tokens` on a request with a long prompt. Null when the model has no such tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_context")]
        public global::FishAudio.PublicLLMLongContextRates? LongContext { get; set; }

        /// <summary>
        /// A reference time to the model's first token on a voice turn, in milliseconds. It is a measured median for comparing models, and the latency of a call varies with its prompt and the time of day. Null when the model has no measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_latency_ms")]
        public int? ReferenceLatencyMs { get; set; }

        /// <summary>
        /// The longest `prompt.system_prompt` an agent on this model can save, in o200k_base tokens. A longer one is rejected with 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_system_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSystemPromptTokens { get; set; }

        /// <summary>
        /// How the model judges `next_reply` and `simulation` tests, as the `judge` of a test or of a workspace's Tests settings. Null when it cannot judge them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_judge")]
        public global::FishAudio.PublicLLMTestJudge? TestJudge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The model id, as set in `llm.model` on an agent's config.
        /// </param>
        /// <param name="includedInConversationRate">
        /// Whether the conversation rate covers this model's tokens. When true, a conversation on the model has no LLM charge, and its rates apply where no conversation rate is charged, such as Simulation tests.
        /// </param>
        /// <param name="usdPerMillionTokens">
        /// What the model's tokens cost in USD per one million tokens, by token category, as decimal strings.
        /// </param>
        /// <param name="maxSystemPromptTokens">
        /// The longest `prompt.system_prompt` an agent on this model can save, in o200k_base tokens. A longer one is rejected with 422.
        /// </param>
        /// <param name="longContext">
        /// Rates that replace `usd_per_million_tokens` on a request with a long prompt. Null when the model has no such tier.
        /// </param>
        /// <param name="referenceLatencyMs">
        /// A reference time to the model's first token on a voice turn, in milliseconds. It is a measured median for comparing models, and the latency of a call varies with its prompt and the time of day. Null when the model has no measurement.
        /// </param>
        /// <param name="testJudge">
        /// How the model judges `next_reply` and `simulation` tests, as the `judge` of a test or of a workspace's Tests settings. Null when it cannot judge them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMModel(
            global::FishAudio.PublicLLMModelId id,
            bool includedInConversationRate,
            global::FishAudio.PublicLLMTokenRates usdPerMillionTokens,
            int maxSystemPromptTokens,
            global::FishAudio.PublicLLMLongContextRates? longContext,
            int? referenceLatencyMs,
            global::FishAudio.PublicLLMTestJudge? testJudge)
        {
            this.Id = id;
            this.IncludedInConversationRate = includedInConversationRate;
            this.UsdPerMillionTokens = usdPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(usdPerMillionTokens));
            this.LongContext = longContext;
            this.ReferenceLatencyMs = referenceLatencyMs;
            this.MaxSystemPromptTokens = maxSystemPromptTokens;
            this.TestJudge = testJudge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMModel" /> class.
        /// </summary>
        public PublicLLMModel()
        {
        }

    }
}