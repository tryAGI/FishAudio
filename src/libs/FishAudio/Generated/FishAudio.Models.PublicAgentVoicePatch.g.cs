
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicAgentVoicePatch
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_language")]
        public global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? SpeakingLanguage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressive")]
        public bool? Expressive { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_model")]
        public global::FishAudio.PublicAgentVoicePatchTtsModel? TtsModel { get; set; }

        /// <summary>
        /// How the agent's voice sounds on web calls (the console test call, the widget, the SDK). none (default): the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        public global::FishAudio.PublicAgentVoicePatchEffect? Effect { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_ids")]
        public global::System.Collections.Generic.IList<string>? PronunciationDictionaryIds { get; set; }

        /// <summary>
        /// A looping ambience the worker mixes under the agent's voice. volume is the ambience's gain relative to the agent's voice, 0–1 (default 0.15). custom_asset_id names an uploaded clip (POST /agent/background-sounds) and is required with preset "custom", refused otherwise. Replaces the whole object; null resets to off.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_sound")]
        public global::FishAudio.AgentBackgroundSoundPayload? BackgroundSound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentVoicePatch" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speakingLanguage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expressive">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speed">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ttsModel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="effect">
        /// How the agent's voice sounds on web calls (the console test call, the widget, the SDK). none (default): the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pronunciationDictionaryIds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="backgroundSound">
        /// A looping ambience the worker mixes under the agent's voice. volume is the ambience's gain relative to the agent's voice, 0–1 (default 0.15). custom_asset_id names an uploaded clip (POST /agent/background-sounds) and is required with preset "custom", refused otherwise. Replaces the whole object; null resets to off.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentVoicePatch(
            string? voiceId,
            global::FishAudio.PublicAgentVoicePatchSpeakingLanguage? speakingLanguage,
            bool? expressive,
            double? speed,
            global::FishAudio.PublicAgentVoicePatchTtsModel? ttsModel,
            global::FishAudio.PublicAgentVoicePatchEffect? effect,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryIds,
            global::FishAudio.AgentBackgroundSoundPayload? backgroundSound)
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
        /// Initializes a new instance of the <see cref="PublicAgentVoicePatch" /> class.
        /// </summary>
        public PublicAgentVoicePatch()
        {
        }

    }
}