
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVoiceConfig
    {
        /// <summary>
        /// Default Value: 4501d82f5de3467ebf4d7ef095a2deee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentVoiceConfigSpeakingLanguageJsonConverter))]
        public global::FishAudio.AgentVoiceConfigSpeakingLanguage? SpeakingLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Default Value: 4501d82f5de3467ebf4d7ef095a2deee
        /// </param>
        /// <param name="speakingLanguage">
        /// Default Value: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoiceConfig(
            string? voiceId,
            global::FishAudio.AgentVoiceConfigSpeakingLanguage? speakingLanguage)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceConfig" /> class.
        /// </summary>
        public AgentVoiceConfig()
        {
        }

    }
}