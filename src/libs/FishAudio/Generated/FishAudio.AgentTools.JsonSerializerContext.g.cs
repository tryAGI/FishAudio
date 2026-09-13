
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod), TypeInfoPropertyName = "PublicAgentToolUpdatePayloadMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling), TypeInfoPropertyName = "PublicAgentToolUpdatePayloadErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode), TypeInfoPropertyName = "PublicAgentToolUpdatePayloadExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicDependentAgent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryToolType?), TypeInfoPropertyName = "NullablePublicAgentToolSummaryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolSummaryMethod?), TypeInfoPropertyName = "NullablePublicAgentToolSummaryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AgentWebhookHeaderPayloadKind?), TypeInfoPropertyName = "NullableAgentWebhookHeaderPayloadKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadToolType?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadMethod?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadErrorHandling?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolCreatePayloadExecutionMode?), TypeInfoPropertyName = "NullablePublicAgentToolCreatePayloadExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicToolHeaderKind?), TypeInfoPropertyName = "NullablePublicToolHeaderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod?), TypeInfoPropertyName = "NullablePublicAgentToolUpdatePayloadMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling?), TypeInfoPropertyName = "NullablePublicAgentToolUpdatePayloadErrorHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode?), TypeInfoPropertyName = "NullablePublicAgentToolUpdatePayloadExecutionMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookArgumentPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookHeaderPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.AgentWebhookMockResponsePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicDependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicAgentToolSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicToolHeader>))]
    internal sealed partial class AgentToolsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentToolsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentToolsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::FishAudio.PublicAgentToolSummaryToolType)

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

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling?)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode)

                    || typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode?)

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

                    || typeToConvert == typeof(global::FishAudio.PatchAgentToolsResponseExecutionMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadMethod?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadErrorHandling?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadErrorHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicAgentToolUpdatePayloadExecutionMode?))
                {
                    return new global::FishAudio.JsonConverters.PublicAgentToolUpdatePayloadExecutionModeNullableJsonConverter();
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
                    0 => new AgentToolsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}