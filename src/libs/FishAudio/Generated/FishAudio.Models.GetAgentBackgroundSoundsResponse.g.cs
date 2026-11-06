
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAgentBackgroundSoundsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_sounds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::FishAudio.AgentBackgroundSoundEntity> BackgroundSounds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentBackgroundSoundsResponse" /> class.
        /// </summary>
        /// <param name="backgroundSounds"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentBackgroundSoundsResponse(
            global::System.Collections.Generic.IList<global::FishAudio.AgentBackgroundSoundEntity> backgroundSounds,
            int total)
        {
            this.BackgroundSounds = backgroundSounds ?? throw new global::System.ArgumentNullException(nameof(backgroundSounds));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentBackgroundSoundsResponse" /> class.
        /// </summary>
        public GetAgentBackgroundSoundsResponse()
        {
        }

    }
}