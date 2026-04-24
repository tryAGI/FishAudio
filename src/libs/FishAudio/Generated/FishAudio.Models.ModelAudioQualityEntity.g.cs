
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelAudioQualityEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationMs { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::System.Collections.Generic.Dictionary<string, double>? Quality { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_passed")]
        public bool? QualityPassed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_reason")]
        public string? QualityReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAudioQualityEntity" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="durationMs"></param>
        /// <param name="language">
        /// Default Value: unknown
        /// </param>
        /// <param name="quality"></param>
        /// <param name="qualityPassed">
        /// Default Value: false
        /// </param>
        /// <param name="qualityReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAudioQualityEntity(
            string filename,
            double durationMs,
            string? language,
            global::System.Collections.Generic.Dictionary<string, double>? quality,
            bool? qualityPassed,
            string? qualityReason)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.DurationMs = durationMs;
            this.Language = language;
            this.Quality = quality;
            this.QualityPassed = qualityPassed;
            this.QualityReason = qualityReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAudioQualityEntity" /> class.
        /// </summary>
        public ModelAudioQualityEntity()
        {
        }
    }
}