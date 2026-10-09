
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
        public global::FishAudio.AgentSessionSummaryEndReason? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummarySource? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDirection? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryDialStatus? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionSummaryAnsweredBy? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.JsonValue? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionCreatePayload? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayload? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, int?, double?, bool?>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionOverridesPayloadLanguage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResult? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisCriterionResultResult? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValue? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisDataValueType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<bool?, double?, string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResult? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionAnalysisResultStatus? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItem? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsage? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionMessageItemRole? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolCallItem? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItem? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionToolResultItemStatus? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCost? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageTokenCostCategory? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageStatus? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.LLMMessageUsageBillingMode? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntity? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityRole? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSessionRecordingTrackEntityStatus? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntity? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityStatus? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityPublicationState? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentEntityOverridesAllowedItem? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundPatch? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatch? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailPatchAction? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatch? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchMode? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchWarmConnect? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatch? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationPatchAnnouncementMode? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailurePatchAction? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisCriterion? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataField? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisDataFieldType? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisPatch? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatch? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatch? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentAsrPatchModel? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigPatchPayload? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatch? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatch? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatch? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsPatch? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksPatch? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBasePatch? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentGuardrailsPatch? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatch? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatch? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchEagerness? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentCreatePayload? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMCustomConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentLLMPatchModel? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentPromptPatchFirstMessageMode? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatch? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVariablesPatchOnMissing? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhookPayload? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhookPayload? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayload? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadStatus? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfig? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataField? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisCriterion? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisDataFieldType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAnalysisSummaryConfigLanguage? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAsrConfig? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentAsrConfigModel? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfig? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigEagerness? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentConversationConfigInterruptionSensitivity? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestination? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundConfig? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentGuardrailsConfig? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedacted? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMConfigRedactedModel? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentLLMCustomConfigRedacted? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentOutboundVoicemailConfigAction? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfig? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentPromptConfigFirstMessageMode? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfig? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentSystemToolsConfigHangUpCallFarewellMode? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationMode? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationWarmConnect? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailure? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferDestinationAnnouncementMode? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTransferOnFailureAction? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfig? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVariablesConfigOnMissing? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVoiceConfigView? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentVoiceConfigViewSpeakingLanguage? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentKnowledgeBaseConfig? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolsConfig? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentWebhooksConfig? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicConversationInitWebhook? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPostCallWebhook? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentVersionSummary? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentConfigEntity? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResult? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultKind? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestAssertionResultToolType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResult? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestConditionResultResult? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGap? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapToolType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMockGapSource? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationResult? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessage? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecord? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallRecordMockSource? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestTranscriptMessageRole? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRun? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunTestType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunStatus? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunUsage? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunChannel? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunEndedBy? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestTool? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestToolType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummary? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryStatus? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestBatchSummaryTriggerSource? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicKnowledgeSourceSummary? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicDependentAgent? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummary? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryToolType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolSummaryMethod? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookArgumentPayload? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayload? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookHeaderPayloadKind? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentWebhookMockResponsePayload? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayload? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeader? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicToolHeaderKind? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayload? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadMethod? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummary? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestSummaryTestType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayload? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestMessagePayloadRole? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcher? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestParamMatcherType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedTool? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestReferencedToolType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertions? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolCallAssertion? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationAssertionsEndedBy? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfig? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSuccessCondition? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocks? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestSimulationConfigChannel? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMock? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksStrategy? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolMocksFallback? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameter? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AgentTestToolParameterType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayload? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestCreatePayloadTestType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestMessageRole? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayload? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestUpdatePayloadTestType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummary? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryTestType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicAgentTestRunSummaryStatus? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntity? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityProvider? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityTransferCallerId? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberEntityStatus? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberPurchasePayload? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayload? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicSipNumberImportPayloadTerminationTransport? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayload? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PublicPhoneNumberUpdatePayloadTransferCallerId? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PhoneCallCreatePayload? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ASRSegment? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryInline? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationItem? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PronunciationDictionaryRef? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ProsodyControl? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ReferenceAudio? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestFormat? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSRequestLatency? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestFormat? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSStreamWithTimestampRequestLatency? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampAlignment? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSTimestampSegment? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveErrorEvent? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEvent? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFinishEventReason? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveWithTimestampAudioEvent? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveFlushEvent? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStartEvent? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveStopEvent? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.TTSLiveTextEvent? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.VoiceDesignCandidate? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AuthorEntity? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelAudioQualityEntity? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntity? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTrainMode? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityState? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.SampleEntity? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityVisibility? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityTakedownCategory? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelEntityPvcReleaseState? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ModelQualityEntity? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrRequest2? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest2? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility2? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest3? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility3? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequest4? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelRequestVisibility4? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility2? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest3? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility3? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequest4? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelRequestVisibility4? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsPublicationState? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersNumberType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsTestType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsStatus? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsTestType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrModel? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsModel? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampModel? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampModel? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelSortBy? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletPackageResponse3? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse2? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetWalletApiCreditResponse3? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse2? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse3? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse4? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse2? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse3? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse4? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse5? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse6? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse7? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse8? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse9? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsResponse10? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse5? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseStatus? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseEndReason? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseSource? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDirection? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseDialStatus? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseAnsweredBy? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.ItemsItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminator? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse6? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse7? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse8? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsResponse9? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponseStatus? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse2? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse3? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse4? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse5? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentSessionsRecordingResponse6? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse3? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentSessionsEndResponse4? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse3? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse4? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseStatus? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponsePublicationState? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse2? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse3? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse4? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsResponse5? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse5? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseStatus? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponsePublicationState? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse6? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse7? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsResponse8? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseStatus? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponsePublicationState? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse2? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse3? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse4? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsResponse5? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse2? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsResponse3? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse2? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsWidgetResponse3? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse3? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsConfigResponse4? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse4? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse5? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentAgentsConfigResponse6? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse2? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse3? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse4? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse5? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsPublishResponse6? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse3? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse4? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse5? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse6? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse7? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse8? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsVersionsResponse9? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse3? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PutAgentAgentsTestsResponse4? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse2? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse3? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentAgentsTestsResponse4? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponseStatus? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse2? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse3? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse4? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse5? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentAgentsTestsRunResponse6? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestTool>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse3? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestToolsResponse4? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestBatchSummary>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse3? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse4? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse5? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse6? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponseStatus? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse7? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse8? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAgentsTestBatchesResponse9? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse2? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse3? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse4? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentAvailablePhoneNumbersResponse5? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse2? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse3? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse4? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse2? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse3? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse4? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse5? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentKnowledgeSourcesResponse6? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse5? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse6? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse7? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesResponse8? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse2? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse3? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse4? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse5? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentKnowledgeSourcesResponse6? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse2? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse3? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentKnowledgeSourcesResponse4? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse2? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse3? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse4? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse5? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseToolType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseMethod? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseErrorHandling? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse2? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse3? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentToolsResponse4? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse6? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseToolType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseMethod? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseErrorHandling? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponseExecutionMode? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse7? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse8? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsResponse9? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseToolType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseMethod? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseErrorHandling? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponseExecutionMode? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse2? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse3? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse4? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse5? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentToolsResponse6? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse2? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse3? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentToolsResponse4? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse2? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse3? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentToolsAgentsResponse4? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestSummary>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse3? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse4? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse5? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponseTestType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse2? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse3? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse4? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentTestsResponse5? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse6? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponseTestType? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse7? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse8? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestsResponse9? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponseTestType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse2? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse3? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse4? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentTestsResponse5? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentTestsResponse3? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunSummary>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse2? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse3? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse4? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse5? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse6? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseTestType? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseStatus? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseChannel? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponseEndedBy? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse7? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse8? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentTestRunsResponse9? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse3? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse4? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse5? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseProvider? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseTransferCallerId? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponseStatus? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse2? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse3? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse4? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse5? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse6? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse7? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse8? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneNumbersResponse9? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse6? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseProvider? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseTransferCallerId? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponseStatus? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse7? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse8? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetAgentPhoneNumbersResponse9? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseProvider? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseTransferCallerId? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponseStatus? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse2? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse3? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse4? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse5? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchAgentPhoneNumbersResponse6? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse2? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteAgentPhoneNumbersResponse3? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse2? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse3? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse4? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse5? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse6? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse7? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse8? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse9? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAgentPhoneCallsResponse10? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse3? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateAsrResponse4? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse2? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsResponse3? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse2? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse3? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateTtsStreamWithTimestampResponse4? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse2? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse3? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetTtsLiveWithTimestampResponse4? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse2? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse3? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateVoiceDesignResponse4? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTrainMode? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseState? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseVisibility? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponseTakedownCategory? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponsePvcReleaseState? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse2? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.CreateModelResponse3? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse2? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTrainMode? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseState? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseVisibility? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponseTakedownCategory? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponsePvcReleaseState? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse3? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.GetModelResponse4? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.PatchModelResponse2? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.DeleteModelResponse2? Type682 { get; set; }

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
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestTranscriptMessage>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallRecord>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestAssertionResult>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestConditionResult>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestMockGap>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookArgumentPayload>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookHeaderPayload>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentWebhookMockResponsePayload>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallAssertion>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestReferencedTool>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestSuccessCondition>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolMock>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestMessagePayload>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentTestToolParameter>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.SampleEntity>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.LLMMessageUsage>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ItemsItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.AgentSessionRecordingTrackEntity>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRun>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestTool>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestBatchSummary>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicKnowledgeSourceSummary>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestSummary>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestMessage>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRunSummary>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ASRSegment>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::FishAudio.ModelEntity>? ListType65 { get; set; }
    }
}