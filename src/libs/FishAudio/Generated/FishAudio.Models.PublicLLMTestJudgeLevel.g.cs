
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicLLMTestJudgeLevel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicLLMTestJudgeLevelLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.PublicLLMTestJudgeLevelLevel Level { get; set; }

        /// <summary>
        /// The level the model judges at when a judge names none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTestJudgeLevel" /> class.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="default">
        /// The level the model judges at when a judge names none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMTestJudgeLevel(
            global::FishAudio.PublicLLMTestJudgeLevelLevel level,
            bool @default)
        {
            this.Level = level;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTestJudgeLevel" /> class.
        /// </summary>
        public PublicLLMTestJudgeLevel()
        {
        }

    }
}