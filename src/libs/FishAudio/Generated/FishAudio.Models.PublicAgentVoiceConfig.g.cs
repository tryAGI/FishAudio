
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The voice section as the public API reads it: without the console-only<br/>
    /// sentence buffering switch and speech engine preview.
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
        /// How the agent's voice sounds on web calls (the console test call, the widget, the SDK). none (default): the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentVoiceConfigEffectJsonConverter))]
        public global::FishAudio.PublicAgentVoiceConfigEffect? Effect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_ids")]
        public global::System.Collections.Generic.IList<string>? PronunciationDictionaryIds { get; set; }

        /// <summary>
        /// A looping ambience the worker mixes under the agent's voice. volume is the ambience's gain relative to the agent's voice, 0–1 (default 0.15). custom_asset_id names an uploaded clip (POST /agent/background-sounds) and is required with preset "custom", refused otherwise. Replaces the whole object; null resets to off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_sound")]
        public global::FishAudio.AgentBackgroundSoundConfig? BackgroundSound { get; set; }

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
        /// <param name="effect">
        /// How the agent's voice sounds on web calls (the console test call, the widget, the SDK). none (default): the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="pronunciationDictionaryIds"></param>
        /// <param name="backgroundSound">
        /// A looping ambience the worker mixes under the agent's voice. volume is the ambience's gain relative to the agent's voice, 0–1 (default 0.15). custom_asset_id names an uploaded clip (POST /agent/background-sounds) and is required with preset "custom", refused otherwise. Replaces the whole object; null resets to off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentVoiceConfig(
            string? voiceId,
            global::FishAudio.PublicAgentVoiceConfigSpeakingLanguage? speakingLanguage,
            bool? expressive,
            double? speed,
            global::FishAudio.PublicAgentVoiceConfigTtsModel? ttsModel,
            global::FishAudio.PublicAgentVoiceConfigEffect? effect,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryIds,
            global::FishAudio.AgentBackgroundSoundConfig? backgroundSound)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
            this.Expressive = expressive;
            this.Speed = speed;
            this.TtsModel = ttsModel;
            this.Effect = effect;
            this.PronunciationDictionaryIds = pronunciationDictionaryIds;
            this.BackgroundSound = backgroundSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoiceConfig" /> class.
        /// </summary>
        public PublicAgentVoiceConfig()
        {
        }

    }
}