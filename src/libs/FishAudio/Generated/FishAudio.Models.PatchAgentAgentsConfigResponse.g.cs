
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAgentAgentsConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Content hash of the draft; equal to a version's config_hash when the draft has no unpublished changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentPromptConfig Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentVoiceConfig Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentConversationConfig Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentToolsConfig Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentWebhooksConfig Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicAgentKnowledgeBaseConfig KnowledgeBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentAnalysisConfig Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentGuardrailsConfig Guardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentAgentsConfigResponse" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="configHash">
        /// Content hash of the draft; equal to a version's config_hash when the draft has no unpublished changes.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="conversation"></param>
        /// <param name="tools"></param>
        /// <param name="webhooks"></param>
        /// <param name="knowledgeBase"></param>
        /// <param name="analysis"></param>
        /// <param name="guardrails"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAgentAgentsConfigResponse(
            string agentId,
            string configHash,
            global::FishAudio.AgentPromptConfig prompt,
            global::FishAudio.AgentVoiceConfig voice,
            global::FishAudio.AgentConversationConfig conversation,
            global::FishAudio.PublicAgentToolsConfig tools,
            global::FishAudio.PublicAgentWebhooksConfig webhooks,
            global::FishAudio.PublicAgentKnowledgeBaseConfig knowledgeBase,
            global::FishAudio.AgentAnalysisConfig analysis,
            global::FishAudio.AgentGuardrailsConfig guardrails,
            global::System.DateTime updatedAt)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConfigHash = configHash ?? throw new global::System.ArgumentNullException(nameof(configHash));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
            this.KnowledgeBase = knowledgeBase ?? throw new global::System.ArgumentNullException(nameof(knowledgeBase));
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.Guardrails = guardrails ?? throw new global::System.ArgumentNullException(nameof(guardrails));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentAgentsConfigResponse" /> class.
        /// </summary>
        public PatchAgentAgentsConfigResponse()
        {
        }

    }
}