
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMMessageTokenCost
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_version")]
        public string? RateVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.LLMMessageTokenCostCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.LLMMessageTokenCostCategory Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_million")]
        public string? RatePerMillion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public string? CostUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMMessageTokenCost" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="model"></param>
        /// <param name="rateVersion"></param>
        /// <param name="tokens"></param>
        /// <param name="ratePerMillion"></param>
        /// <param name="costUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMMessageTokenCost(
            global::FishAudio.LLMMessageTokenCostCategory category,
            string? model,
            string? rateVersion,
            int? tokens,
            string? ratePerMillion,
            string? costUsd)
        {
            this.Model = model;
            this.RateVersion = rateVersion;
            this.Category = category;
            this.Tokens = tokens;
            this.RatePerMillion = ratePerMillion;
            this.CostUsd = costUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMMessageTokenCost" /> class.
        /// </summary>
        public LLMMessageTokenCost()
        {
        }

    }
}