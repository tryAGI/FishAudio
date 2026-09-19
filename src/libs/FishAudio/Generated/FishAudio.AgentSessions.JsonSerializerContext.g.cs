
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryStatus), TypeInfoPropertyName = "AgentSessionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryEndReason), TypeInfoPropertyName = "AgentSessionSummaryEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummarySource), TypeInfoPropertyName = "AgentSessionSummarySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDirection), TypeInfoPropertyName = "AgentSessionSummaryDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDialStatus), TypeInfoPropertyName = "AgentSessionSummaryDialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryAnsweredBy), TypeInfoPropertyName = "AgentSessionSummaryAnsweredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionOverridesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage), TypeInfoPropertyName = "AgentSessionOverridesPayloadLanguage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionMessageItemRole), TypeInfoPropertyName = "AgentSessionMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItemStatus), TypeInfoPropertyName = "AgentSessionToolResultItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageTokenCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageTokenCostCategory), TypeInfoPropertyName = "LLMMessageTokenCostCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageUsageStatus), TypeInfoPropertyName = "LLMMessageUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageUsageBillingMode), TypeInfoPropertyName = "LLMMessageUsageBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.LLMMessageTokenCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole), TypeInfoPropertyName = "AgentSessionRecordingTrackEntityRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus), TypeInfoPropertyName = "AgentSessionRecordingTrackEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseEndReason), TypeInfoPropertyName = "GetAgentSessionsResponseEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseSource), TypeInfoPropertyName = "GetAgentSessionsResponseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDirection), TypeInfoPropertyName = "GetAgentSessionsResponseDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDialStatus), TypeInfoPropertyName = "GetAgentSessionsResponseDialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy), TypeInfoPropertyName = "GetAgentSessionsResponseAnsweredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.LLMMessageUsage>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryStatus?), TypeInfoPropertyName = "NullableAgentSessionSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryEndReason?), TypeInfoPropertyName = "NullableAgentSessionSummaryEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummarySource?), TypeInfoPropertyName = "NullableAgentSessionSummarySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDirection?), TypeInfoPropertyName = "NullableAgentSessionSummaryDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryDialStatus?), TypeInfoPropertyName = "NullableAgentSessionSummaryDialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionSummaryAnsweredBy?), TypeInfoPropertyName = "NullableAgentSessionSummaryAnsweredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, int?, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage?), TypeInfoPropertyName = "NullableAgentSessionOverridesPayloadLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisCriterionResultResult?), TypeInfoPropertyName = "NullableAgentSessionAnalysisCriterionResultResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisDataValueType?), TypeInfoPropertyName = "NullableAgentSessionAnalysisDataValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<bool?, double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionAnalysisResultStatus?), TypeInfoPropertyName = "NullableAgentSessionAnalysisResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionMessageItemRole?), TypeInfoPropertyName = "NullableAgentSessionMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionToolResultItemStatus?), TypeInfoPropertyName = "NullableAgentSessionToolResultItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageTokenCostCategory?), TypeInfoPropertyName = "NullableLLMMessageTokenCostCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageUsageStatus?), TypeInfoPropertyName = "NullableLLMMessageUsageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.LLMMessageUsageBillingMode?), TypeInfoPropertyName = "NullableLLMMessageUsageBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole?), TypeInfoPropertyName = "NullableAgentSessionRecordingTrackEntityRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus?), TypeInfoPropertyName = "NullableAgentSessionRecordingTrackEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseStatus?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseEndReason?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseSource?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDirection?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseDialStatus?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseDialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseAnsweredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ItemsItem?), TypeInfoPropertyName = "NullableItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetAgentSessionsResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus?), TypeInfoPropertyName = "NullableGetAgentSessionsRecordingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisDataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionAnalysisCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.LLMMessageTokenCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.LLMMessageUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentSessionRecordingTrackEntity>))]
    internal sealed partial class AgentSessionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentSessionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentSessionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::FishAudio.JsonConverters.ItemsItemJsonConverter());
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
                    typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryStatus?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryEndReason)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryEndReason?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummarySource?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDirection?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage?)

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

                    || typeToConvert == typeof(global::FishAudio.LLMMessageTokenCostCategory)

                    || typeToConvert == typeof(global::FishAudio.LLMMessageTokenCostCategory?)

                    || typeToConvert == typeof(global::FishAudio.LLMMessageUsageStatus)

                    || typeToConvert == typeof(global::FishAudio.LLMMessageUsageStatus?)

                    || typeToConvert == typeof(global::FishAudio.LLMMessageUsageBillingMode)

                    || typeToConvert == typeof(global::FishAudio.LLMMessageUsageBillingMode?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityRole?)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.AgentSessionRecordingTrackEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseEndReason)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseEndReason?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseSource?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDirection?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentSessionsRecordingResponseStatus?);
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

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryEndReason))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryEndReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryEndReason?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryEndReasonNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDialStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryDialStatus?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryDialStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionSummaryAnsweredBy?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionSummaryAnsweredByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.AgentSessionOverridesPayloadLanguage?))
                {
                    return new global::FishAudio.JsonConverters.AgentSessionOverridesPayloadLanguageNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.LLMMessageTokenCostCategory))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageTokenCostCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.LLMMessageTokenCostCategory?))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageTokenCostCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.LLMMessageUsageStatus))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageUsageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.LLMMessageUsageStatus?))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageUsageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.LLMMessageUsageBillingMode))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageUsageBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.LLMMessageUsageBillingMode?))
                {
                    return new global::FishAudio.JsonConverters.LLMMessageUsageBillingModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseEndReason))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseEndReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseEndReason?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseEndReasonNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseDialStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseDialStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentSessionsResponseAnsweredBy?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentSessionsResponseAnsweredByNullableJsonConverter();
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
                    0 => new AgentSessionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}