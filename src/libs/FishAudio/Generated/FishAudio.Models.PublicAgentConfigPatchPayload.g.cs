
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentConfigPatchPayload
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::FishAudio.PublicAgentPromptPatch? Prompt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::FishAudio.PublicAgentVoicePatch? Voice { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::FishAudio.PublicAgentConversationPatch? Conversation { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::FishAudio.PublicAgentToolsPatch? Tools { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::FishAudio.PublicAgentWebhooksPatch? Webhooks { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::FishAudio.PublicAgentKnowledgeBasePatch? KnowledgeBase { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public global::FishAudio.PublicAgentAnalysisPatch? Analysis { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::FishAudio.PublicAgentGuardrailsPatch? Guardrails { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::FishAudio.PublicAgentLLMPatch? Llm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConfigPatchPayload" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="voice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="conversation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhooks">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="knowledgeBase">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="analysis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="guardrails">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="llm">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentConfigPatchPayload(
            global::FishAudio.PublicAgentPromptPatch? prompt,
            global::FishAudio.PublicAgentVoicePatch? voice,
            global::FishAudio.PublicAgentConversationPatch? conversation,
            global::FishAudio.PublicAgentToolsPatch? tools,
            global::FishAudio.PublicAgentWebhooksPatch? webhooks,
            global::FishAudio.PublicAgentKnowledgeBasePatch? knowledgeBase,
            global::FishAudio.PublicAgentAnalysisPatch? analysis,
            global::FishAudio.PublicAgentGuardrailsPatch? guardrails,
            global::FishAudio.PublicAgentLLMPatch? llm)
        {
            this.Prompt = prompt;
            this.Voice = voice;
            this.Conversation = conversation;
            this.Tools = tools;
            this.Webhooks = webhooks;
            this.KnowledgeBase = knowledgeBase;
            this.Analysis = analysis;
            this.Guardrails = guardrails;
            this.Llm = llm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConfigPatchPayload" /> class.
        /// </summary>
        public PublicAgentConfigPatchPayload()
        {
        }

    }
}