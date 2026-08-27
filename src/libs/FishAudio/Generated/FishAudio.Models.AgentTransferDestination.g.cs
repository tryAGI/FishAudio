
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTransferDestination
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Default Value: cold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationModeJsonConverter))]
        public global::FishAudio.AgentTransferDestinationMode? Mode { get; set; }

        /// <summary>
        /// Default Value: confirm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm_connect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentTransferDestinationWarmConnectJsonConverter))]
        public global::FishAudio.AgentTransferDestinationWarmConnect? WarmConnect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestination" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="type">
        /// Default Value: phone
        /// </param>
        /// <param name="label"></param>
        /// <param name="mode">
        /// Default Value: cold
        /// </param>
        /// <param name="warmConnect">
        /// Default Value: confirm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferDestination(
            string phoneNumber,
            string? type,
            string? label,
            global::FishAudio.AgentTransferDestinationMode? mode,
            global::FishAudio.AgentTransferDestinationWarmConnect? warmConnect)
        {
            this.Type = type;
            this.Label = label;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Mode = mode;
            this.WarmConnect = warmConnect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferDestination" /> class.
        /// </summary>
        public AgentTransferDestination()
        {
        }

    }
}