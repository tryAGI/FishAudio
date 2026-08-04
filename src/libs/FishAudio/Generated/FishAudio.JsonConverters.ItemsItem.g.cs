#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.ItemsItem>
    {
        /// <inheritdoc />
        public override global::FishAudio.ItemsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.GetAgentSessionsResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.GetAgentSessionsResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.GetAgentSessionsResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::FishAudio.AgentSessionMessageItem? message = default;
            if (discriminator?.Type == global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionMessageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.AgentSessionMessageItem)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::FishAudio.AgentSessionToolCallItem? toolCall = default;
            if (discriminator?.Type == global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionToolCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.AgentSessionToolCallItem)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::FishAudio.AgentSessionToolResultItem? toolResult = default;
            if (discriminator?.Type == global::FishAudio.GetAgentSessionsResponseItemDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionToolResultItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionToolResultItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::FishAudio.AgentSessionToolResultItem)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::FishAudio.ItemsItem(
                discriminator?.Type,
                message,

                toolCall,

                toolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.ItemsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.AgentSessionMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.AgentSessionToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall!, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::FishAudio.AgentSessionToolResultItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::FishAudio.AgentSessionToolResultItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::FishAudio.AgentSessionToolResultItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult!, typeInfo);
            }
        }
    }
}