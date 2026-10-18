
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRunTokenCharge
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tokens { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="PublicAgentTestRunTokenCharge" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="amountUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunTokenCharge(
            int tokens,
            string amountUsd)
        {
            this.Tokens = tokens;
            this.AmountUsd = amountUsd ?? throw new global::System.ArgumentNullException(nameof(amountUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunTokenCharge" /> class.
        /// </summary>
        public PublicAgentTestRunTokenCharge()
        {
        }

    }
}