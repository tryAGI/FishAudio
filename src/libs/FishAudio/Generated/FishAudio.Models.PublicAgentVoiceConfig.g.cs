
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The voice section as the public API reads it: without the console-only<br/>
    /// sentence buffering switch.
    /// </summary>
    public sealed partial class PublicAgentVoiceConfig
    {
        /// <summary>
        /// Default Value: b347db033a6549378b48d00acb0d06cd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentVoiceConfigSpeakingLanguageJsonConverter))]
        public global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? SpeakingLanguage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressive")]
        public bool? Expressive { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Default Value: s2.1-pro
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentVoiceConfigTtsModelJsonConverter))]
        public global::FishAudio.PublicAgentVoiceConfigTtsModel? TtsModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_ids")]
        public global::System.Collections.Generic.IList<string>? PronunciationDictionaryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Default Value: b347db033a6549378b48d00acb0d06cd
        /// </param>
        /// <param name="speakingLanguage">
        /// Default Value: en
        /// </param>
        /// <param name="expressive">
        /// Default Value: false
        /// </param>
        /// <param name="speed">
        /// Default Value: 1
        /// </param>
        /// <param name="ttsModel">
        /// Default Value: s2.1-pro
        /// </param>
        /// <param name="pronunciationDictionaryIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentVoiceConfig(
            string? voiceId,
            global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? speakingLanguage,
            bool? expressive,
            double? speed,
            global::FishAudio.PublicAgentVoiceConfigTtsModel? ttsModel,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryIds)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
            this.Expressive = expressive;
            this.Speed = speed;
            this.TtsModel = ttsModel;
            this.PronunciationDictionaryIds = pronunciationDictionaryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoiceConfig" /> class.
        /// </summary>
        public PublicAgentVoiceConfig()
        {
        }

    }
}