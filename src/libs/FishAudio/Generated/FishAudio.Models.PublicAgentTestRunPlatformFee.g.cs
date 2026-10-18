
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRunPlatformFee
    {
        /// <summary>
        /// USD per agent reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RateUsd { get; set; }

        /// <summary>
        /// `agent_replies` times `rate_usd`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunPlatformFee" /> class.
        /// </summary>
        /// <param name="rateUsd">
        /// USD per agent reply.
        /// </param>
        /// <param name="amountUsd">
        /// `agent_replies` times `rate_usd`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunPlatformFee(
            string rateUsd,
            string amountUsd)
        {
            this.RateUsd = rateUsd ?? throw new global::System.ArgumentNullException(nameof(rateUsd));
            this.AmountUsd = amountUsd ?? throw new global::System.ArgumentNullException(nameof(amountUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunPlatformFee" /> class.
        /// </summary>
        public PublicAgentTestRunPlatformFee()
        {
        }

    }
}