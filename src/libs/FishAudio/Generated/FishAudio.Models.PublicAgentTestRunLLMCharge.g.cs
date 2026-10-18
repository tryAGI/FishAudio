
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRunLLMCharge
    {
        /// <summary>
        /// Whose tokens: the agent, the simulated user, or the judge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestRunLLMChargeParticipantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestRunLLMChargeParticipant Participant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// What these tokens charged, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AmountUsd { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::FishAudio.PublicAgentTestRunTokenCharge? Input { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read")]
        public global::FishAudio.PublicAgentTestRunTokenCharge? CacheRead { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_5m")]
        public global::FishAudio.PublicAgentTestRunTokenCharge? CacheWrite5m { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_1h")]
        public global::FishAudio.PublicAgentTestRunTokenCharge? CacheWrite1h { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::FishAudio.PublicAgentTestRunTokenCharge? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunLLMCharge" /> class.
        /// </summary>
        /// <param name="participant">
        /// Whose tokens: the agent, the simulated user, or the judge.
        /// </param>
        /// <param name="model"></param>
        /// <param name="amountUsd">
        /// What these tokens charged, in USD.
        /// </param>
        /// <param name="input">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheRead">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheWrite5m">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheWrite1h">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="output">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunLLMCharge(
            global::FishAudio.PublicAgentTestRunLLMChargeParticipant participant,
            string model,
            string amountUsd,
            global::FishAudio.PublicAgentTestRunTokenCharge? input,
            global::FishAudio.PublicAgentTestRunTokenCharge? cacheRead,
            global::FishAudio.PublicAgentTestRunTokenCharge? cacheWrite5m,
            global::FishAudio.PublicAgentTestRunTokenCharge? cacheWrite1h,
            global::FishAudio.PublicAgentTestRunTokenCharge? output)
        {
            this.Participant = participant;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AmountUsd = amountUsd ?? throw new global::System.ArgumentNullException(nameof(amountUsd));
            this.Input = input;
            this.CacheRead = cacheRead;
            this.CacheWrite5m = cacheWrite5m;
            this.CacheWrite1h = cacheWrite1h;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunLLMCharge" /> class.
        /// </summary>
        public PublicAgentTestRunLLMCharge()
        {
        }

    }
}