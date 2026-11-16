
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
        public global::FishAudio.RevokeCredentials? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type1 { get; set; }
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
        public global::FishAudio.AgentSessionKeypadMenu? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionKeypadMenuOutcome? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionKeypadMenuInput? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummary? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryStatus? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryEndReason? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummarySource? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDirection? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDialStatus? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryAnsweredBy? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.JsonValue? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomPayload? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelPayload? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelPayloadModel? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMParallelPayload? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackPayload? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackPayloadMode? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelPayload>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMTimeoutsPayload? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAsrOverridesPayload? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAsrOverridesPayloadModel? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionContextPayload? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionCreatePayload? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayload? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, int?, double?, bool?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmOverridesPayload? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayloadLanguage? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResult? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResultResult? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValue? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValueType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<bool?, double?, string>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResult? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResultStatus? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmCustomRef? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointError? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointErrorType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmEndpointErrorReason? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmFallback? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmModelRef? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionLlmFallbackReason? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItem? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItemRole? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolCallItem? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolErrorDetail? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItem? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItemStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItem? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemDestinationType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemMode? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemWarmConnect? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemOutcome? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemDialStatus? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemConsultEndReason? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferItemTransferredCallEndReason? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferMessage>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferMessage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferMessageRole? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCost? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCostCategory? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageStatus? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageBillingMode? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntity? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityRole? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityStatus? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferRecordingEntity? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionTransferRecordingEntityStatus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntity? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityPublicationState? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityOverridesAllowedItem? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundPayload? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundPayloadPreset? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuardPatch? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatch? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputPatchTerminator? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOptionPatch? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuPatch? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOptionPatch>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundPatch? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatch? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatchAction? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatch? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchMode? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatch? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatchAction? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisCriterion? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataField? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataFieldType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisPatch? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatch? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatchModel? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigPatchPayload? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatch? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatch? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatch? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsPatch? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksPatch? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBasePatch? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentGuardrailsPatch? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentContextPatch? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatch? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatch? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchEagerness? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchHangupFarewellMode? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentCreatePayload? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMCustomConfig? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallback? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackMode? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentLLMFallbackModel>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModel? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMFallbackModelModel? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatchModel? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatch? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatchOnMissing? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchTtsModel? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchEngine? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchEffect? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhookPayload? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhookPayload? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayload? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisConfig? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfig? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataField? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisCriterion? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataFieldType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfigLanguage? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundConfigPreset? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentContextConfig? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfig? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigEagerness? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigHangupFarewellMode? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestination? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenu? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInput? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentEchoGuard? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentGuardrailsConfig? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadInputTerminator? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentKeypadMenuOption>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentKeypadMenuOption? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedacted? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedactedModel? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomConfigRedacted? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedacted? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedacted? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackModelRedactedModel? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMParallel? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMFallbackRedactedMode? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentLLMFallbackModelRedacted>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMTimeouts? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfig? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfig? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfigFirstMessageMode? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfig? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationMode? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationWarmConnect? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailure? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationAnnouncementMode? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailureAction? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfig? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfigOnMissing? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfig? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrConfigModel? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBaseConfig? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsConfig? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfig? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigTtsModel? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigEngine? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoiceConfigEffect? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksConfig? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhook? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhook? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigEntity? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVersionSummary? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResult? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultKind? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultToolType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResult? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResultResult? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGap? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapToolType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapSource? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationResult? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessage? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecord? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmEndpointError>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecordMockSource? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessageRole? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRun? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTestType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunUsage? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunChannel? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunEndedBy? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMCharge? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunLLMChargeParticipant? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTokenCharge? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunPlatformFee? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunLLMCharge>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestTool? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestToolType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummary? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryStatus? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryTriggerSource? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicKnowledgeSourceSummary? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicDependentAgent? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummary? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryToolType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryMethod? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentToolPreToolSpeech? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentToolPreToolSpeechMode? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookArgumentPayload? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayload? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayloadKind? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookMockResponsePayload? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayload? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadParameterMode? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookToolSigningStatus? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeader? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeaderKind? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayload? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadParameterMode? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadMethod? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummary? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummaryTestType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayload? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayloadRole? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcher? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcherType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedTool? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedToolType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertions? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallAssertion? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertionsEndedBy? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfig? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSuccessCondition? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocks? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfigChannel? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationContext? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMock? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksStrategy? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksFallback? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameter? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameterType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayload? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayloadTestType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessage? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessageRole? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayload? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayloadTestType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummary? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryTestType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryStatus? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntity? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityProvider? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityTransferCallerId? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityStatus? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberPurchasePayload? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayload? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayload? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PhoneCallCreatePayload? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentBackgroundSoundEntity? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ASRSegment? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1Entity? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryCreatePayload? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryUpdatePayload? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1VersionEntity? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryItemPayload? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryItemPayloadType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryVersionCreatePayload? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1Item? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1ItemType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRow? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowStatus? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryV1CompareRowBaseType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryInline? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItem? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryRef? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItemType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ProsodyControl? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ReferenceAudio? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequest? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestFormat? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestLatency? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequest? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestFormat? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestLatency? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampAlignment? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampSegment? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEventReason? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFlushEvent? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStartEvent? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStopEvent? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveTextEvent? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignCandidate? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AuthorEntity? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelAudioQualityEntity? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntity? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTrainMode? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityState? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.SampleEntity? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityVisibility? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTakedownCategory? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityPvcReleaseState? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelQualityEntity? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsRequest? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest2? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest2? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility2? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest3? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility3? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest4? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility4? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest2? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility2? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest3? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest4? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility4? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsPublicationState? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsTestType? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsStatus? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsTestType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrModel? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampModel? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampModel? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelVisibility? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelSortBy? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse3? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse2? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse3? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateKeyRevokeResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateKeyRevokeResponse2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse2? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse3? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse4? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse2? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse3? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse4? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse5? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse6? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse7? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse8? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse9? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse10? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse5? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseStatus? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseEndReason? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseSource? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDirection? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDialStatus? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseAnsweredBy? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ItemsItem? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminator? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionLlmFallback>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse6? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse7? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse8? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse9? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponseStatus? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionTransferRecordingEntity>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse2? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse3? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse4? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse5? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse6? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse3? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse4? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse2? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse3? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse4? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseStatus? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponsePublicationState? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse2? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse3? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse4? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse5? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse5? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseStatus? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponsePublicationState? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse6? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse7? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse8? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseStatus? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponsePublicationState? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse2? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse3? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse4? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse5? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse2? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse3? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse2? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse3? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse2? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse3? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse4? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse2? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse3? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse4? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse5? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse6? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse7? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse2? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse3? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse4? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse5? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse6? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse2? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse3? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse4? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse5? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse6? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse7? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse8? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse9? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse3? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse4? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse2? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse3? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse4? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponseStatus? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse2? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse3? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse4? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse5? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse6? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse7? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse8? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestTool>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse2? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse3? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse4? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestBatchSummary>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse2? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse3? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse4? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse5? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse6? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponseStatus? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse7? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse8? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse9? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse2? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse3? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse4? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse5? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse3? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse4? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse3? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse4? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse5? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse6? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse5? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse6? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse7? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse8? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse3? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse4? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse5? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse6? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse2? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse3? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse4? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse2? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse3? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse4? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse5? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseToolType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseMethod? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseParameterMode? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseErrorHandling? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse2? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse3? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse4? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse6? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseToolType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseMethod? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseParameterMode? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseErrorHandling? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseExecutionMode? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse7? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse8? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse9? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseToolType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseMethod? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseParameterMode? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseErrorHandling? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseExecutionMode? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse2? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse3? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse4? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse5? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse6? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse2? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse3? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse4? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse2? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse3? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse4? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestSummary>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse2? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse3? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse4? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse5? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponseTestType? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse2? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse3? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse4? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse5? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse6? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponseTestType? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse7? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse8? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse9? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponseTestType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse2? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse3? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse4? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse5? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse2? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse3? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunSummary>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse3? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse4? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse5? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse6? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseTestType? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseStatus? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseChannel? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseEndedBy? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse7? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse8? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse9? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse2? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse3? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse4? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse5? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseProvider? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseTransferCallerId? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseStatus? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse2? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse3? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse4? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse5? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse6? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse7? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse8? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse9? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse6? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseProvider? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseTransferCallerId? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseStatus? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse7? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse8? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse9? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseProvider? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseTransferCallerId? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseStatus? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse2? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse3? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse4? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse5? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse6? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse2? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse3? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse4? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse2? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse3? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse4? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse5? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse6? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse7? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse8? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse9? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse10? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentBackgroundSoundEntity>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentBackgroundSoundsResponse3? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse2? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse3? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse4? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentBackgroundSoundsResponse5? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse2? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentBackgroundSoundsResponse3? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse2? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse3? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse4? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Entity>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse2? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse3? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse4? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse5? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse6? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse2? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse3? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse4? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesResponse5? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse7? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse8? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse9? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse10? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesResponse11? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse2? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse3? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse4? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse5? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse6? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchPronunciationDictionariesResponse7? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse2? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse3? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesResponse4? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1VersionEntity>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse2? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse3? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse4? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse5? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse6? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse7? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Item>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse2? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse3? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse4? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse5? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse6? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreatePronunciationDictionariesVersionsResponse7? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse8? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse9? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse10? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse11? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsResponse12? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse2? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse3? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse4? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeletePronunciationDictionariesVersionsResponse5? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1CompareRow>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse2? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse3? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse4? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse5? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse6? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse2? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse3? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse2? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse3? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse4? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse2? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse3? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse4? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse2? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse3? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse4? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseType? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTrainMode? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseState? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseVisibility? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTakedownCategory? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponsePvcReleaseState? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse2? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse3? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse2? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseType? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTrainMode? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseState? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseVisibility? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTakedownCategory? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponsePvcReleaseState? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse3? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse4? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse2? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse2? Type871 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentLLMFallbackModelPayload>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisDataValue>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisCriterionResult>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionTransferMessage>? ListType4 { get; set; }
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