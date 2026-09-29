
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRun
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestRunTestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestRunTestType TestType { get; set; }

        /// <summary>
        /// Which repeat of the test in its batch this run is.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_index")]
        public int? RepeatIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestRunStatus Status { get; set; }

        /// <summary>
        /// The judge could not decide, or a tool call had no mock answer.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_review")]
        public bool? NeedsReview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::FishAudio.PublicAgentTestRunUsage? Usage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The reply a scripted test judged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_reply")]
        public string? AgentReply { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_reasoning")]
        public string? JudgeReasoning { get; set; }

        /// <summary>
        /// The agent draft's config hash the run tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        public string? ConfigHash { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public int? LatencyMs { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation_result")]
        public global::FishAudio.AgentTestSimulationResult? SimulationResult { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public global::FishAudio.PublicAgentTestRunChannel? Channel { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns_used")]
        public int? TurnsUsed { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_by")]
        public global::FishAudio.PublicAgentTestRunEndedBy? EndedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_gaps")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? MockGaps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRun" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="testId"></param>
        /// <param name="agentId"></param>
        /// <param name="testType"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="batchId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="repeatIndex">
        /// Which repeat of the test in its batch this run is.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="needsReview">
        /// The judge could not decide, or a tool call had no mock answer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="error"></param>
        /// <param name="usage"></param>
        /// <param name="startedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="finishedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentReply">
        /// The reply a scripted test judged.
        /// </param>
        /// <param name="judgeReasoning"></param>
        /// <param name="configHash">
        /// The agent draft's config hash the run tested.
        /// </param>
        /// <param name="latencyMs">
        /// Default Value: 0
        /// </param>
        /// <param name="simulationResult">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="channel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="turnsUsed">
        /// Default Value: 0
        /// </param>
        /// <param name="endedBy">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mockGaps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRun(
            string runId,
            string testId,
            string agentId,
            global::FishAudio.PublicAgentTestRunTestType testType,
            global::FishAudio.PublicAgentTestRunStatus status,
            global::System.DateTime createdAt,
            string? batchId,
            int? repeatIndex,
            bool? needsReview,
            string? error,
            global::FishAudio.PublicAgentTestRunUsage? usage,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            string? agentReply,
            string? judgeReasoning,
            string? configHash,
            int? latencyMs,
            global::FishAudio.AgentTestSimulationResult? simulationResult,
            global::FishAudio.PublicAgentTestRunChannel? channel,
            int? turnsUsed,
            global::FishAudio.PublicAgentTestRunEndedBy? endedBy,
            global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? mockGaps)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BatchId = batchId;
            this.TestType = testType;
            this.RepeatIndex = repeatIndex;
            this.Status = status;
            this.NeedsReview = needsReview;
            this.Error = error;
            this.Usage = usage;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.AgentReply = agentReply;
            this.JudgeReasoning = judgeReasoning;
            this.ConfigHash = configHash;
            this.LatencyMs = latencyMs;
            this.SimulationResult = simulationResult;
            this.Channel = channel;
            this.TurnsUsed = turnsUsed;
            this.EndedBy = endedBy;
            this.MockGaps = mockGaps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRun" /> class.
        /// </summary>
        public PublicAgentTestRun()
        {
        }

    }
}