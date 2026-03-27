
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
            typeof(global::FishAudio.JsonConverters.TTSRequestFormatJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestFormatNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestLatencyJsonConverter),

            typeof(global::FishAudio.JsonConverters.TTSRequestLatencyNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.ModelEntityVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility2JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestVisibility2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestType2JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestType2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTrainMode2JsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelRequestTrainMode2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility2JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility4JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility4NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility6JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility6NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility8JsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelRequestVisibility8NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsModelJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsModelNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelSortByJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelSortByNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateTtsResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAsrResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateAsrResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetWalletPackageResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetWalletPackageResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetWalletApiCreditResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetWalletApiCreditResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.CreateModelResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTypeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTypeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTrainModeJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseTrainModeNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseStateJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseStateNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseVisibilityJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseVisibilityNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseItemIn2JsonConverter),

            typeof(global::FishAudio.JsonConverters.GetModelResponseItemIn2NullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.PatchModelResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.DeleteModelResponseItemInJsonConverter),

            typeof(global::FishAudio.JsonConverters.DeleteModelResponseItemInNullableJsonConverter),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>),

            typeof(global::FishAudio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ProsodyControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ReferenceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::FishAudio.ReferenceAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.TTSRequestLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ASRSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AuthorEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityTrainMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.SampleEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.SampleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.ModelEntityVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestTrainMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestVisibility2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelRequestTrainMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelRequestVisibility8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelSortBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.CreateTtsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateTtsResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ASRSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.CreateAsrResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateAsrResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.GetWalletPackageResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletPackageResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.GetWalletApiCreditResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetWalletApiCreditResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.ModelEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.GetModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseTrainMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.CreateModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.CreateModelResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseTrainMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.GetModelResponseItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.GetModelResponseItemIn2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.PatchModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.PatchModelResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::FishAudio.DeleteModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.DeleteModelResponseItemIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::FishAudio.ReferenceAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.SampleEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<byte[]>, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::FishAudio.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.CreateTtsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ASRSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.CreateAsrResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetWalletPackageResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetWalletApiCreditResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.ModelEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.CreateModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.GetModelResponseItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.PatchModelResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::FishAudio.DeleteModelResponseItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}