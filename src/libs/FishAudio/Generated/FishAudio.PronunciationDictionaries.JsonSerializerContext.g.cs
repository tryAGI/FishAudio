
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1Entity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1VersionEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryItemPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryItemPayloadType), TypeInfoPropertyName = "PronunciationDictionaryItemPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryVersionCreatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryItemPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1ItemType), TypeInfoPropertyName = "PronunciationDictionaryV1ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType), TypeInfoPropertyName = "PronunciationDictionaryV1CompareRowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus), TypeInfoPropertyName = "PronunciationDictionaryV1CompareRowStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType), TypeInfoPropertyName = "PronunciationDictionaryV1CompareRowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchPronunciationDictionariesResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1VersionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreatePronunciationDictionariesVersionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsResponse12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesVersionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesVersionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeletePronunciationDictionariesVersionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryV1CompareRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetPronunciationDictionariesVersionsCompareResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryItemPayloadType?), TypeInfoPropertyName = "NullablePronunciationDictionaryItemPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1ItemType?), TypeInfoPropertyName = "NullablePronunciationDictionaryV1ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType?), TypeInfoPropertyName = "NullablePronunciationDictionaryV1CompareRowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus?), TypeInfoPropertyName = "NullablePronunciationDictionaryV1CompareRowStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType?), TypeInfoPropertyName = "NullablePronunciationDictionaryV1CompareRowBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryItemPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1VersionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryV1CompareRow>))]
    internal sealed partial class PronunciationDictionariesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PronunciationDictionariesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PronunciationDictionariesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PronunciationDictionariesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::FishAudio.PronunciationDictionaryItemPayloadType)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryItemPayloadType?)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1ItemType)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1ItemType?)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType?)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus?)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType)

                    || typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryItemPayloadType))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryItemPayloadTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryItemPayloadType?))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryItemPayloadTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1ItemType))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1ItemType?))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowType?))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowStatus?))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PronunciationDictionaryV1CompareRowBaseType?))
                {
                    return new global::FishAudio.JsonConverters.PronunciationDictionaryV1CompareRowBaseTypeNullableJsonConverter();
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
                    0 => new PronunciationDictionariesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}