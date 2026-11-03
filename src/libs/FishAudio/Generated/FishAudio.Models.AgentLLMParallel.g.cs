
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentLLMParallel
    {
        /// <summary>
        /// Default Value: 1500
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kick_in_ms")]
        public int? KickInMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMParallel" /> class.
        /// </summary>
        /// <param name="kickInMs">
        /// Default Value: 1500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLLMParallel(
            int? kickInMs)
        {
            this.KickInMs = kickInMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLLMParallel" /> class.
        /// </summary>
        public AgentLLMParallel()
        {
        }

    }
}