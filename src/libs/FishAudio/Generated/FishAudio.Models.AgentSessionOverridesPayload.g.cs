
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Wire twin of @fishaudio/agent-protocol `SessionOverrides` (session.ts).<br/>
    /// Every field must be allow-listed in Agent.overrides_allowed; unauthorized<br/>
    /// fields fail session creation loudly rather than being silently dropped.
    /// </summary>
    public sealed partial class AgentSessionOverridesPayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_profile_id")]
        public string? VoiceProfileId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::FishAudio.AgentSessionOverridesPayloadLanguage2? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionOverridesPayload" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemPrompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voiceProfileId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionOverridesPayload(
            string? firstMessage,
            string? systemPrompt,
            string? voiceProfileId,
            global::FishAudio.AgentSessionOverridesPayloadLanguage2? language)
        {
            this.FirstMessage = firstMessage;
            this.SystemPrompt = systemPrompt;
            this.VoiceProfileId = voiceProfileId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionOverridesPayload" /> class.
        /// </summary>
        public AgentSessionOverridesPayload()
        {
        }

    }
}