
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
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_prompt")]
        public string? FirstMessagePrompt { get; set; }

        /// <summary>
        /// Limited to 4000 tokens (o200k_base), same budget as the configured prompt it replaces.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

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
        /// <param name="firstMessagePrompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="systemPrompt">
        /// Limited to 4000 tokens (o200k_base), same budget as the configured prompt it replaces.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voiceId">
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
            string? firstMessagePrompt,
            string? systemPrompt,
            string? voiceId,
            global::FishAudio.AgentSessionOverridesPayloadLanguage2? language)
        {
            this.FirstMessage = firstMessage;
            this.FirstMessagePrompt = firstMessagePrompt;
            this.SystemPrompt = systemPrompt;
            this.VoiceId = voiceId;
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