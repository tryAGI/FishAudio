
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRunUsage
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_replies")]
        public int? AgentReplies { get; set; }

        /// <summary>
        /// LLM cost of the run in USD, null while any part is unpriced.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public string? CostUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunUsage" /> class.
        /// </summary>
        /// <param name="agentReplies">
        /// Default Value: 0
        /// </param>
        /// <param name="costUsd">
        /// LLM cost of the run in USD, null while any part is unpriced.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunUsage(
            int? agentReplies,
            string? costUsd)
        {
            this.AgentReplies = agentReplies;
            this.CostUsd = costUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunUsage" /> class.
        /// </summary>
        public PublicAgentTestRunUsage()
        {
        }

    }
}