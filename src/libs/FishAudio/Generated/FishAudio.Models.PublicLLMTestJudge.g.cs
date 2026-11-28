
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicLLMTestJudge
    {
        /// <summary>
        /// The reasoning levels a judge of this model may name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_levels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.PublicLLMTestJudgeLevel> ReasoningLevels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTestJudge" /> class.
        /// </summary>
        /// <param name="reasoningLevels">
        /// The reasoning levels a judge of this model may name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicLLMTestJudge(
            global::System.Collections.Generic.IList<global::FishAudio.PublicLLMTestJudgeLevel> reasoningLevels)
        {
            this.ReasoningLevels = reasoningLevels ?? throw new global::System.ArgumentNullException(nameof(reasoningLevels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicLLMTestJudge" /> class.
        /// </summary>
        public PublicLLMTestJudge()
        {
        }

    }
}