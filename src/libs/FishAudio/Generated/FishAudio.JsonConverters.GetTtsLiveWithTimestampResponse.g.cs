#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public class GetTtsLiveWithTimestampResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.GetTtsLiveWithTimestampResponse>
    {
        /// <inheritdoc />
        public override global::FishAudio.GetTtsLiveWithTimestampResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::FishAudio.TTSLiveWithTimestampAudioEvent? audio = default;
            if (discriminator?.Event == global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveWithTimestampAudioEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveWithTimestampAudioEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.TTSLiveWithTimestampAudioEvent)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::FishAudio.TTSLiveFinishEvent? finish = default;
            if (discriminator?.Event == global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent.Finish)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveFinishEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveFinishEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.TTSLiveFinishEvent)}");
                finish = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::FishAudio.TTSLiveErrorEvent? error = default;
            if (discriminator?.Event == global::FishAudio.GetTtsLiveWithTimestampResponseDiscriminatorEvent.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.TTSLiveErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::FishAudio.GetTtsLiveWithTimestampResponse(
                discriminator?.Event,
                audio,

                finish,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.GetTtsLiveWithTimestampResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveWithTimestampAudioEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveWithTimestampAudioEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.TTSLiveWithTimestampAudioEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsFinish)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveFinishEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveFinishEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.TTSLiveFinishEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Finish!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.TTSLiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.TTSLiveErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.TTSLiveErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}