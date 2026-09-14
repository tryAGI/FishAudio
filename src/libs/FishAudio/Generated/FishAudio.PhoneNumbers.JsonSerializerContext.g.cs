
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityProvider), TypeInfoPropertyName = "PublicPhoneNumberEntityProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus), TypeInfoPropertyName = "PublicPhoneNumberEntityCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityStatus), TypeInfoPropertyName = "PublicPhoneNumberEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberPurchasePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport), TypeInfoPropertyName = "PublicSipNumberImportPayloadTerminationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>), TypeInfoPropertyName = "AnyOfPublicPhoneNumberPurchasePayloadPublicSipNumberImportPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType), TypeInfoPropertyName = "GetAgentAvailablePhoneNumbersNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PublicPhoneNumberEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider), TypeInfoPropertyName = "CreateAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus), TypeInfoPropertyName = "CreateAgentPhoneNumbersResponseCallerIdSyncStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus), TypeInfoPropertyName = "GetAgentPhoneNumbersResponseCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus), TypeInfoPropertyName = "GetAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider), TypeInfoPropertyName = "PatchAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus), TypeInfoPropertyName = "PatchAgentPhoneNumbersResponseCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus), TypeInfoPropertyName = "PatchAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteAgentPhoneNumbersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityProvider?), TypeInfoPropertyName = "NullablePublicPhoneNumberEntityProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus?), TypeInfoPropertyName = "NullablePublicPhoneNumberEntityCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicPhoneNumberEntityStatus?), TypeInfoPropertyName = "NullablePublicPhoneNumberEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport?), TypeInfoPropertyName = "NullablePublicSipNumberImportPayloadTerminationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>?), TypeInfoPropertyName = "NullableAnyOfPublicPhoneNumberPurchasePayloadPublicSipNumberImportPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?), TypeInfoPropertyName = "NullableGetAgentAvailablePhoneNumbersNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullableCreateAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus?), TypeInfoPropertyName = "NullableCreateAgentPhoneNumbersResponseCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableCreateAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullableGetAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus?), TypeInfoPropertyName = "NullableGetAgentPhoneNumbersResponseCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullableGetAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider?), TypeInfoPropertyName = "NullablePatchAgentPhoneNumbersResponseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus?), TypeInfoPropertyName = "NullablePatchAgentPhoneNumbersResponseCallerIdSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?), TypeInfoPropertyName = "NullablePatchAgentPhoneNumbersResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PublicPhoneNumberEntity>))]
    internal sealed partial class PhoneNumbersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumbersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PhoneNumbersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PhoneNumbersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::FishAudio.PublicPhoneNumberPurchasePayload, global::FishAudio.PublicSipNumberImportPayload>());
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
                    typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider?)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus)

                    || typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityStatus?)

                    || typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport)

                    || typeToConvert == typeof(global::FishAudio.PublicSipNumberImportPayloadTerminationTransport?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType)

                    || typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus?)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus?)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseStatus?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseProvider?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus?)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus)

                    || typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityProvider?))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityCallerIdSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PublicPhoneNumberEntityCallerIdSyncStatus?))
                {
                    return new global::FishAudio.JsonConverters.PublicPhoneNumberEntityCallerIdSyncStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentAvailablePhoneNumbersNumberType?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentAvailablePhoneNumbersNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseProvider?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseCallerIdSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus?))
                {
                    return new global::FishAudio.JsonConverters.CreateAgentPhoneNumbersResponseCallerIdSyncStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseCallerIdSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetAgentPhoneNumbersResponseCallerIdSyncStatus?))
                {
                    return new global::FishAudio.JsonConverters.GetAgentPhoneNumbersResponseCallerIdSyncStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseCallerIdSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseCallerIdSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchAgentPhoneNumbersResponseStatus?))
                {
                    return new global::FishAudio.JsonConverters.PatchAgentPhoneNumbersResponseStatusNullableJsonConverter();
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
                    0 => new PhoneNumbersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}