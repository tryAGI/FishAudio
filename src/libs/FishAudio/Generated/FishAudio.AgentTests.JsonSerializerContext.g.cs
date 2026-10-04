
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestAssertionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestAssertionResultKind), TypeInfoPropertyName = "AgentTestAssertionResultKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestAssertionResultToolType), TypeInfoPropertyName = "AgentTestAssertionResultToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestConditionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestConditionResultResult), TypeInfoPropertyName = "AgentTestConditionResultResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMockGap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMockGapToolType), TypeInfoPropertyName = "AgentTestMockGapToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMockGapSource), TypeInfoPropertyName = "AgentTestMockGapSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestTranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestTranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolCallRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestConditionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolCallRecordMockSource), TypeInfoPropertyName = "AgentTestToolCallRecordMockSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestTranscriptMessageRole), TypeInfoPropertyName = "AgentTestTranscriptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunTestType), TypeInfoPropertyName = "PublicAgentTestRunTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunStatus), TypeInfoPropertyName = "PublicAgentTestRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunChannel), TypeInfoPropertyName = "PublicAgentTestRunChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunEndedBy), TypeInfoPropertyName = "PublicAgentTestRunEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestMockGap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestToolType), TypeInfoPropertyName = "PublicAgentTestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestBatchSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus), TypeInfoPropertyName = "PublicAgentTestBatchSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource), TypeInfoPropertyName = "PublicAgentTestBatchSummaryTriggerSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestSummaryTestType), TypeInfoPropertyName = "PublicAgentTestSummaryTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMessagePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMessagePayloadRole), TypeInfoPropertyName = "AgentTestMessagePayloadRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestParamMatcher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestParamMatcherType), TypeInfoPropertyName = "AgentTestParamMatcherType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestReferencedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestReferencedToolType), TypeInfoPropertyName = "AgentTestReferencedToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationAssertions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolCallAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolCallAssertion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestReferencedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy), TypeInfoPropertyName = "AgentTestSimulationAssertionsEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestSuccessCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSuccessCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMocks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationConfigChannel), TypeInfoPropertyName = "AgentTestSimulationConfigChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::FishAudio.AgentTestParamMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMocksStrategy), TypeInfoPropertyName = "AgentTestToolMocksStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMocksFallback), TypeInfoPropertyName = "AgentTestToolMocksFallback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolParameterType), TypeInfoPropertyName = "AgentTestToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType), TypeInfoPropertyName = "PublicAgentTestCreatePayloadTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestMessagePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.AgentTestToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestMessageRole), TypeInfoPropertyName = "PublicAgentTestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType), TypeInfoPropertyName = "PublicAgentTestUpdatePayloadTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunSummaryTestType), TypeInfoPropertyName = "PublicAgentTestRunSummaryTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunSummaryStatus), TypeInfoPropertyName = "PublicAgentTestRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsTestType), TypeInfoPropertyName = "GetAgentTestsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsStatus), TypeInfoPropertyName = "GetAgentTestRunsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsTestType), TypeInfoPropertyName = "GetAgentTestRunsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PutAgentAgentsTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PutAgentAgentsTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PutAgentAgentsTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PutAgentAgentsTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentAgentsTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus), TypeInfoPropertyName = "CreateAgentAgentsTestsRunResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestToolsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestBatchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus), TypeInfoPropertyName = "GetAgentAgentsTestBatchesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponseTestType), TypeInfoPropertyName = "CreateAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponseTestType), TypeInfoPropertyName = "GetAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponseTestType), TypeInfoPropertyName = "PatchAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentTestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentTestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicAgentTestRunSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseTestType), TypeInfoPropertyName = "GetAgentTestRunsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseStatus), TypeInfoPropertyName = "GetAgentTestRunsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseChannel), TypeInfoPropertyName = "GetAgentTestRunsResponseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy), TypeInfoPropertyName = "GetAgentTestRunsResponseEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestAssertionResultKind?), TypeInfoPropertyName = "NullableAgentTestAssertionResultKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestAssertionResultToolType?), TypeInfoPropertyName = "NullableAgentTestAssertionResultToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestConditionResultResult?), TypeInfoPropertyName = "NullableAgentTestConditionResultResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMockGapToolType?), TypeInfoPropertyName = "NullableAgentTestMockGapToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMockGapSource?), TypeInfoPropertyName = "NullableAgentTestMockGapSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolCallRecordMockSource?), TypeInfoPropertyName = "NullableAgentTestToolCallRecordMockSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestTranscriptMessageRole?), TypeInfoPropertyName = "NullableAgentTestTranscriptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunTestType?), TypeInfoPropertyName = "NullablePublicAgentTestRunTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunStatus?), TypeInfoPropertyName = "NullablePublicAgentTestRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunChannel?), TypeInfoPropertyName = "NullablePublicAgentTestRunChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunEndedBy?), TypeInfoPropertyName = "NullablePublicAgentTestRunEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestToolType?), TypeInfoPropertyName = "NullablePublicAgentTestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus?), TypeInfoPropertyName = "NullablePublicAgentTestBatchSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource?), TypeInfoPropertyName = "NullablePublicAgentTestBatchSummaryTriggerSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestSummaryTestType?), TypeInfoPropertyName = "NullablePublicAgentTestSummaryTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestMessagePayloadRole?), TypeInfoPropertyName = "NullableAgentTestMessagePayloadRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestParamMatcherType?), TypeInfoPropertyName = "NullableAgentTestParamMatcherType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestReferencedToolType?), TypeInfoPropertyName = "NullableAgentTestReferencedToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy?), TypeInfoPropertyName = "NullableAgentTestSimulationAssertionsEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestSimulationConfigChannel?), TypeInfoPropertyName = "NullableAgentTestSimulationConfigChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMocksStrategy?), TypeInfoPropertyName = "NullableAgentTestToolMocksStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolMocksFallback?), TypeInfoPropertyName = "NullableAgentTestToolMocksFallback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentTestToolParameterType?), TypeInfoPropertyName = "NullableAgentTestToolParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType?), TypeInfoPropertyName = "NullablePublicAgentTestCreatePayloadTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestMessageRole?), TypeInfoPropertyName = "NullablePublicAgentTestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType?), TypeInfoPropertyName = "NullablePublicAgentTestUpdatePayloadTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunSummaryTestType?), TypeInfoPropertyName = "NullablePublicAgentTestRunSummaryTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentTestRunSummaryStatus?), TypeInfoPropertyName = "NullablePublicAgentTestRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsTestType?), TypeInfoPropertyName = "NullableGetAgentTestsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsStatus?), TypeInfoPropertyName = "NullableGetAgentTestRunsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsTestType?), TypeInfoPropertyName = "NullableGetAgentTestRunsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentAgentsTestsRunResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus?), TypeInfoPropertyName = "NullableGetAgentAgentsTestBatchesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentTestsResponseTestType?), TypeInfoPropertyName = "NullableCreateAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestsResponseTestType?), TypeInfoPropertyName = "NullableGetAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentTestsResponseTestType?), TypeInfoPropertyName = "NullablePatchAgentTestsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseTestType?), TypeInfoPropertyName = "NullableGetAgentTestRunsResponseTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentTestRunsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseChannel?), TypeInfoPropertyName = "NullableGetAgentTestRunsResponseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy?), TypeInfoPropertyName = "NullableGetAgentTestRunsResponseEndedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestTranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestConditionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestMockGap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestToolCallAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestReferencedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestSuccessCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestMessagePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentTestToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestBatchSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentTestRunSummary>))]
    internal sealed partial class AgentTestsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTestsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentTestsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentTestsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<bool?, double?, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
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
                    typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultKind)

                    || typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultKind?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultToolType)

                    || typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultToolType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestConditionResultResult)

                    || typeToConvert == typeof(global::FishAudio.AgentTestConditionResultResult?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMockGapToolType)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMockGapToolType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMockGapSource)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMockGapSource?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolCallRecordMockSource)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolCallRecordMockSource?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestTranscriptMessageRole)

                    || typeToConvert == typeof(global::FishAudio.AgentTestTranscriptMessageRole?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunTestType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunTestType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunChannel)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunChannel?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunEndedBy)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunEndedBy?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestToolType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestToolType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestSummaryTestType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestSummaryTestType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMessagePayloadRole)

                    || typeToConvert == typeof(global::FishAudio.AgentTestMessagePayloadRole?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestParamMatcherType)

                    || typeToConvert == typeof(global::FishAudio.AgentTestParamMatcherType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestReferencedToolType)

                    || typeToConvert == typeof(global::FishAudio.AgentTestReferencedToolType?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy)

                    || typeToConvert == typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestSimulationConfigChannel)

                    || typeToConvert == typeof(global::FishAudio.AgentTestSimulationConfigChannel?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolMocksStrategy)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolMocksStrategy?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolMocksFallback)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolMocksFallback?)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolParameterType)

                    || typeToConvert == typeof(global::FishAudio.AgentTestToolParameterType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestMessageRole)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestMessageRole?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryTestType)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryTestType?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestsTestType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestsTestType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsTestType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsTestType?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentTestsResponseTestType)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentTestsResponseTestType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestsResponseTestType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestsResponseTestType?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentTestsResponseTestType)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentTestsResponseTestType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseTestType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseTestType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseChannel)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseChannel?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy)

                    || typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultKind))
                {
                    return new global::FishAudio.JsonConverters.AgentTestAssertionResultKindJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultKind?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestAssertionResultKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultToolType))
                {
                    return new global::FishAudio.JsonConverters.AgentTestAssertionResultToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestAssertionResultToolType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestAssertionResultToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestConditionResultResult))
                {
                    return new global::FishAudio.JsonConverters.AgentTestConditionResultResultJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestConditionResultResult?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestConditionResultResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMockGapToolType))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMockGapToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMockGapToolType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMockGapToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMockGapSource))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMockGapSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMockGapSource?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMockGapSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolCallRecordMockSource))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolCallRecordMockSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolCallRecordMockSource?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolCallRecordMockSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestTranscriptMessageRole))
                {
                    return new global::FishAudio.JsonConverters.AgentTestTranscriptMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestTranscriptMessageRole?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestTranscriptMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunTestType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunTestType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunChannel))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunChannel?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunEndedBy))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunEndedByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunEndedBy?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunEndedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestToolType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestToolType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryTriggerSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestBatchSummaryTriggerSource?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestBatchSummaryTriggerSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestSummaryTestType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestSummaryTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestSummaryTestType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestSummaryTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMessagePayloadRole))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMessagePayloadRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestMessagePayloadRole?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestMessagePayloadRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestParamMatcherType))
                {
                    return new global::FishAudio.JsonConverters.AgentTestParamMatcherTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestParamMatcherType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestParamMatcherTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestReferencedToolType))
                {
                    return new global::FishAudio.JsonConverters.AgentTestReferencedToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestReferencedToolType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestReferencedToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy))
                {
                    return new global::FishAudio.JsonConverters.AgentTestSimulationAssertionsEndedByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestSimulationAssertionsEndedBy?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestSimulationAssertionsEndedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestSimulationConfigChannel))
                {
                    return new global::FishAudio.JsonConverters.AgentTestSimulationConfigChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestSimulationConfigChannel?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestSimulationConfigChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolMocksStrategy))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolMocksStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolMocksStrategy?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolMocksStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolMocksFallback))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolMocksFallbackJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolMocksFallback?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolMocksFallbackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolParameterType))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolParameterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentTestToolParameterType?))
                {
                    return new global::FishAudio.JsonConverters.AgentTestToolParameterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestCreatePayloadTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestCreatePayloadTestType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestCreatePayloadTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestMessageRole))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestMessageRole?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestUpdatePayloadTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestUpdatePayloadTestType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestUpdatePayloadTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryTestType))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunSummaryTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryTestType?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunSummaryTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentTestRunSummaryStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentTestRunSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestsTestType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestsTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestsTestType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestsTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsTestType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsTestType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsTestsRunResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentAgentsTestsRunResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentAgentsTestsRunResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsTestBatchesResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAgentsTestBatchesResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAgentsTestBatchesResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentTestsResponseTestType))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentTestsResponseTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentTestsResponseTestType?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentTestsResponseTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestsResponseTestType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestsResponseTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestsResponseTestType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestsResponseTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentTestsResponseTestType))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentTestsResponseTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentTestsResponseTestType?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentTestsResponseTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseTestType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseTestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseTestType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseTestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseChannel))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseChannel?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseEndedByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentTestRunsResponseEndedBy?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentTestRunsResponseEndedByNullableJsonConverter();
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
                    0 => new AgentTestsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}