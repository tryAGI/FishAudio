
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Per-session subset of the agent config's llm section, same field names.
    /// </summary>
    public sealed partial class AgentSessionLlmOverridesPayload
    {
        /// <summary>
        /// Replaces the agent's `llm.fallback` for this session, same shape and rules. Each `custom` entry needs its `api_key`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        public global::FishAudio.AgentLLMFallbackPayload? Fallback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmOverridesPayload" /> class.
        /// </summary>
        /// <param name="fallback">
        /// Replaces the agent's `llm.fallback` for this session, same shape and rules. Each `custom` entry needs its `api_key`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionLlmOverridesPayload(
            global::FishAudio.AgentLLMFallbackPayload? fallback)
        {
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmOverridesPayload" /> class.
        /// </summary>
        public AgentSessionLlmOverridesPayload()
        {
        }

    }
}