#nullable enable

namespace FishAudio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAgentTestRunsResponseChannelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::FishAudio.GetAgentTestRunsResponseChannel>
    {
        /// <inheritdoc />
        public override global::FishAudio.GetAgentTestRunsResponseChannel Read(
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
                        return global::FishAudio.GetAgentTestRunsResponseChannelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::FishAudio.GetAgentTestRunsResponseChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::FishAudio.GetAgentTestRunsResponseChannel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::FishAudio.GetAgentTestRunsResponseChannel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::FishAudio.GetAgentTestRunsResponseChannelExtensions.ToValueString(value));
        }
    }
}
