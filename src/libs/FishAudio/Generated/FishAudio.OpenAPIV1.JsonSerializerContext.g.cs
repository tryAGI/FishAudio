
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ASRSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PronunciationDictionaryRef))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>, object>), TypeInfoPropertyName = "AnyOfIListPronunciationDictionaryRefIListPronunciationDictionaryInlineObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat), TypeInfoPropertyName = "TTSStreamWithTimestampRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency), TypeInfoPropertyName = "TTSStreamWithTimestampRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSTimestampAlignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.TTSTimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSTimestampSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSLiveErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSLiveFinishEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSLiveFinishEventReason), TypeInfoPropertyName = "TTSLiveFinishEventReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSLiveWithTimestampAudioEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.VoiceDesignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.VoiceDesignCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrModel), TypeInfoPropertyName = "CreateAsrModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsModel), TypeInfoPropertyName = "CreateTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampModel), TypeInfoPropertyName = "CreateTtsStreamWithTimestampModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampModel), TypeInfoPropertyName = "GetTtsLiveWithTimestampModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponse), TypeInfoPropertyName = "GetTtsLiveWithTimestampResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent), TypeInfoPropertyName = "GetTtsLiveWithTimestampResponseDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.VoiceDesignCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateVoiceDesignResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>?), TypeInfoPropertyName = "NullableAnyOfIListReferenceAudioIListIListReferenceAudioObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestFormat?), TypeInfoPropertyName = "NullableTTSRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestLatency?), TypeInfoPropertyName = "NullableTTSRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>, object>?), TypeInfoPropertyName = "NullableAnyOfIListPronunciationDictionaryRefIListPronunciationDictionaryInlineObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat?), TypeInfoPropertyName = "NullableTTSStreamWithTimestampRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency?), TypeInfoPropertyName = "NullableTTSStreamWithTimestampRequestLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSLiveFinishEventReason?), TypeInfoPropertyName = "NullableTTSLiveFinishEventReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrModel?), TypeInfoPropertyName = "NullableCreateAsrModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsModel?), TypeInfoPropertyName = "NullableCreateTtsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsStreamWithTimestampModel?), TypeInfoPropertyName = "NullableCreateTtsStreamWithTimestampModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampModel?), TypeInfoPropertyName = "NullableGetTtsLiveWithTimestampModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponse?), TypeInfoPropertyName = "NullableGetTtsLiveWithTimestampResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent?), TypeInfoPropertyName = "NullableGetTtsLiveWithTimestampResponseDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PronunciationDictionaryInline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.TTSTimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ASRSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.VoiceDesignCandidate>))]
    internal sealed partial class OpenAPIV1SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAPIV1SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OpenAPIV1SourceGenerationContext Default { get; } = new(DefaultOptions);

        private OpenAPIV1SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::FishAudio.JsonConverters.GetTtsLiveWithTimestampResponseJsonConverter());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<bool?, double?, string, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryRef>, global::System.Collections.Generic.IList<global::FishAudio.PronunciationDictionaryInline>, object>());
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
                    typeToConvert == typeof(global::FishAudio.TTSRequestFormat)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestFormat?)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestLatency)

                    || typeToConvert == typeof(global::FishAudio.TTSRequestLatency?)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestFormat?)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency)

                    || typeToConvert == typeof(global::FishAudio.TTSStreamWithTimestampRequestLatency?)

                    || typeToConvert == typeof(global::FishAudio.TTSLiveFinishEventReason)

                    || typeToConvert == typeof(global::FishAudio.TTSLiveFinishEventReason?)

                    || typeToConvert == typeof(global::FishAudio.CreateAsrModel)

                    || typeToConvert == typeof(global::FishAudio.CreateAsrModel?)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsModel)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsModel?)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel)

                    || typeToConvert == typeof(global::FishAudio.CreateTtsStreamWithTimestampModel?)

                    || typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampModel)

                    || typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampModel?)

                    || typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent)

                    || typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::FishAudio.TTSLiveFinishEventReason))
                {
                    return new global::FishAudio.JsonConverters.TTSLiveFinishEventReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.TTSLiveFinishEventReason?))
                {
                    return new global::FishAudio.JsonConverters.TTSLiveFinishEventReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAsrModel))
                {
                    return new global::FishAudio.JsonConverters.CreateAsrModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateAsrModel?))
                {
                    return new global::FishAudio.JsonConverters.CreateAsrModelNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampModel))
                {
                    return new global::FishAudio.JsonConverters.GetTtsLiveWithTimestampModelJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampModel?))
                {
                    return new global::FishAudio.JsonConverters.GetTtsLiveWithTimestampModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent))
                {
                    return new global::FishAudio.JsonConverters.GetTtsLiveWithTimestampResponseDiscriminatorEventJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent?))
                {
                    return new global::FishAudio.JsonConverters.GetTtsLiveWithTimestampResponseDiscriminatorEventNullableJsonConverter();
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
                    0 => new OpenAPIV1SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}