
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The run's platform context switches, the agent config's `context`<br/>
    /// section for a test. Off so a date pinned in the prompt holds.
    /// </summary>
    public sealed partial class AgentTestSimulationContext
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_time")]
        public bool? CurrentTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationContext" /> class.
        /// </summary>
        /// <param name="currentTime">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSimulationContext(
            bool? currentTime)
        {
            this.CurrentTime = currentTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSimulationContext" /> class.
        /// </summary>
        public AgentTestSimulationContext()
        {
        }

    }
}