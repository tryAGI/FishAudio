
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicLLMLongContextRates
    {
        /// <summary>
        /// A request whose prompt is larger than this many tokens bills at these rates. The prompt is its input, cache read and cache write tokens together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("over_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OverPromptTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usd_per_million_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicLLMTokenRates UsdPerMillionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMLongContextRates" /> class.
        /// </summary>
        /// <param name="overPromptTokens">
        /// A request whose prompt is larger than this many tokens bills at these rates. The prompt is its input, cache read and cache write tokens together.
        /// </param>
        /// <param name="usdPerMillionTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMLongContextRates(
            int overPromptTokens,
            global::FishAudio.PublicLLMTokenRates usdPerMillionTokens)
        {
            this.OverPromptTokens = overPromptTokens;
            this.UsdPerMillionTokens = usdPerMillionTokens ?? throw new global::System.ArgumentNullException(nameof(usdPerMillionTokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMLongContextRates" /> class.
        /// </summary>
        public PublicLLMLongContextRates()
        {
        }

    }
}