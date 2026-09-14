
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMMessageUsage
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_generation_id")]
        public string? MessageGenerationId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public int? TurnId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.LLMMessageUsageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.LLMMessageUsageStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.LLMMessageUsageBillingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.LLMMessageUsageBillingMode BillingMode { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_count")]
        public int? CallCount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_complete")]
        public bool? UsageComplete { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ids")]
        public global::System.Collections.Generic.IList<string>? CallIds { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public string? CostUsd { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_cost_usd")]
        public string? BillableCostUsd { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_cost_usd")]
        public string? KnownCostUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMMessageUsage" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="billingMode"></param>
        /// <param name="messageGenerationId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="turnId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callCount">
        /// Default Value: 0
        /// </param>
        /// <param name="usageComplete">
        /// Default Value: false
        /// </param>
        /// <param name="callIds"></param>
        /// <param name="costUsd">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="billableCostUsd">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="knownCostUsd">
        /// Default Value: 0
        /// </param>
        /// <param name="tokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMMessageUsage(
            global::FishAudio.LLMMessageUsageStatus status,
            global::FishAudio.LLMMessageUsageBillingMode billingMode,
            string? messageGenerationId,
            int? turnId,
            int? callCount,
            bool? usageComplete,
            global::System.Collections.Generic.IList<string>? callIds,
            string? costUsd,
            string? billableCostUsd,
            string? knownCostUsd,
            global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? tokens)
        {
            this.MessageGenerationId = messageGenerationId;
            this.TurnId = turnId;
            this.Status = status;
            this.BillingMode = billingMode;
            this.CallCount = callCount;
            this.UsageComplete = usageComplete;
            this.CallIds = callIds;
            this.CostUsd = costUsd;
            this.BillableCostUsd = billableCostUsd;
            this.KnownCostUsd = knownCostUsd;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMMessageUsage" /> class.
        /// </summary>
        public LLMMessageUsage()
        {
        }

    }
}