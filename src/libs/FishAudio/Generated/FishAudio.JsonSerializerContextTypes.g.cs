
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
        public global::FishAudio.AgentBackgroundSoundPayload? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundPayloadPreset? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuardPatch? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatch? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatchTerminator? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOptionPatch? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuPatch? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOptionPatch>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundPatch? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatch? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatchAction? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatch? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchMode? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatch? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatchAction? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisCriterion? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataField? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataFieldType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisPatch? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatch? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatchModel? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigPatchPayload? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatch? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatch? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatch? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsPatch? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksPatch? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBasePatch? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentGuardrailsPatch? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentContextPatch? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatch? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatch? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchEagerness? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchHangupFarewellMode? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentCreatePayload? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMCustomConfig? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallback? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackMode? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentLLMFallbackModel>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModel? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModelModel? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatchModel? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatch? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatchOnMissing? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchTtsModel? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchEffect? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhookPayload? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhookPayload? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayload? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfig? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataField? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisCriterion? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataFieldType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfigLanguage? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundConfigPreset? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentContextConfig? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigEagerness? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigHangupFarewellMode? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestination? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundConfig? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenu? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInput? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuard? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentGuardrailsConfig? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputTerminator? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOption>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOption? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedacted? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedactedModel? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomConfigRedacted? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedacted? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedacted? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedactedModel? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMParallel? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedactedMode? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelRedacted>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMTimeouts? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfig? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfig? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfigFirstMessageMode? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfig? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationMode? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationWarmConnect? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailure? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationAnnouncementMode? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailureAction? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfig? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfigOnMissing? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfig? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfigModel? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBaseConfig? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsConfig? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfig? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigTtsModel? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigEffect? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksConfig? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhook? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhook? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigEntity? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVersionSummary? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResult? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultKind? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultToolType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResult? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResultResult? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGap? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapToolType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapSource? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationResult? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessage? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecord? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmEndpointError>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecordMockSource? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessageRole? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRun? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTestType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunStatus? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunUsage? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunChannel? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunEndedBy? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMCharge? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMChargeParticipant? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTokenCharge? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunPlatformFee? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunLLMCharge>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestTool? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestToolType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummary? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryStatus? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryTriggerSource? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicKnowledgeSourceSummary? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicDependentAgent? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummary? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryToolType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryMethod? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookArgumentPayload? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayload? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayloadKind? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookMockResponsePayload? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayload? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadParameterMode? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookToolSigningStatus? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeader? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeaderKind? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayload? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadParameterMode? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadMethod? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummary? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummaryTestType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayload? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayloadRole? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcher? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcherType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedTool? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedToolType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertions? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallAssertion? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertionsEndedBy? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfig? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSuccessCondition? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocks? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfigChannel? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationContext? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMock? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksStrategy? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksFallback? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameter? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameterType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayload? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayloadTestType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessage? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessageRole? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayload? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayloadTestType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummary? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryTestType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryStatus? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntity? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityProvider? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityTransferCallerId? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberPurchasePayload? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayload? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayload? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PhoneCallCreatePayload? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundEntity? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ASRSegment? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1Entity? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryCreatePayload? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryUpdatePayload? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1VersionEntity? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryItemPayload? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryItemPayloadType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryVersionCreatePayload? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1Item? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1ItemType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRow? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowStatus? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowBaseType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryInline? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItem? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryRef? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItemType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ProsodyControl? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ReferenceAudio? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestFormat? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestLatency? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequest? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestFormat? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestLatency? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampAlignment? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampSegment? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEventReason? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFlushEvent? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStartEvent? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStopEvent? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveTextEvent? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignCandidate? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AuthorEntity? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelAudioQualityEntity? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntity? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityType? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTrainMode? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityState? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.SampleEntity? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityVisibility? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTakedownCategory? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityPvcReleaseState? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelQualityEntity? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest2? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest2? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility2? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest3? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility3? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest4? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility4? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility2? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest3? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility3? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest4? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility4? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsPublicationState? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsTestType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsStatus? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsTestType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrModel? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampModel? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampModel? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelVisibility? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelSortBy? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse2? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse3? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse3? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse4? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse2? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse3? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse4? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse5? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse6? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse7? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse8? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse9? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse10? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse5? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseStatus? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseEndReason? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseSource? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDirection? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDialStatus? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseAnsweredBy? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ItemsItem? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminator? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmFallback>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse6? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse7? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse8? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse9? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponseStatus? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferRecordingEntity>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse2? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse3? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse4? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse5? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse6? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse2? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse3? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse4? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse2? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse3? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse4? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseStatus? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponsePublicationState? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse2? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse3? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse4? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse5? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse5? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseStatus? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponsePublicationState? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse6? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse7? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse8? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseStatus? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponsePublicationState? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse2? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse3? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse4? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse5? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse2? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse2? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse3? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse2? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse3? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse4? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse2? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse3? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse4? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse5? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse6? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse7? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse2? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse3? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse4? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse5? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse6? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse2? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse3? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse4? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse5? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse6? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse7? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse8? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse9? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse2? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse3? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse4? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse2? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse3? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse4? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponseStatus? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse2? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse3? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse4? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse5? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse6? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse7? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse8? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestTool>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse2? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse3? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse4? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestBatchSummary>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse2? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse3? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse4? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse5? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse6? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponseStatus? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse7? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse8? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse9? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse2? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse3? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse4? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse5? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse3? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse4? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse2? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse3? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse4? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse5? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse6? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse5? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse6? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse7? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse8? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse2? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse3? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse4? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse5? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse6? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse3? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse4? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse3? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse4? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse5? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseToolType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseMethod? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseParameterMode? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseErrorHandling? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse2? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse3? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse4? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse6? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseToolType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseMethod? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseParameterMode? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseErrorHandling? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseExecutionMode? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse7? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse8? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse9? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseToolType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseMethod? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseParameterMode? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseErrorHandling? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseExecutionMode? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse2? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse3? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse4? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse5? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse6? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse2? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse3? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse4? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse2? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse3? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse4? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestSummary>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse2? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse3? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse4? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse5? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponseTestType? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse2? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse3? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse4? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse5? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse6? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponseTestType? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse7? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse8? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse9? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponseTestType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse2? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse3? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse4? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse5? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse2? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse3? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunSummary>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse2? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse3? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse4? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse5? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse6? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseTestType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseStatus? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseChannel? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseEndedBy? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse7? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse8? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse9? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse2? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse3? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse4? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse5? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseProvider? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseTransferCallerId? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseStatus? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse2? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse3? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse4? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse5? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse6? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse7? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse8? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse9? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse6? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseProvider? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseTransferCallerId? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseStatus? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse7? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse8? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse9? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseProvider? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseTransferCallerId? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseStatus? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse2? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse3? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse4? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse5? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse6? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse2? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse3? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse3? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse4? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse5? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse6? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse7? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse8? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse9? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse10? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentBackgroundSoundEntity>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse2? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse3? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse2? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse3? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse4? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse5? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse2? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse3? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse2? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse3? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse4? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Entity>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse2? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse3? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse4? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse5? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse6? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse2? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse3? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse4? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse5? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse7? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse8? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse9? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse10? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse11? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse2? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse3? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse4? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse5? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse6? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse7? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse2? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse3? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse4? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1VersionEntity>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse2? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse3? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse4? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse5? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse6? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse7? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Item>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse2? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse3? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse4? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse5? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse6? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse7? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse8? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse9? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse10? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse11? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse12? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse2? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse3? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse4? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse5? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1CompareRow>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse2? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse3? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse4? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse5? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse6? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse2? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse3? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse2? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse3? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse4? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse2? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse3? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse4? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse2? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse3? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse4? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseType? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTrainMode? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseState? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseVisibility? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTakedownCategory? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponsePvcReleaseState? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse2? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse3? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse2? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseType? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTrainMode? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseState? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseVisibility? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTakedownCategory? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponsePvcReleaseState? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse3? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse4? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse2? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse2? Type862 { get; set; }

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
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryItemPayload>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.SampleEntity>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageUsage>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ItemsItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionLlmFallback>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionTransferRecordingEntity>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRun>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestTool>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestBatchSummary>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicKnowledgeSourceSummary>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestSummary>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestMessage>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRunSummary>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentBackgroundSoundEntity>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ASRSegment>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1Entity>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1VersionEntity>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1Item>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1CompareRow>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelEntity>? ListType81 { get; set; }
    }
}