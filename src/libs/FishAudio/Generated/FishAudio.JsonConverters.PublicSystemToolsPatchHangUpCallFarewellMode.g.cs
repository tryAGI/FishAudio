#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicSystemToolsPatchHangUpCallFarewellModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode>
    {
        /// <inheritdoc />
        public override global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode Read(
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
                        return global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::FishAudio.PublicSystemToolsPatchHangUpCallFarewellModeExtensions.ToValueString(value));
        }
    }
}
