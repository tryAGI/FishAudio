
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryStatus), TypeInfoPropertyName = "AgentSessionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummarySource), TypeInfoPropertyName = "AgentSessionSummarySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDirection), TypeInfoPropertyName = "AgentSessionSummaryDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDialStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryAnsweredBy2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionOverridesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisCriterionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult), TypeInfoPropertyName = "AgentSessionAnalysisCriterionResultResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisDataValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisDataValueType), TypeInfoPropertyName = "AgentSessionAnalysisDataValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<bool?, double?, string, object>), TypeInfoPropertyName = "AnyOfBooleanDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisResultStatus), TypeInfoPropertyName = "AgentSessionAnalysisResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisDataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentSessionAnalysisCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionMessageItemRole), TypeInfoPropertyName = "AgentSessionMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItemStatus), TypeInfoPropertyName = "AgentSessionToolResultItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole), TypeInfoPropertyName = "AgentSessionRecordingTrackEntityRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus), TypeInfoPropertyName = "AgentSessionRecordingTrackEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityStatus), TypeInfoPropertyName = "PublicAgentEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityPublicationState), TypeInfoPropertyName = "PublicAgentEntityPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem), TypeInfoPropertyName = "PublicAgentEntityOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatchAction), TypeInfoPropertyName = "AgentOutboundVoicemailPatchAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchMode), TypeInfoPropertyName = "AgentTransferDestinationPatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect), TypeInfoPropertyName = "AgentTransferDestinationPatchWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisDataField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisDataFieldType), TypeInfoPropertyName = "PublicAgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisSummaryPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisDataField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentAnalysisCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage), TypeInfoPropertyName = "PublicAgentAnalysisSummaryPatchLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConfigPatchPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentPromptPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVoicePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentWebhooksPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentKnowledgeBasePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentGuardrailsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchEagerness2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMCustomConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMPatchModel2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSystemToolsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicConversationInitWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPostCallWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item), TypeInfoPropertyName = "PublicAgentUpdatePayloadOverridesAllowedVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisSummaryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisDataField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisDataField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentAnalysisCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisDataFieldType), TypeInfoPropertyName = "AgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage), TypeInfoPropertyName = "AgentAnalysisSummaryConfigLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigEagerness), TypeInfoPropertyName = "AgentConversationConfigEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity), TypeInfoPropertyName = "AgentConversationConfigInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentGuardrailsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentLLMConfigRedacted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentLLMConfigRedactedModel), TypeInfoPropertyName = "AgentLLMConfigRedactedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentLLMCustomConfigRedacted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailConfigAction), TypeInfoPropertyName = "AgentOutboundVoicemailConfigAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentPromptConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentPromptConfigFirstMessageMode), TypeInfoPropertyName = "AgentPromptConfigFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSystemToolsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationMode), TypeInfoPropertyName = "AgentTransferDestinationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationWarmConnect), TypeInfoPropertyName = "AgentTransferDestinationWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage), TypeInfoPropertyName = "AgentVoiceConfigSpeakingLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentKnowledgeBaseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentWebhooksConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicConversationInitWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPostCallWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVersionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConfigEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicKnowledgeSourceSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicDependentAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryToolType), TypeInfoPropertyName = "PublicAgentToolSummaryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryMethod), TypeInfoPropertyName = "PublicAgentToolSummaryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookArgumentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookHeaderPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookHeaderPayloadKind), TypeInfoPropertyName = "AgentWebhookHeaderPayloadKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookMockResponsePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType), TypeInfoPropertyName = "PublicAgentToolCreatePayloadToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod), TypeInfoPropertyName = "PublicAgentToolCreatePayloadMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling), TypeInfoPropertyName = "PublicAgentToolCreatePayloadErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode), TypeInfoPropertyName = "PublicAgentToolCreatePayloadExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicToolHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicToolHeaderKind), TypeInfoPropertyName = "PublicToolHeaderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityProvider), TypeInfoPropertyName = "PublicPhoneNumberEntityProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityStatus), TypeInfoPropertyName = "PublicPhoneNumberEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberPurchasePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport), TypeInfoPropertyName = "PublicSipNumberImportPayloadTerminationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PhoneCallCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ASRSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ProsodyControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ReferenceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>), TypeInfoPropertyName = "AnyOfIListReferenceAudioIListIListReferenceAudioObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestFormat), TypeInfoPropertyName = "TTSRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestLatency), TypeInfoPropertyName = "TTSRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat), TypeInfoPropertyName = "TTSStreamWithTimestampRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency), TypeInfoPropertyName = "TTSStreamWithTimestampRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSTimestampAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSTimestampSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.VoiceDesignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.VoiceDesignCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AuthorEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelAudioQualityEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityType), TypeInfoPropertyName = "ModelEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTrainMode), TypeInfoPropertyName = "ModelEntityTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityState), TypeInfoPropertyName = "ModelEntityState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.SampleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityVisibility), TypeInfoPropertyName = "ModelEntityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTakedownCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityPvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelQualityEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>), TypeInfoPropertyName = "AnyOfPublicPhoneNumberPurchasePayloadPublicSipNumberImportPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility), TypeInfoPropertyName = "CreateModelRequestVisibility2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>), TypeInfoPropertyName = "AnyOfIListByteArrayByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>), TypeInfoPropertyName = "AnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility2), TypeInfoPropertyName = "CreateModelRequestVisibility22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility3), TypeInfoPropertyName = "CreateModelRequestVisibility32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility4), TypeInfoPropertyName = "CreateModelRequestVisibility42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsPublicationState), TypeInfoPropertyName = "GetAgentAgentsPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType), TypeInfoPropertyName = "GetAgentAvailablePhoneNumbersNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsModel), TypeInfoPropertyName = "CreateTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampModel), TypeInfoPropertyName = "CreateTtsStreamWithTimestampModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelSortBy), TypeInfoPropertyName = "GetModelSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentSessionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseStatus), TypeInfoPropertyName = "GetAgentSessionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseSource), TypeInfoPropertyName = "GetAgentSessionsResponseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDirection), TypeInfoPropertyName = "GetAgentSessionsResponseDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDialStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ItemsItem), TypeInfoPropertyName = "ItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType), TypeInfoPropertyName = "GetAgentSessionsResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus), TypeInfoPropertyName = "GetAgentSessionsRecordingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentSessionRecordingTrackEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsEndResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsEndResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsEndResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentSessionsEndResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseStatus), TypeInfoPropertyName = "CreateAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState), TypeInfoPropertyName = "CreateAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem), TypeInfoPropertyName = "CreateAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseStatus), TypeInfoPropertyName = "GetAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponsePublicationState), TypeInfoPropertyName = "GetAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem), TypeInfoPropertyName = "GetAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseStatus), TypeInfoPropertyName = "PatchAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState), TypeInfoPropertyName = "PatchAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem), TypeInfoPropertyName = "PatchAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsWidgetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsWidgetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsWidgetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsConfigResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsVersionsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicKnowledgeSourceSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentKnowledgeSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentKnowledgeSourcesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentKnowledgeSourcesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentKnowledgeSourcesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentKnowledgeSourcesAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentToolSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseToolType), TypeInfoPropertyName = "CreateAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseMethod), TypeInfoPropertyName = "CreateAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling), TypeInfoPropertyName = "CreateAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode), TypeInfoPropertyName = "CreateAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseToolType), TypeInfoPropertyName = "GetAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseMethod), TypeInfoPropertyName = "GetAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseErrorHandling), TypeInfoPropertyName = "GetAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseExecutionMode), TypeInfoPropertyName = "GetAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseToolType), TypeInfoPropertyName = "PatchAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseMethod), TypeInfoPropertyName = "PatchAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling), TypeInfoPropertyName = "PatchAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode), TypeInfoPropertyName = "PatchAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsAgentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsAgentsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsAgentsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider), TypeInfoPropertyName = "CreateAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus), TypeInfoPropertyName = "CreateAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider), TypeInfoPropertyName = "GetAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus), TypeInfoPropertyName = "GetAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider), TypeInfoPropertyName = "PatchAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus), TypeInfoPropertyName = "PatchAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneCallsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseType), TypeInfoPropertyName = "CreateModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTrainMode), TypeInfoPropertyName = "CreateModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseState), TypeInfoPropertyName = "CreateModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseVisibility), TypeInfoPropertyName = "CreateModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTakedownCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponsePvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType), TypeInfoPropertyName = "GetModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode), TypeInfoPropertyName = "GetModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState), TypeInfoPropertyName = "GetModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility), TypeInfoPropertyName = "GetModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTakedownCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponsePvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryStatus?), TypeInfoPropertyName = "NullableAgentSessionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummarySource?), TypeInfoPropertyName = "NullableAgentSessionSummarySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDirection?), TypeInfoPropertyName = "NullableAgentSessionSummaryDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult?), TypeInfoPropertyName = "NullableAgentSessionAnalysisCriterionResultResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisDataValueType?), TypeInfoPropertyName = "NullableAgentSessionAnalysisDataValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<bool?, double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisResultStatus?), TypeInfoPropertyName = "NullableAgentSessionAnalysisResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionMessageItemRole?), TypeInfoPropertyName = "NullableAgentSessionMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItemStatus?), TypeInfoPropertyName = "NullableAgentSessionToolResultItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole?), TypeInfoPropertyName = "NullableAgentSessionRecordingTrackEntityRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus?), TypeInfoPropertyName = "NullableAgentSessionRecordingTrackEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityStatus?), TypeInfoPropertyName = "NullablePublicAgentEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityPublicationState?), TypeInfoPropertyName = "NullablePublicAgentEntityPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem?), TypeInfoPropertyName = "NullablePublicAgentEntityOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatchAction?), TypeInfoPropertyName = "NullableAgentOutboundVoicemailPatchAction2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchMode?), TypeInfoPropertyName = "NullableAgentTransferDestinationPatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect?), TypeInfoPropertyName = "NullableAgentTransferDestinationPatchWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisDataFieldType?), TypeInfoPropertyName = "NullablePublicAgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage?), TypeInfoPropertyName = "NullablePublicAgentAnalysisSummaryPatchLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item?), TypeInfoPropertyName = "NullablePublicAgentUpdatePayloadOverridesAllowedVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisDataFieldType?), TypeInfoPropertyName = "NullableAgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage?), TypeInfoPropertyName = "NullableAgentAnalysisSummaryConfigLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigEagerness?), TypeInfoPropertyName = "NullableAgentConversationConfigEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentConversationConfigInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentLLMConfigRedactedModel?), TypeInfoPropertyName = "NullableAgentLLMConfigRedactedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailConfigAction?), TypeInfoPropertyName = "NullableAgentOutboundVoicemailConfigAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentPromptConfigFirstMessageMode?), TypeInfoPropertyName = "NullableAgentPromptConfigFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationMode?), TypeInfoPropertyName = "NullableAgentTransferDestinationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationWarmConnect?), TypeInfoPropertyName = "NullableAgentTransferDestinationWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?), TypeInfoPropertyName = "NullableAgentVoiceConfigSpeakingLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryToolType?), TypeInfoPropertyName = "NullablePublicAgentToolSummaryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryMethod?), TypeInfoPropertyName = "NullablePublicAgentToolSummaryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookHeaderPayloadKind?), TypeInfoPropertyName = "NullableAgentWebhookHeaderPayloadKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicToolHeaderKind?), TypeInfoPropertyName = "NullablePublicToolHeaderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityProvider?), TypeInfoPropertyName = "NullablePublicPhoneNumberEntityProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityStatus?), TypeInfoPropertyName = "NullablePublicPhoneNumberEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport?), TypeInfoPropertyName = "NullablePublicSipNumberImportPayloadTerminationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>?), TypeInfoPropertyName = "NullableAnyOfIListReferenceAudioIListIListReferenceAudioObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestFormat?), TypeInfoPropertyName = "NullableTTSRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestLatency?), TypeInfoPropertyName = "NullableTTSRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat?), TypeInfoPropertyName = "NullableTTSStreamWithTimestampRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency?), TypeInfoPropertyName = "NullableTTSStreamWithTimestampRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityType?), TypeInfoPropertyName = "NullableModelEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTrainMode?), TypeInfoPropertyName = "NullableModelEntityTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityState?), TypeInfoPropertyName = "NullableModelEntityState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityVisibility?), TypeInfoPropertyName = "NullableModelEntityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>?), TypeInfoPropertyName = "NullableAnyOfPublicPhoneNumberPurchasePayloadPublicSipNumberImportPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>?), TypeInfoPropertyName = "NullableAnyOfIListByteArrayByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?), TypeInfoPropertyName = "NullableAnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility2?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility3?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility4?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsPublicationState?), TypeInfoPropertyName = "NullableGetAgentAgentsPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?), TypeInfoPropertyName = "NullableGetAgentAvailablePhoneNumbersNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsModel?), TypeInfoPropertyName = "NullableCreateTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampModel?), TypeInfoPropertyName = "NullableCreateTtsStreamWithTimestampModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelSortBy?), TypeInfoPropertyName = "NullableGetModelSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseSource?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDirection?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ItemsItem?), TypeInfoPropertyName = "NullableItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus?), TypeInfoPropertyName = "NullableGetAgentSessionsRecordingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullableGetAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullableGetAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseToolType?), TypeInfoPropertyName = "NullableCreateAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseMethod?), TypeInfoPropertyName = "NullableCreateAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling?), TypeInfoPropertyName = "NullableCreateAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode?), TypeInfoPropertyName = "NullableCreateAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseToolType?), TypeInfoPropertyName = "NullableGetAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseMethod?), TypeInfoPropertyName = "NullableGetAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseErrorHandling?), TypeInfoPropertyName = "NullableGetAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentToolsResponseExecutionMode?), TypeInfoPropertyName = "NullableGetAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseToolType?), TypeInfoPropertyName = "NullablePatchAgentToolsResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseMethod?), TypeInfoPropertyName = "NullablePatchAgentToolsResponseMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling?), TypeInfoPropertyName = "NullablePatchAgentToolsResponseErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode?), TypeInfoPropertyName = "NullablePatchAgentToolsResponseExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullableCreateAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullableGetAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableGetAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullablePatchAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullablePatchAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseType?), TypeInfoPropertyName = "NullableCreateModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTrainMode?), TypeInfoPropertyName = "NullableCreateModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseState?), TypeInfoPropertyName = "NullableCreateModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseVisibility?), TypeInfoPropertyName = "NullableCreateModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType?), TypeInfoPropertyName = "NullableGetModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode?), TypeInfoPropertyName = "NullableGetModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState?), TypeInfoPropertyName = "NullableGetModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility?), TypeInfoPropertyName = "NullableGetModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisDataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntityOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisDataField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentAnalysisCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestinationPatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhookPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisDataField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentAnalysisCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTransferDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicPostCallWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookArgumentPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookHeaderPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookMockResponsePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.SampleEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionRecordingTrackEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicKnowledgeSourceSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ASRSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ModelEntity>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::FishAudio.JsonConverters.ItemsItemJsonConverter());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<bool?, double?, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus2)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus2?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy2)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy2?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage2)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage2?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisDataValueType)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisDataValueType?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisResultStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisResultStatus?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionMessageItemRole)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionMessageItemRole?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionToolResultItemStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionToolResultItemStatus?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem?)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item?)

                    || typeToConvert == typeof(global::FishAudio.AgentAnalysisDataFieldType)

                    || typeToConvert == typeof(global::FishAudio.AgentAnalysisDataFieldType?)

                    || typeToConvert == typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage)

                    || typeToConvert == typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage?)

                    || typeToConvert == typeof(global::FishAudio.AgentConversationConfigEagerness)

                    || typeToConvert == typeof(global::FishAudio.AgentConversationConfigEagerness?)

                    || typeToConvert == typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity)

                    || typeToConvert == typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity?)

                    || typeToConvert == typeof(global::FishAudio.AgentLLMConfigRedactedModel)

                    || typeToConvert == typeof(global::FishAudio.AgentLLMConfigRedactedModel?)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailConfigAction)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailConfigAction?)

                    || typeToConvert == typeof(global::FishAudio.AgentPromptConfigFirstMessageMode)

                    || typeToConvert == typeof(global::FishAudio.AgentPromptConfigFirstMessageMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect?)

                    || typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage)

                    || typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryToolType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryToolType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryMethod)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryMethod?)

                    || typeToConvert == typeof(global::FishAudio.AgentWebhookHeaderPayloadKind)

                    || typeToConvert == typeof(global::FishAudio.AgentWebhookHeaderPayloadKind?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode?)

                    || typeToConvert == typeof(global::FishAudio.PublicToolHeaderKind)

                    || typeToConvert == typeof(global::FishAudio.PublicToolHeaderKind?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2?)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider?)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport)

                    || typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport?)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestFormat)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestFormat?)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestLatency)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestLatency?)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat?)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityType)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityType?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityState)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityState?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityVisibility)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityVisibility?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory2)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory2?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState2)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState2?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility6)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility6?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility8)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility8?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsModel)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsModel?)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel?)

                    || typeToConvert == typeof(global::FishAudio.GetModelSortBy)

                    || typeToConvert == typeof(global::FishAudio.GetModelSortBy?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus2)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus2?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy2)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy2?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponsePublicationState)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponsePublicationState?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseToolType)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseToolType?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseMethod)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseMethod?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseToolType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseToolType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseMethod)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseMethod?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseErrorHandling)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseErrorHandling?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseExecutionMode)

                    || typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseExecutionMode?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseToolType)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseToolType?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseMethod)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseMethod?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseType)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseType?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseState)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseState?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory2)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory2?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState2)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState2?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseType)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseType?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseState)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseState?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory2)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory2?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState2)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummarySourceJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummarySourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus2))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDialStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus2?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDialStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy2))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredBy2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy2?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredBy2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage2))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage2?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisCriterionResultResultJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisCriterionResultResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisDataValueType))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisDataValueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisDataValueType?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisDataValueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisResultStatus))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionAnalysisResultStatus?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionAnalysisResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionMessageItemRole))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionMessageItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionMessageItemRole?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionMessageItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionToolResultItemStatus))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionToolResultItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionToolResultItemStatus?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionToolResultItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityPublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityPublicationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityOverridesAllowedItemJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentEntityOverridesAllowedItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction))
                {
                    return new global::FishAudio.JsonConverters.AgentOutboundVoicemailPatchActionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction?))
                {
                    return new global::FishAudio.JsonConverters.AgentOutboundVoicemailPatchActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchWarmConnectJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchWarmConnectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentAnalysisDataFieldTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentAnalysisDataFieldTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentAnalysisSummaryPatchLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentAnalysisSummaryPatchLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchEagerness2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchEagerness2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivity2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivity2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentLLMPatchModel2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentLLMPatchModel2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageMode2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageMode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadOverridesAllowedVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadOverridesAllowedVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentAnalysisDataFieldType))
                {
                    return new global::FishAudio.JsonConverters.AgentAnalysisDataFieldTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentAnalysisDataFieldType?))
                {
                    return new global::FishAudio.JsonConverters.AgentAnalysisDataFieldTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage))
                {
                    return new global::FishAudio.JsonConverters.AgentAnalysisSummaryConfigLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage?))
                {
                    return new global::FishAudio.JsonConverters.AgentAnalysisSummaryConfigLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentConversationConfigEagerness))
                {
                    return new global::FishAudio.JsonConverters.AgentConversationConfigEagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentConversationConfigEagerness?))
                {
                    return new global::FishAudio.JsonConverters.AgentConversationConfigEagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity))
                {
                    return new global::FishAudio.JsonConverters.AgentConversationConfigInterruptionSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity?))
                {
                    return new global::FishAudio.JsonConverters.AgentConversationConfigInterruptionSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentLLMConfigRedactedModel))
                {
                    return new global::FishAudio.JsonConverters.AgentLLMConfigRedactedModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentLLMConfigRedactedModel?))
                {
                    return new global::FishAudio.JsonConverters.AgentLLMConfigRedactedModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailConfigAction))
                {
                    return new global::FishAudio.JsonConverters.AgentOutboundVoicemailConfigActionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailConfigAction?))
                {
                    return new global::FishAudio.JsonConverters.AgentOutboundVoicemailConfigActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentPromptConfigFirstMessageMode))
                {
                    return new global::FishAudio.JsonConverters.AgentPromptConfigFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentPromptConfigFirstMessageMode?))
                {
                    return new global::FishAudio.JsonConverters.AgentPromptConfigFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage))
                {
                    return new global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?))
                {
                    return new global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryToolType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolSummaryToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryToolType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolSummaryToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryMethod))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolSummaryMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryMethod?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolSummaryMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentWebhookHeaderPayloadKind))
                {
                    return new global::FishAudio.JsonConverters.AgentWebhookHeaderPayloadKindJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentWebhookHeaderPayloadKind?))
                {
                    return new global::FishAudio.JsonConverters.AgentWebhookHeaderPayloadKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadErrorHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadErrorHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicToolHeaderKind))
                {
                    return new global::FishAudio.JsonConverters.PublicToolHeaderKindJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicToolHeaderKind?))
                {
                    return new global::FishAudio.JsonConverters.PublicToolHeaderKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethod2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethod2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandling2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandling2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionMode2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode2?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionMode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider?))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport))
                {
                    return new global::FishAudio.JsonConverters.PublicSipNumberImportPayloadTerminationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport?))
                {
                    return new global::FishAudio.JsonConverters.PublicSipNumberImportPayloadTerminationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSRequestFormat))
                {
                    return new global::FishAudio.JsonConverters.TTSRequestFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSRequestFormat?))
                {
                    return new global::FishAudio.JsonConverters.TTSRequestFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSRequestLatency))
                {
                    return new global::FishAudio.JsonConverters.TTSRequestLatencyJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSRequestLatency?))
                {
                    return new global::FishAudio.JsonConverters.TTSRequestLatencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat))
                {
                    return new global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat?))
                {
                    return new global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency))
                {
                    return new global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestLatencyJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency?))
                {
                    return new global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestLatencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityType))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityType?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTrainModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTrainModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityState))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityState?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityVisibility))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityVisibility?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory2))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTakedownCategory2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory2?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTakedownCategory2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState2))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityPvcReleaseState2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState2?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityPvcReleaseState2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility3JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility4JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelRequestVisibility4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility4JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility6))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility6JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility6?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility8))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility8JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility8?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateTtsModel))
                {
                    return new global::FishAudio.JsonConverters.CreateTtsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateTtsModel?))
                {
                    return new global::FishAudio.JsonConverters.CreateTtsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel))
                {
                    return new global::FishAudio.JsonConverters.CreateTtsStreamWithTimestampModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel?))
                {
                    return new global::FishAudio.JsonConverters.CreateTtsStreamWithTimestampModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelSortBy))
                {
                    return new global::FishAudio.JsonConverters.GetModelSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelSortBy?))
                {
                    return new global::FishAudio.JsonConverters.GetModelSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus2))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus2?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy2))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredBy2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy2?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredBy2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsRecordingResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsRecordingResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponsePublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponsePublicationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponseOverridesAllowedItemJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsResponseOverridesAllowedItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponsePublicationState))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponsePublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponsePublicationState?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponsePublicationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponseOverridesAllowedItemJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsResponseOverridesAllowedItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponsePublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponsePublicationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponseOverridesAllowedItemJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentAgentsResponseOverridesAllowedItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseToolType))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseToolType?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseMethod))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseMethod?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseErrorHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseErrorHandling?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseErrorHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentToolsResponseExecutionMode?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentToolsResponseExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseToolType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseToolType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseMethod))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseMethod?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseErrorHandling))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseErrorHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseErrorHandling?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseErrorHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseExecutionMode))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentToolsResponseExecutionMode?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentToolsResponseExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseToolType))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseToolType?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseMethod))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseMethod?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseErrorHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseErrorHandling?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseErrorHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentToolsResponseExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseType))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseType?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTrainModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTrainModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseState))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseState?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory2))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTakedownCategory2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory2?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTakedownCategory2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState2))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseState2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState2?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseState2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseType))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseType?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTrainModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTrainModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseState))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseState?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory2))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTakedownCategory2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory2?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTakedownCategory2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState2))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponsePvcReleaseState2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState2?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponsePvcReleaseState2NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}