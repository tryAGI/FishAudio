
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The model that judges a `next_reply` or `simulation` test, and how much<br/>
    /// it reasons before its verdict.
    /// </summary>
    public sealed partial class AgentTestJudge
    {
        /// <summary>
        /// One of the models `GET /v1/agent/llm-models` lists with `test_judge`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// One of the levels `test_judge.reasoning_levels` lists for the model. Null reasons at the model's default level.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_level")]
        public global::FishAudio.AgentTestJudgeReasoningLevel? ReasoningLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestJudge" /> class.
        /// </summary>
        /// <param name="model">
        /// One of the models `GET /v1/agent/llm-models` lists with `test_judge`.
        /// </param>
        /// <param name="reasoningLevel">
        /// One of the levels `test_judge.reasoning_levels` lists for the model. Null reasons at the model's default level.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestJudge(
            string model,
            global::FishAudio.AgentTestJudgeReasoningLevel? reasoningLevel)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ReasoningLevel = reasoningLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestJudge" /> class.
        /// </summary>
        public AgentTestJudge()
        {
        }

    }
}