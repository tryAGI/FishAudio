
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTakedownCategory), TypeInfoPropertyName = "ModelEntityTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityPvcReleaseState), TypeInfoPropertyName = "ModelEntityPvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelQualityEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelAudioQualityEntity>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility), TypeInfoPropertyName = "PatchModelRequestVisibility2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility2), TypeInfoPropertyName = "PatchModelRequestVisibility22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility3), TypeInfoPropertyName = "PatchModelRequestVisibility32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility4), TypeInfoPropertyName = "PatchModelRequestVisibility42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelSortBy), TypeInfoPropertyName = "GetModelSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseType), TypeInfoPropertyName = "CreateModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTrainMode), TypeInfoPropertyName = "CreateModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseState), TypeInfoPropertyName = "CreateModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseVisibility), TypeInfoPropertyName = "CreateModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTakedownCategory), TypeInfoPropertyName = "CreateModelResponseTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponsePvcReleaseState), TypeInfoPropertyName = "CreateModelResponsePvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType), TypeInfoPropertyName = "GetModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode), TypeInfoPropertyName = "GetModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState), TypeInfoPropertyName = "GetModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility), TypeInfoPropertyName = "GetModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTakedownCategory), TypeInfoPropertyName = "GetModelResponseTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponsePvcReleaseState), TypeInfoPropertyName = "GetModelResponsePvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityType?), TypeInfoPropertyName = "NullableModelEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTrainMode?), TypeInfoPropertyName = "NullableModelEntityTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityState?), TypeInfoPropertyName = "NullableModelEntityState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityVisibility?), TypeInfoPropertyName = "NullableModelEntityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTakedownCategory?), TypeInfoPropertyName = "NullableModelEntityTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityPvcReleaseState?), TypeInfoPropertyName = "NullableModelEntityPvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>?), TypeInfoPropertyName = "NullableAnyOfIListByteArrayByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?), TypeInfoPropertyName = "NullableAnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility2?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility3?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility4?), TypeInfoPropertyName = "NullableCreateModelRequestVisibility42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility?), TypeInfoPropertyName = "NullablePatchModelRequestVisibility2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility2?), TypeInfoPropertyName = "NullablePatchModelRequestVisibility22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility3?), TypeInfoPropertyName = "NullablePatchModelRequestVisibility32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility4?), TypeInfoPropertyName = "NullablePatchModelRequestVisibility42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelSortBy?), TypeInfoPropertyName = "NullableGetModelSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseType?), TypeInfoPropertyName = "NullableCreateModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTrainMode?), TypeInfoPropertyName = "NullableCreateModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseState?), TypeInfoPropertyName = "NullableCreateModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseVisibility?), TypeInfoPropertyName = "NullableCreateModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTakedownCategory?), TypeInfoPropertyName = "NullableCreateModelResponseTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponsePvcReleaseState?), TypeInfoPropertyName = "NullableCreateModelResponsePvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType?), TypeInfoPropertyName = "NullableGetModelResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode?), TypeInfoPropertyName = "NullableGetModelResponseTrainMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState?), TypeInfoPropertyName = "NullableGetModelResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility?), TypeInfoPropertyName = "NullableGetModelResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTakedownCategory?), TypeInfoPropertyName = "NullableGetModelResponseTakedownCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponsePvcReleaseState?), TypeInfoPropertyName = "NullableGetModelResponsePvcReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.SampleEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ModelAudioQualityEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ModelEntity>))]
    internal sealed partial class ModelSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::FishAudio.ModelEntityType)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityType?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityState)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityState?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityVisibility)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityVisibility?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory?)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState)

                    || typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility2?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility3?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4)

                    || typeToConvert == typeof(global::FishAudio.CreateModelRequestVisibility4?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility3)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility3?)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4)

                    || typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4?)

                    || typeToConvert == typeof(global::FishAudio.GetModelSortBy)

                    || typeToConvert == typeof(global::FishAudio.GetModelSortBy?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseType)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseType?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseState)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseState?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseVisibility?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory?)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState)

                    || typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseType)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseType?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTrainMode?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseState)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseState?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseVisibility?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory?)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState)

                    || typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTakedownCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityTakedownCategory?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityTakedownCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityPvcReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.ModelEntityPvcReleaseState?))
                {
                    return new global::FishAudio.JsonConverters.ModelEntityPvcReleaseStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility2JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility2?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility3))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility3JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility3?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility4JsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.PatchModelRequestVisibility4?))
                {
                    return new global::FishAudio.JsonConverters.PatchModelRequestVisibility4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelSortBy))
                {
                    return new global::FishAudio.JsonConverters.GetModelSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelSortBy?))
                {
                    return new global::FishAudio.JsonConverters.GetModelSortByNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTakedownCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponseTakedownCategory?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponseTakedownCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.CreateModelResponsePvcReleaseState?))
                {
                    return new global::FishAudio.JsonConverters.CreateModelResponsePvcReleaseStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTakedownCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponseTakedownCategory?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponseTakedownCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponsePvcReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::FishAudio.GetModelResponsePvcReleaseState?))
                {
                    return new global::FishAudio.JsonConverters.GetModelResponsePvcReleaseStateNullableJsonConverter();
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
                    0 => new ModelSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}