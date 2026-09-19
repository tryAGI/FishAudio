#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSessionSummaryEndReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.AgentSessionSummaryEndReason?>
    {
        /// <inheritdoc />
        public override global::FishAudio.AgentSessionSummaryEndReason? Read(
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
                        return global::FishAudio.AgentSessionSummaryEndReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.AgentSessionSummaryEndReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.AgentSessionSummaryEndReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.AgentSessionSummaryEndReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.AgentSessionSummaryEndReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
