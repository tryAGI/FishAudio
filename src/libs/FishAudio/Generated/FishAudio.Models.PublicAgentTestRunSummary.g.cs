
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestRunSummary
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestRunSummaryTestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestRunSummaryTestType TestType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestRunSummaryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestRunSummaryStatus Status { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunSummary" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestRunSummary(
            string runId,
            string testId,
            string agentId,
            global::FishAudio.PublicAgentTestRunSummaryTestType testType,
            global::FishAudio.PublicAgentTestRunSummaryStatus status,
            global::System.DateTime createdAt,
            string? batchId,
            int? repeatIndex,
            bool? needsReview,
            string? error,
            global::FishAudio.PublicAgentTestRunUsage? usage,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestRunSummary" /> class.
        /// </summary>
        public PublicAgentTestRunSummary()
        {
        }

    }
}