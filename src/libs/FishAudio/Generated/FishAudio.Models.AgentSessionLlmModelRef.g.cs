
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// A model as the agent config names it: a platform model id in `model`,<br/>
    /// or a customer endpoint in `custom` (never its key).
    /// </summary>
    public sealed partial class AgentSessionLlmModelRef
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::FishAudio.AgentSessionLlmCustomRef? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmModelRef" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionLlmModelRef(
            string? model,
            global::FishAudio.AgentSessionLlmCustomRef? custom)
        {
            this.Model = model;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmModelRef" /> class.
        /// </summary>
        public AgentSessionLlmModelRef()
        {
        }

    }
}