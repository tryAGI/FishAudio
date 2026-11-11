
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The voice section as the public API reads it: without the console-only<br/>
    /// sentence buffering switch and live-3 playout.
    /// </summary>
    public sealed partial class PublicAgentVoiceConfig
    {
        /// <summary>
        /// Default Value: 9a9cf47702da476aa4629e2506d4a857
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
        /// Speech engine. live3 (the default for new agents) puts the Fish full-duplex speech model on the call: it listens while it speaks and takes turns on its own. English only: sessions in another language run on fish_tts. fish_tts speaks the model's text through Fish TTS in the agent's voice, and is what agents from before the engine existed run. asr.model reads fish_audio:transcribe-stream-1 while the engine is live3, and switching to live3 turns asr.multilingual on unless the same patch sets it. An agent still on the default voice_id also starts voice.live3_voice on Clara at the switch, when none is stored and the same patch sets neither. An agent with a voice of its own keeps speaking it.<br/>
        /// Default Value: fish_tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentVoiceConfigEngineJsonConverter))]
        public global::FishAudio.PublicAgentVoiceConfigEngine? Engine { get; set; }

        /// <summary>
        /// live3 only. The situation the speech model speaks in: P2 (phone support), DT (drive-thru) or AIR (airline). Empty: the default. Ignored on fish_tts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live3_prompt")]
        public string? Live3Prompt { get; set; }

        /// <summary>
        /// live3 only. One of the speech model's own voices by name (Clara, Nora, Owen, Marco, Milo, Jonah, Harper, Patricia, and for the DT situation Maddie, Ethan, Tyler, Brianna). New agents start on Clara. Empty: the agent's voice_id when the engine can use it, else Clara. Setting voice_id clears it unless the same patch sets it too. Ignored on fish_tts, which speaks voice_id.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live3_voice")]
        public string? Live3Voice { get; set; }

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
        /// Default Value: 9a9cf47702da476aa4629e2506d4a857
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
        /// <param name="engine">
        /// Speech engine. live3 (the default for new agents) puts the Fish full-duplex speech model on the call: it listens while it speaks and takes turns on its own. English only: sessions in another language run on fish_tts. fish_tts speaks the model's text through Fish TTS in the agent's voice, and is what agents from before the engine existed run. asr.model reads fish_audio:transcribe-stream-1 while the engine is live3, and switching to live3 turns asr.multilingual on unless the same patch sets it. An agent still on the default voice_id also starts voice.live3_voice on Clara at the switch, when none is stored and the same patch sets neither. An agent with a voice of its own keeps speaking it.<br/>
        /// Default Value: fish_tts
        /// </param>
        /// <param name="live3Prompt">
        /// live3 only. The situation the speech model speaks in: P2 (phone support), DT (drive-thru) or AIR (airline). Empty: the default. Ignored on fish_tts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="live3Voice">
        /// live3 only. One of the speech model's own voices by name (Clara, Nora, Owen, Marco, Milo, Jonah, Harper, Patricia, and for the DT situation Maddie, Ethan, Tyler, Brianna). New agents start on Clara. Empty: the agent's voice_id when the engine can use it, else Clara. Setting voice_id clears it unless the same patch sets it too. Ignored on fish_tts, which speaks voice_id.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
            global::FishAudio.PublicAgentVoiceConfigEngine? engine,
            string? live3Prompt,
            string? live3Voice,
            global::FishAudio.PublicAgentVoiceConfigEffect? effect,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryIds,
            global::FishAudio.AgentBackgroundSoundConfig? backgroundSound)
        {
            this.VoiceId = voiceId;
            this.SpeakingLanguage = speakingLanguage;
            this.Expressive = expressive;
            this.Speed = speed;
            this.TtsModel = ttsModel;
            this.Engine = engine;
            this.Live3Prompt = live3Prompt;
            this.Live3Voice = live3Voice;
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