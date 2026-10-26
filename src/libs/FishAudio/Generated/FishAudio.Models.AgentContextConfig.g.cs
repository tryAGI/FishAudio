
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Facts the platform tells the agent on its own, one switch per fact.<br/>
    /// The same mechanism as a guardrail with the opposite sign: a guardrail is<br/>
    /// a prompt addition that constrains, a context switch is one that informs.
    /// </summary>
    public sealed partial class AgentContextConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_time")]
        public bool? CurrentTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentContextConfig" /> class.
        /// </summary>
        /// <param name="currentTime">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentContextConfig(
            bool? currentTime)
        {
            this.CurrentTime = currentTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentContextConfig" /> class.
        /// </summary>
        public AgentContextConfig()
        {
        }

    }
}