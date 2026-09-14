
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummary? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryStatus? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummarySource? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDirection? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDialStatus? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryAnsweredBy? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.JsonValue? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionCreatePayload? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayload? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, int?, double?, bool?>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayloadLanguage? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResult? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResultResult? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValue? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValueType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<bool?, double?, string, object>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResult? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResultStatus? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItem? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsage? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItemRole? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolCallItem? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItem? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItemStatus? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCost? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCostCategory? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageStatus? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageBillingMode? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntity? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityRole? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityStatus? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntity? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityStatus? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityPublicationState? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityOverridesAllowedItem? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundPatch? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatch? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatchAction? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatch? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchMode? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisCriterion? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataField? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataFieldType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisPatch? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigPatchPayload? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatch? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatch? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatch? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsPatch? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksPatch? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBasePatch? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentGuardrailsPatch? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatch? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchEagerness? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentCreatePayload? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMCustomConfig? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatchModel? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatch? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhookPayload? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhookPayload? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayload? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisConfig? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataField? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisCriterion? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataFieldType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfigLanguage? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigEagerness? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestination? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentGuardrailsConfig? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedacted? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedactedModel? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomConfigRedacted? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfig? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfig? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfigFirstMessageMode? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfig? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationMode? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationWarmConnect? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVoiceConfig? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVoiceConfigSpeakingLanguage? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBaseConfig? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksConfig? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhook? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhook? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVersionSummary? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigEntity? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicKnowledgeSourceSummary? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicDependentAgent? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummary? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryToolType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryMethod? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookArgumentPayload? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayload? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayloadKind? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookMockResponsePayload? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayload? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeader? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeaderKind? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayload? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadMethod? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntity? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityProvider? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityStatus? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberPurchasePayload? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayload? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayload? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PhoneCallCreatePayload? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ASRSegment? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ProsodyControl? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ReferenceAudio? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestFormat? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestLatency? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestFormat? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestLatency? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampAlignment? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampSegment? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEventReason? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFlushEvent? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStartEvent? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStopEvent? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveTextEvent? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignCandidate? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AuthorEntity? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelAudioQualityEntity? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntity? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTrainMode? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityState? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.SampleEntity? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityVisibility? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTakedownCategory? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityPvcReleaseState? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelQualityEntity? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest2? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest2? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility2? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest3? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility3? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest4? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility4? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility2? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest3? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility3? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest4? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility4? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsPublicationState? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsModel? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampModel? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampModel? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelSortBy? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse2? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse3? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse3? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse3? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse4? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse2? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse3? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse4? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse5? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse6? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse7? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse8? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse9? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse10? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse5? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseStatus? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseSource? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDirection? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDialStatus? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseAnsweredBy? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ItemsItem? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminator? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse6? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse7? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse8? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse9? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponseStatus? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse3? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse4? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse5? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse3? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse4? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse2? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse3? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse4? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseStatus? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponsePublicationState? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse2? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse3? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse4? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse5? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse5? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseStatus? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponsePublicationState? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse6? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse7? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse8? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseStatus? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponsePublicationState? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse2? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse3? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse4? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse5? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse2? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse3? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse3? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse2? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse3? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse4? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse2? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse3? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse4? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse5? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse2? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse3? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse4? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse5? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse6? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse3? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse4? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse5? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse6? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse7? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse8? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse9? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse2? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse3? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse4? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse5? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse2? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse3? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse4? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse3? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse4? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse5? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse6? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse5? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse6? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse7? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse8? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse3? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse4? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse5? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse6? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse3? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse4? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse3? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse4? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse5? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseToolType? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseMethod? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseErrorHandling? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse2? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse3? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse4? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse6? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseToolType? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseMethod? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseErrorHandling? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseExecutionMode? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse7? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse8? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse9? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseToolType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseMethod? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseErrorHandling? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseExecutionMode? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse2? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse3? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse4? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse5? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse6? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse3? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse4? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse3? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse4? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse2? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse3? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse4? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse5? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseProvider? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseStatus? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse2? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse3? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse4? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse5? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse6? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse7? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse8? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse9? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse6? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseProvider? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseStatus? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse7? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse8? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse9? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseProvider? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseStatus? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse2? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse3? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse4? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse5? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse6? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse3? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse2? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse3? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse4? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse5? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse6? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse7? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse8? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse9? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse10? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse3? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse4? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse2? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse3? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse2? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse3? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse4? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse2? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse3? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse4? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse2? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse3? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse4? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTrainMode? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseState? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseVisibility? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTakedownCategory? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponsePvcReleaseState? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse2? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse2? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTrainMode? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseState? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseVisibility? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTakedownCategory? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponsePvcReleaseState? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse3? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse4? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse2? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse2? Type507 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisDataValue>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisCriterionResult>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageTokenCost>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisDataField>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisCriterion>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestinationPatch>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhookPayload>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisDataField>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisCriterion>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestination>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhook>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookArgumentPayload>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookHeaderPayload>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookMockResponsePayload>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>, object>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>, object>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.SampleEntity>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string, object>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageUsage>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ItemsItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionRecordingTrackEntity>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicKnowledgeSourceSummary>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ASRSegment>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelEntity>? ListType45 { get; set; }
    }
}