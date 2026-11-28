
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The Tests settings of a workspace, shared by every test in it.
    /// </summary>
    public sealed partial class GetAgentTestSettingsResponse
    {
        /// <summary>
        /// The workspace these settings belong to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// The judge of a Single Turn or Simulation test that names no `judge` of its own, with the reasoning level it judges at. Always the judge such a test is judged by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentTestJudge Judge { get; set; }

        /// <summary>
        /// True while the workspace has not set `judge` and reads the platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool JudgeIsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTestSettingsResponse" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// The workspace these settings belong to.
        /// </param>
        /// <param name="judge">
        /// The judge of a Single Turn or Simulation test that names no `judge` of its own, with the reasoning level it judges at. Always the judge such a test is judged by.
        /// </param>
        /// <param name="judgeIsDefault">
        /// True while the workspace has not set `judge` and reads the platform default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentTestSettingsResponse(
            string workspaceId,
            global::FishAudio.AgentTestJudge judge,
            bool judgeIsDefault)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Judge = judge ?? throw new global::System.ArgumentNullException(nameof(judge));
            this.JudgeIsDefault = judgeIsDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTestSettingsResponse" /> class.
        /// </summary>
        public GetAgentTestSettingsResponse()
        {
        }

    }
}