
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Per-session subset of the agent config's asr section, same field names.
    /// </summary>
    public sealed partial class AgentSessionAsrOverridesPayload
    {
        /// <summary>
        /// Speech recognition model for this session, same values as the agent's `asr.model`. A model in preview is refused with 403 unless your team has access or the agent already uses it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::FishAudio.AgentSessionAsrOverridesPayloadModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAsrOverridesPayload" /> class.
        /// </summary>
        /// <param name="model">
        /// Speech recognition model for this session, same values as the agent's `asr.model`. A model in preview is refused with 403 unless your team has access or the agent already uses it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionAsrOverridesPayload(
            global::FishAudio.AgentSessionAsrOverridesPayloadModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionAsrOverridesPayload" /> class.
        /// </summary>
        public AgentSessionAsrOverridesPayload()
        {
        }

    }
}