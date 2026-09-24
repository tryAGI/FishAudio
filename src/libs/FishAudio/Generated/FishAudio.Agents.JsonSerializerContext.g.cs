
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityStatus), TypeInfoPropertyName = "PublicAgentEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityPublicationState), TypeInfoPropertyName = "PublicAgentEntityPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentEntityOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem), TypeInfoPropertyName = "PublicAgentEntityOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatchAction), TypeInfoPropertyName = "AgentOutboundVoicemailPatchAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchType), TypeInfoPropertyName = "AgentTransferDestinationPatchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchMode), TypeInfoPropertyName = "AgentTransferDestinationPatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect), TypeInfoPropertyName = "AgentTransferDestinationPatchWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailurePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailurePatchAction), TypeInfoPropertyName = "AgentTransferOnFailurePatchAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchEagerness), TypeInfoPropertyName = "PublicAgentConversationPatchEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity), TypeInfoPropertyName = "PublicAgentConversationPatchInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMCustomConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMPatchModel), TypeInfoPropertyName = "PublicAgentLLMPatchModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode), TypeInfoPropertyName = "PublicAgentPromptPatchFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSystemToolsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage), TypeInfoPropertyName = "PublicAgentVoicePatchSpeakingLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicConversationInitWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicPostCallWebhookPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPostCallWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadStatus), TypeInfoPropertyName = "PublicAgentUpdatePayloadStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationType), TypeInfoPropertyName = "AgentTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationMode), TypeInfoPropertyName = "AgentTransferDestinationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationWarmConnect), TypeInfoPropertyName = "AgentTransferDestinationWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailureAction), TypeInfoPropertyName = "AgentTransferOnFailureAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsPublicationState), TypeInfoPropertyName = "GetAgentAgentsPublicationState2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsConfigResponse6))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityStatus?), TypeInfoPropertyName = "NullablePublicAgentEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityPublicationState?), TypeInfoPropertyName = "NullablePublicAgentEntityPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem?), TypeInfoPropertyName = "NullablePublicAgentEntityOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailPatchAction?), TypeInfoPropertyName = "NullableAgentOutboundVoicemailPatchAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchType?), TypeInfoPropertyName = "NullableAgentTransferDestinationPatchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchMode?), TypeInfoPropertyName = "NullableAgentTransferDestinationPatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect?), TypeInfoPropertyName = "NullableAgentTransferDestinationPatchWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailurePatchAction?), TypeInfoPropertyName = "NullableAgentTransferOnFailurePatchAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisDataFieldType?), TypeInfoPropertyName = "NullablePublicAgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage?), TypeInfoPropertyName = "NullablePublicAgentAnalysisSummaryPatchLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchEagerness?), TypeInfoPropertyName = "NullablePublicAgentConversationPatchEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity?), TypeInfoPropertyName = "NullablePublicAgentConversationPatchInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentLLMPatchModel?), TypeInfoPropertyName = "NullablePublicAgentLLMPatchModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode?), TypeInfoPropertyName = "NullablePublicAgentPromptPatchFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage?), TypeInfoPropertyName = "NullablePublicAgentVoicePatchSpeakingLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadStatus?), TypeInfoPropertyName = "NullablePublicAgentUpdatePayloadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentUpdatePayloadOverridesAllowedVariant1Item?), TypeInfoPropertyName = "NullablePublicAgentUpdatePayloadOverridesAllowedVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisDataFieldType?), TypeInfoPropertyName = "NullableAgentAnalysisDataFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentAnalysisSummaryConfigLanguage?), TypeInfoPropertyName = "NullableAgentAnalysisSummaryConfigLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigEagerness?), TypeInfoPropertyName = "NullableAgentConversationConfigEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentConversationConfigInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentConversationConfigInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentLLMConfigRedactedModel?), TypeInfoPropertyName = "NullableAgentLLMConfigRedactedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentOutboundVoicemailConfigAction?), TypeInfoPropertyName = "NullableAgentOutboundVoicemailConfigAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentPromptConfigFirstMessageMode?), TypeInfoPropertyName = "NullableAgentPromptConfigFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationType?), TypeInfoPropertyName = "NullableAgentTransferDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationMode?), TypeInfoPropertyName = "NullableAgentTransferDestinationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferDestinationWarmConnect?), TypeInfoPropertyName = "NullableAgentTransferDestinationWarmConnect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTransferOnFailureAction?), TypeInfoPropertyName = "NullableAgentTransferOnFailureAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?), TypeInfoPropertyName = "NullableAgentVoiceConfigSpeakingLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsPublicationState?), TypeInfoPropertyName = "NullableGetAgentAgentsPublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullableCreateAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullableGetAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullableGetAgentAgentsResponseOverridesAllowedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseStatus?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponsePublicationState?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponsePublicationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem?), TypeInfoPropertyName = "NullablePatchAgentAgentsResponseOverridesAllowedItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.CreateAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentVersionSummary>))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<bool?, double?, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
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
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityPublicationState?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentEntityOverridesAllowedItem?)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction)

                    || typeToConvert == typeof(global::FishAudio.AgentOutboundVoicemailPatchAction?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchType)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchWarmConnect?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferOnFailurePatchAction)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferOnFailurePatchAction?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisDataFieldType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentAnalysisSummaryPatchLanguage?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus?)

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

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationType)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferDestinationWarmConnect?)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferOnFailureAction)

                    || typeToConvert == typeof(global::FishAudio.AgentTransferOnFailureAction?)

                    || typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage)

                    || typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState?)

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

                    || typeToConvert == typeof(global::FishAudio.PatchAgentAgentsResponseOverridesAllowedItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchType))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationPatchType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationPatchTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.AgentTransferOnFailurePatchAction))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferOnFailurePatchActionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferOnFailurePatchAction?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferOnFailurePatchActionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchEagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchEagerness?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchEagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentLLMPatchModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentLLMPatchModel?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentLLMPatchModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentUpdatePayloadStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationType))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferDestinationType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferDestinationTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.AgentTransferOnFailureAction))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferOnFailureActionJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTransferOnFailureAction?))
                {
                    return new global::FishAudio.JsonConverters.AgentTransferOnFailureActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage))
                {
                    return new global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentVoiceConfigSpeakingLanguage?))
                {
                    return new global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsPublicationState?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}