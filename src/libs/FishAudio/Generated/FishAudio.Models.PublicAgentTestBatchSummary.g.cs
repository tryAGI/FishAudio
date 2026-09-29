
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentTestBatchSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// running until every run has finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestBatchSummaryStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Completed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// passed / (passed + failed), null until a run passed or failed. Error runs never judged the agent and are left out.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_rate")]
        public double? PassRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// Where the batch was started: the console or the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryTriggerSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentTestBatchSummaryTriggerSource TriggerSource { get; set; }

        /// <summary>
        /// When the first run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the last run finished, null until the batch completed.<br/>
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
        /// Initializes a new instance of the <see cref="PublicAgentTestBatchSummary" /> class.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="agentId"></param>
        /// <param name="status">
        /// running until every run has finished.
        /// </param>
        /// <param name="completed"></param>
        /// <param name="passed"></param>
        /// <param name="failed"></param>
        /// <param name="errors"></param>
        /// <param name="runCount"></param>
        /// <param name="triggerSource">
        /// Where the batch was started: the console or the API.
        /// </param>
        /// <param name="createdAt">
        /// When the first run was created.
        /// </param>
        /// <param name="passRate">
        /// passed / (passed + failed), null until a run passed or failed. Error runs never judged the agent and are left out.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="finishedAt">
        /// When the last run finished, null until the batch completed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentTestBatchSummary(
            string batchId,
            string agentId,
            global::FishAudio.PublicAgentTestBatchSummaryStatus status,
            bool completed,
            int passed,
            int failed,
            int errors,
            int runCount,
            global::FishAudio.PublicAgentTestBatchSummaryTriggerSource triggerSource,
            global::System.DateTime createdAt,
            double? passRate,
            global::System.DateTime? finishedAt)
        {
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.Completed = completed;
            this.Passed = passed;
            this.Failed = failed;
            this.Errors = errors;
            this.PassRate = passRate;
            this.RunCount = runCount;
            this.TriggerSource = triggerSource;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentTestBatchSummary" /> class.
        /// </summary>
        public PublicAgentTestBatchSummary()
        {
        }

    }
}