#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAgentToolsResponseToolTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.GetAgentToolsResponseToolType?>
    {
        /// <inheritdoc />
        public override global::FishAudio.GetAgentToolsResponseToolType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::FishAudio.GetAgentToolsResponseToolTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.GetAgentToolsResponseToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.GetAgentToolsResponseToolType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.GetAgentToolsResponseToolType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.GetAgentToolsResponseToolTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
