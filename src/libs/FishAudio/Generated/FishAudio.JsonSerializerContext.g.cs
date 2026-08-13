
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
            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummarySourceJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummarySourceNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryDirectionJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryDirectionNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryDialStatus2JsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryDialStatus2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredBy2JsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredBy2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguage2JsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguage2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisCriterionResultResultJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisCriterionResultResultNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisDataValueTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisDataValueTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisResultStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionAnalysisResultStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionMessageItemRoleJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionMessageItemRoleNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionToolResultItemStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionToolResultItemStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityRoleJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityRoleNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentSessionRecordingTrackEntityStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityPublicationStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityPublicationStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityOverridesAllowedItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentEntityOverridesAllowedItemNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentOutboundVoicemailPatchActionJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentOutboundVoicemailPatchActionNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchWarmConnectJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationPatchWarmConnectNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentAnalysisDataFieldTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentAnalysisDataFieldTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentAnalysisSummaryPatchLanguageJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentAnalysisSummaryPatchLanguageNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentConversationPatchEagerness2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentConversationPatchEagerness2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivity2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentConversationPatchInterruptionSensitivity2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageMode2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentPromptPatchFirstMessageMode2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguage2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentVoicePatchSpeakingLanguage2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatus2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentUpdatePayloadStatus2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentUpdatePayloadOverridesAllowedVariant1ItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentUpdatePayloadOverridesAllowedVariant1ItemNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentAnalysisDataFieldTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentAnalysisDataFieldTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentAnalysisSummaryConfigLanguageJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentAnalysisSummaryConfigLanguageNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentConversationConfigEagernessJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentConversationConfigEagernessNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentConversationConfigInterruptionSensitivityJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentConversationConfigInterruptionSensitivityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentOutboundVoicemailConfigActionJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentOutboundVoicemailConfigActionNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentPromptConfigFirstMessageModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentPromptConfigFirstMessageModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolSummaryToolTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolSummaryToolTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolSummaryMethodJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolSummaryMethodNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentWebhookHeaderPayloadKindJsonConverter),

            typeof(global::FishAudio.JsonConverters.AgentWebhookHeaderPayloadKindNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadToolTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadToolTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadMethodJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadMethodNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadErrorHandlingJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadErrorHandlingNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadExecutionModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadExecutionModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicToolHeaderKindJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicToolHeaderKindNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethod2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethod2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandling2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandling2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionMode2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionMode2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicPhoneNumberEntityStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.PublicPhoneNumberEntityStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestFormatJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestFormatNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestLatencyJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestLatencyNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestFormatJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestFormatNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestLatencyJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSStreamWithTimestampRequestLatencyNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityPvcReleaseState2JsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityPvcReleaseState2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility2JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility3JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility3NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility4JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility4NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility4JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility4NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility6JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility6NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility8JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility8NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsPublicationStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsModelJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsModelNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsStreamWithTimestampModelJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsStreamWithTimestampModelNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelSortByJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelSortByNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseSourceJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseSourceNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseDirectionJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseDirectionNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatus2JsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatus2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredBy2JsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredBy2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseItemDiscriminatorTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsResponseItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsRecordingResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentSessionsRecordingResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponsePublicationStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponsePublicationStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponseOverridesAllowedItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentAgentsResponseOverridesAllowedItemNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponsePublicationStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponsePublicationStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponseOverridesAllowedItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentAgentsResponseOverridesAllowedItemNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponsePublicationStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponsePublicationStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponseOverridesAllowedItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentAgentsResponseOverridesAllowedItemNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseToolTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseToolTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseMethodJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseMethodNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseErrorHandlingJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseErrorHandlingNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseExecutionModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseExecutionModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseToolTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseToolTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseMethodJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseMethodNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseErrorHandlingJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseErrorHandlingNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseExecutionModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentToolsResponseExecutionModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseToolTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseToolTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseMethodJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseMethodNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseErrorHandlingJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseErrorHandlingNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseExecutionModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentToolsResponseExecutionModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseProviderJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseProviderNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseProviderJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseProviderNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseState2JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseState2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponsePvcReleaseState2JsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponsePvcReleaseState2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ItemsItemJsonConverter),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<bool?, double?, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::FishAudio.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchEagerness2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentConversationPatchInterruptionSensitivity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTransferDestinationPatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentPromptPatchFirstMessageMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSystemToolsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentVoicePatchSpeakingLanguage2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberUpdatePayload))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityPvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelQualityEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsPublishRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentKnowledgeSourcesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentKnowledgeSourcesRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponsePvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType), TypeInfoPropertyName = "GetModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode), TypeInfoPropertyName = "GetModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState), TypeInfoPropertyName = "GetModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility), TypeInfoPropertyName = "GetModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponsePvcReleaseState2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse2))]
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}