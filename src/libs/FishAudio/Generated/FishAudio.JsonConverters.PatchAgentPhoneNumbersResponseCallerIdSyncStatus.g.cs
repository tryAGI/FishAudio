#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchAgentPhoneNumbersResponseCallerIdSyncStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus>
    {
        /// <inheritdoc />
        public override global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus Read(
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
                        return global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::FishAudio.PatchAgentPhoneNumbersResponseCallerIdSyncStatusExtensions.ToValueString(value));
        }
    }
}
