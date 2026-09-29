
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentAgentsTestsRunRequest
    {
        /// <summary>
        /// Attached tests to run. Omit to run every test attached to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_ids")]
        public global::System.Collections.Generic.IList<string>? TestIds { get; set; }

        /// <summary>
        /// Run every selected test this many times in this batch, in place of each test's own repeat count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsTestsRunRequest" /> class.
        /// </summary>
        /// <param name="testIds">
        /// Attached tests to run. Omit to run every test attached to the agent.
        /// </param>
        /// <param name="repeatCount">
        /// Run every selected test this many times in this batch, in place of each test's own repeat count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentAgentsTestsRunRequest(
            global::System.Collections.Generic.IList<string>? testIds,
            int? repeatCount)
        {
            this.TestIds = testIds;
            this.RepeatCount = repeatCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentAgentsTestsRunRequest" /> class.
        /// </summary>
        public CreateAgentAgentsTestsRunRequest()
        {
        }

    }
}