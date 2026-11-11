
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolPreToolSpeech
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentToolPreToolSpeechModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentToolPreToolSpeechMode Mode { get; set; }

        /// <summary>
        /// What to say. Required, and only used, when `mode` is `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolPreToolSpeech" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="message">
        /// What to say. Required, and only used, when `mode` is `static`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolPreToolSpeech(
            global::FishAudio.AgentToolPreToolSpeechMode mode,
            string? message)
        {
            this.Mode = mode;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolPreToolSpeech" /> class.
        /// </summary>
        public AgentToolPreToolSpeech()
        {
        }

    }
}