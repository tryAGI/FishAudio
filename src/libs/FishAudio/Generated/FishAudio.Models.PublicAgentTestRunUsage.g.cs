
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
        /// What the run was charged in USD. `0` on a finished run that is not charged: runs that end in `error` and tests other than simulations. Null until the run's charge is settled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public string? CostUsd { get; set; }

        /// <summary>
        /// The fee per agent reply. Null unless charged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_fee")]
        public global::FishAudio.PublicAgentTestRunPlatformFee? PlatformFee { get; set; }

        /// <summary>
        /// LLM tokens, one entry per participant and model, by token category. With `platform_fee` they add up to `cost_usd`. Empty unless charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunLLMCharge>? Llm { get; set; }

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
        /// What the run was charged in USD. `0` on a finished run that is not charged: runs that end in `error` and tests other than simulations. Null until the run's charge is settled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="platformFee">
        /// The fee per agent reply. Null unless charged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="llm">
        /// LLM tokens, one entry per participant and model, by token category. With `platform_fee` they add up to `cost_usd`. Empty unless charged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunUsage(
            int? agentReplies,
            string? costUsd,
            global::FishAudio.PublicAgentTestRunPlatformFee? platformFee,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunLLMCharge>? llm)
        {
            this.AgentReplies = agentReplies;
            this.CostUsd = costUsd;
            this.PlatformFee = platformFee;
            this.Llm = llm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunUsage" /> class.
        /// </summary>
        public PublicAgentTestRunUsage()
        {
        }

    }
}