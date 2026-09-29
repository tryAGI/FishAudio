#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentTestMessagePayloadRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.AgentTestMessagePayloadRole>
    {
        /// <inheritdoc />
        public override global::FishAudio.AgentTestMessagePayloadRole Read(
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
                        return global::FishAudio.AgentTestMessagePayloadRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.AgentTestMessagePayloadRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.AgentTestMessagePayloadRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.AgentTestMessagePayloadRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::FishAudio.AgentTestMessagePayloadRoleExtensions.ToValueString(value));
        }
    }
}
