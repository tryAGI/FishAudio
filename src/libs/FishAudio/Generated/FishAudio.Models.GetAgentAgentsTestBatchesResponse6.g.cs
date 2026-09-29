
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAgentAgentsTestBatchesResponse6
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.GetAgentAgentsTestBatchesResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.GetAgentAgentsTestBatchesResponseStatus Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAgentsTestBatchesResponse6" /> class.
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
        /// <param name="runs"></param>
        /// <param name="passRate">
        /// passed / (passed + failed), null until a run passed or failed. Error runs never judged the agent and are left out.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentAgentsTestBatchesResponse6(
            string batchId,
            string agentId,
            global::FishAudio.GetAgentAgentsTestBatchesResponseStatus status,
            bool completed,
            int passed,
            int failed,
            int errors,
            global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun> runs,
            double? passRate)
        {
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.Completed = completed;
            this.Passed = passed;
            this.Failed = failed;
            this.Errors = errors;
            this.PassRate = passRate;
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentAgentsTestBatchesResponse6" /> class.
        /// </summary>
        public GetAgentAgentsTestBatchesResponse6()
        {
        }

    }
}