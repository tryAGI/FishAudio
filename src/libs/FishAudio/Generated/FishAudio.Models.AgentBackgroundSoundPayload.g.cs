
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Write shape: replaces voice.background_sound as a whole (AgentVoicePatch<br/>
    /// null resets to the default). Strict, unlike the read model: a bad pairing<br/>
    /// 422s instead of silently falling back.
    /// </summary>
    public sealed partial class AgentBackgroundSoundPayload
    {
        /// <summary>
        /// Default Value: off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentBackgroundSoundPayloadPresetJsonConverter))]
        public global::FishAudio.AgentBackgroundSoundPayloadPreset? Preset { get; set; }

        /// <summary>
        /// Default Value: 0.15F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_asset_id")]
        public string? CustomAssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackgroundSoundPayload" /> class.
        /// </summary>
        /// <param name="preset">
        /// Default Value: off
        /// </param>
        /// <param name="volume">
        /// Default Value: 0.15F
        /// </param>
        /// <param name="customAssetId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBackgroundSoundPayload(
            global::FishAudio.AgentBackgroundSoundPayloadPreset? preset,
            double? volume,
            string? customAssetId)
        {
            this.Preset = preset;
            this.Volume = volume;
            this.CustomAssetId = customAssetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackgroundSoundPayload" /> class.
        /// </summary>
        public AgentBackgroundSoundPayload()
        {
        }

    }
}