#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAgentPhoneNumbersResponseCallerIdSyncStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus?>
    {
        /// <inheritdoc />
        public override global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? Read(
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
                        return global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::FishAudio.CreateAgentPhoneNumbersResponseCallerIdSyncStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
