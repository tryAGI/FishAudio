
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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressive")]
        public bool? Expressive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

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
        /// <param name="expressive">
        /// Default Value: false
        /// </param>
        /// <param name="keyterms"></param>
        /// <param name="speed">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoiceConfig(
            string? voiceId,
            global::FishAudio.AgentVoiceConfigSpeakingLanguage? speakingLanguage,
            bool? expressive,
            global::System.Collections.Generic.IList<string>? keyterms,
            double? speed)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
            this.Expressive = expressive;
            this.Keyterms = keyterms;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceConfig" /> class.
        /// </summary>
        public AgentVoiceConfig()
        {
        }

    }
}