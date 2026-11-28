
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One follow-up while the caller stays silent.
    /// </summary>
    public sealed partial class AgentReengageStep
    {
        /// <summary>
        /// Seconds of silence, counted from the end of what the agent last said, before this follow-up, 3 to 600 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AfterSeconds { get; set; }

        /// <summary>
        /// Text the agent says word for word as this follow-up, at most 500 characters. `{{variable}}` placeholders are filled in for each session. "" (default) lets the agent word the follow-up itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageStep" /> class.
        /// </summary>
        /// <param name="afterSeconds">
        /// Seconds of silence, counted from the end of what the agent last said, before this follow-up, 3 to 600 seconds.
        /// </param>
        /// <param name="message">
        /// Text the agent says word for word as this follow-up, at most 500 characters. `{{variable}}` placeholders are filled in for each session. "" (default) lets the agent word the follow-up itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReengageStep(
            int afterSeconds,
            string? message)
        {
            this.AfterSeconds = afterSeconds;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReengageStep" /> class.
        /// </summary>
        public AgentReengageStep()
        {
        }

    }
}