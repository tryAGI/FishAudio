#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDictionaryV1ItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.PronunciationDictionaryV1ItemType?>
    {
        /// <inheritdoc />
        public override global::FishAudio.PronunciationDictionaryV1ItemType? Read(
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
                        return global::FishAudio.PronunciationDictionaryV1ItemTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.PronunciationDictionaryV1ItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.PronunciationDictionaryV1ItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.PronunciationDictionaryV1ItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.PronunciationDictionaryV1ItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
