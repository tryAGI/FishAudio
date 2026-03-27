#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchModelResponseItemInNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.PatchModelResponseItemIn?>
    {
        /// <inheritdoc />
        public override global::FishAudio.PatchModelResponseItemIn? Read(
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
                        return global::FishAudio.PatchModelResponseItemInExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.PatchModelResponseItemIn)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.PatchModelResponseItemIn?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.PatchModelResponseItemIn? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.PatchModelResponseItemInExtensions.ToValueString(value.Value));
            }
        }
    }
}
