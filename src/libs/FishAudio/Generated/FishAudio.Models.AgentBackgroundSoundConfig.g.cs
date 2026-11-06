
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Stored/read shape. Lenient like the rest of voice: a broken shape (a<br/>
    /// pairing a later write could never produce) reads as off rather than<br/>
    /// raising, so a row never fails to load. An asset later soft-deleted is not<br/>
    /// a broken shape — the session build drops it and logs a warning, this<br/>
    /// config keeps naming it.
    /// </summary>
    public sealed partial class AgentBackgroundSoundConfig
    {
        /// <summary>
        /// Default Value: off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentBackgroundSoundConfigPresetJsonConverter))]
        public global::FishAudio.AgentBackgroundSoundConfigPreset? Preset { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentBackgroundSoundConfig" /> class.
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
        public AgentBackgroundSoundConfig(
            global::FishAudio.AgentBackgroundSoundConfigPreset? preset,
            double? volume,
            string? customAssetId)
        {
            this.Preset = preset;
            this.Volume = volume;
            this.CustomAssetId = customAssetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackgroundSoundConfig" /> class.
        /// </summary>
        public AgentBackgroundSoundConfig()
        {
        }

    }
}