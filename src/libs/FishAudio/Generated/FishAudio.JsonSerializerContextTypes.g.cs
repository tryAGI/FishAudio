
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionKeypadMenu? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionKeypadMenuOutcome? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionKeypadMenuInput? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummary? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryStatus? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryEndReason? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummarySource? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDirection? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDialStatus? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryAnsweredBy? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.JsonValue? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomPayload? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelPayload? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelPayloadModel? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMParallelPayload? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackPayload? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackPayloadMode? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelPayload>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMTimeoutsPayload? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAsrOverridesPayload? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAsrOverridesPayloadModel? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionContextPayload? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionCreatePayload? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayload? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, int?, double?, bool?>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmOverridesPayload? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayloadLanguage? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResult? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResultResult? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValue? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValueType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<bool?, double?, string>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResult? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResultStatus? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmCustomRef? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointError? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointErrorType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointErrorReason? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmFallback? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmModelRef? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmFallbackReason? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItem? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsage? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItemRole? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolCallItem? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItem? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItemStatus? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItem? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemDestinationType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemMode? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemWarmConnect? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemOutcome? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemDialStatus? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemConsultEndReason? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemTransferredCallEndReason? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferMessage>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferMessage? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferMessageRole? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCost? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCostCategory? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageStatus? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageBillingMode? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntity? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityRole? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityStatus? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferRecordingEntity? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferRecordingEntityStatus? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntity? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityStatus? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityPublicationState? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityOverridesAllowedItem? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuardPatch? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatch? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatchTerminator? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOptionPatch? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuPatch? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOptionPatch>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundPatch? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatch? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatchAction? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatch? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchMode? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatch? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatchAction? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisCriterion? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataField? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataFieldType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisPatch? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatch? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatchModel? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigPatchPayload? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatch? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatch? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatch? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsPatch? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksPatch? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBasePatch? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentGuardrailsPatch? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentContextPatch? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatch? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatch? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchEagerness? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchHangupFarewellMode? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentCreatePayload? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMCustomConfig? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallback? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackMode? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentLLMFallbackModel>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModel? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModelModel? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatchModel? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatch? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatchOnMissing? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchTtsModel? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhookPayload? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhookPayload? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayload? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisConfig? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfig? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataField? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisCriterion? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataFieldType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfigLanguage? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentContextConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfig? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigEagerness? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigHangupFarewellMode? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestination? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundConfig? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenu? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInput? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuard? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentGuardrailsConfig? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputTerminator? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOption>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOption? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedacted? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedactedModel? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomConfigRedacted? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedacted? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedacted? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedactedModel? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMParallel? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedactedMode? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelRedacted>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMTimeouts? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfig? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfig? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfigFirstMessageMode? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfig? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationMode? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationWarmConnect? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailure? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationAnnouncementMode? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailureAction? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfig? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfigOnMissing? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfig? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfigModel? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBaseConfig? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsConfig? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfig? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigTtsModel? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksConfig? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhook? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhook? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigEntity? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVersionSummary? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResult? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultKind? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultToolType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResult? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResultResult? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGap? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapToolType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapSource? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationResult? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessage? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecord? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmEndpointError>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecordMockSource? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessageRole? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRun? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTestType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunStatus? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunUsage? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunChannel? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunEndedBy? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMCharge? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMChargeParticipant? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTokenCharge? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunPlatformFee? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunLLMCharge>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestTool? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestToolType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummary? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryStatus? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryTriggerSource? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicKnowledgeSourceSummary? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicDependentAgent? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummary? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryToolType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryMethod? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookArgumentPayload? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayload? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayloadKind? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookMockResponsePayload? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayload? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadParameterMode? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeader? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeaderKind? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayload? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadParameterMode? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadMethod? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummary? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummaryTestType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayload? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayloadRole? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcher? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcherType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedTool? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedToolType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertions? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallAssertion? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertionsEndedBy? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfig? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSuccessCondition? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocks? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfigChannel? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationContext? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMock? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksStrategy? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksFallback? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameter? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameterType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayload? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayloadTestType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessage? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessageRole? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayload? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayloadTestType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummary? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryTestType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryStatus? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntity? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityProvider? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityTransferCallerId? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityStatus? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberPurchasePayload? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayload? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayload? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PhoneCallCreatePayload? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ASRSegment? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryInline? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItem? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryRef? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItemType? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ProsodyControl? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ReferenceAudio? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestFormat? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestLatency? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestFormat? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestLatency? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampAlignment? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampSegment? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEventReason? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFlushEvent? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStartEvent? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStopEvent? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveTextEvent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignRequest? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignCandidate? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AuthorEntity? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelAudioQualityEntity? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntity? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTrainMode? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityState? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.SampleEntity? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityVisibility? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTakedownCategory? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityPvcReleaseState? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelQualityEntity? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishRequest? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest2? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest3? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility3? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest4? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility4? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest2? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility2? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest3? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility3? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest4? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility4? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsPublicationState? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsTestType? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsTestType? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrModel? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsModel? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampModel? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampModel? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelVisibility? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelSortBy? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse2? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse3? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse2? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse3? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse2? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse3? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse4? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse2? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse3? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse4? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse5? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse6? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse7? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse8? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse9? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse10? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse5? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseStatus? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseEndReason? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseSource? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDirection? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDialStatus? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseAnsweredBy? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ItemsItem? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminator? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmFallback>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse6? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse7? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse8? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse9? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponseStatus? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferRecordingEntity>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse2? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse3? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse4? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse5? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse6? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse3? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse4? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse2? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse3? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse4? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseStatus? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponsePublicationState? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse2? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse3? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse4? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse5? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse5? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseStatus? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponsePublicationState? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse6? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse7? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse8? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseStatus? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponsePublicationState? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse2? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse3? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse4? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse5? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse2? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse3? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse2? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse3? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse2? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse3? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse4? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse2? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse4? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse5? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse6? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse7? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse2? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse3? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse4? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse5? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse6? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse2? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse3? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse4? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse5? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse6? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse7? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse8? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse9? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse2? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse3? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse4? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse2? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse3? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse4? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponseStatus? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse2? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse3? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse4? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse5? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse6? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse7? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse8? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestTool>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse2? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse3? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse4? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestBatchSummary>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse2? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse3? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse4? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse5? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse6? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponseStatus? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse7? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse8? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse9? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse2? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse3? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse4? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse5? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse2? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse3? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse4? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse2? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse3? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse4? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse5? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse6? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse5? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse6? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse7? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse8? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse2? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse3? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse4? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse5? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse6? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse2? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse3? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse4? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse2? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse3? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse4? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse5? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseToolType? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseMethod? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseParameterMode? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseErrorHandling? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse2? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse3? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse4? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse6? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseToolType? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseMethod? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseParameterMode? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseErrorHandling? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseExecutionMode? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse7? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse8? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse9? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseToolType? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseMethod? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseParameterMode? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseErrorHandling? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseExecutionMode? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse3? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse4? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse5? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse6? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse3? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse4? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse2? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse3? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse4? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestSummary>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse2? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse3? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse4? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse5? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponseTestType? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse3? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse4? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse5? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse6? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponseTestType? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse7? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse8? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse9? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponseTestType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse2? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse3? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse4? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse5? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse2? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse3? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunSummary>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse2? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse3? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse4? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse5? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse6? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseTestType? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseStatus? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseChannel? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseEndedBy? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse7? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse8? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse9? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse2? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse3? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse4? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse5? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseProvider? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseTransferCallerId? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseStatus? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse2? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse3? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse4? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse5? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse6? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse7? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse8? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse9? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse6? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseProvider? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseTransferCallerId? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseStatus? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse7? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse8? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse9? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseProvider? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseTransferCallerId? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseStatus? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse3? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse4? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse5? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse6? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse2? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse3? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse3? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse4? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse5? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse6? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse7? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse8? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse9? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse10? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse2? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse3? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse4? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse2? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse3? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse2? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse3? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse4? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse2? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse3? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse4? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse2? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse3? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse4? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseType? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTrainMode? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseState? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseVisibility? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTakedownCategory? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponsePvcReleaseState? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse2? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse3? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseType? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTrainMode? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseState? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseVisibility? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTakedownCategory? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponsePvcReleaseState? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse3? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse4? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse2? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse2? Type766 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentLLMFallbackModelPayload>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisDataValue>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisCriterionResult>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionTransferMessage>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageTokenCost>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionRecordingTrackEntity>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentKeypadMenuOptionPatch>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisDataField>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisCriterion>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestinationPatch>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentLLMFallbackModel>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhookPayload>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisDataField>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisCriterion>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestination>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentKeypadMenuOption>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentLLMFallbackModelRedacted>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhook>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestTranscriptMessage>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallRecord>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestAssertionResult>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestConditionResult>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionLlmEndpointError>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestMockGap>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRunLLMCharge>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookArgumentPayload>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookHeaderPayload>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookMockResponsePayload>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallAssertion>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestReferencedTool>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestSuccessCondition>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolMock>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestMessagePayload>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolParameter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.SampleEntity>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageUsage>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ItemsItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionLlmFallback>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionTransferRecordingEntity>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRun>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestTool>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestBatchSummary>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicKnowledgeSourceSummary>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestSummary>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestMessage>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRunSummary>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ASRSegment>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelEntity>? ListType75 { get; set; }
    }
}