#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSessionEngineFallbackReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.AgentSessionEngineFallbackReason?>
    {
        /// <inheritdoc />
        public override global::FishAudio.AgentSessionEngineFallbackReason? Read(
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
                        return global::FishAudio.AgentSessionEngineFallbackReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.AgentSessionEngineFallbackReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.AgentSessionEngineFallbackReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.AgentSessionEngineFallbackReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.AgentSessionEngineFallbackReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
