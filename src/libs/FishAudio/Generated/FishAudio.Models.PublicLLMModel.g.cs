
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
        /// <param name="longContext">
        /// Rates that replace `usd_per_million_tokens` on a request with a long prompt. Null when the model has no such tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMModel(
            global::FishAudio.PublicLLMModelId id,
            bool includedInConversationRate,
            global::FishAudio.PublicLLMTokenRates usdPerMillionTokens,
            global::FishAudio.PublicLLMLongContextRates? longContext)
        {
            this.Id = id;
            this.IncludedInConversationRate = includedInConversationRate;
            this.UsdPerMillionTokens = usdPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(usdPerMillionTokens));
            this.LongContext = longContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMModel" /> class.
        /// </summary>
        public PublicLLMModel()
        {
        }

    }
}