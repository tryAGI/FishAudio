
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentGuardrailsConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public bool? Focus { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manipulation")]
        public bool? Manipulation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailsConfig" /> class.
        /// </summary>
        /// <param name="focus">
        /// Default Value: false
        /// </param>
        /// <param name="manipulation">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGuardrailsConfig(
            bool? focus,
            bool? manipulation)
        {
            this.Focus = focus;
            this.Manipulation = manipulation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailsConfig" /> class.
        /// </summary>
        public AgentGuardrailsConfig()
        {
        }

    }
}