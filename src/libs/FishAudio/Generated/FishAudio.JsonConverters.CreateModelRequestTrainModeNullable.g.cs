#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModelRequestTrainModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.CreateModelRequestTrainMode?>
    {
        /// <inheritdoc />
        public override global::FishAudio.CreateModelRequestTrainMode? Read(
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
                        return global::FishAudio.CreateModelRequestTrainModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.CreateModelRequestTrainMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.CreateModelRequestTrainMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.CreateModelRequestTrainMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.CreateModelRequestTrainModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
