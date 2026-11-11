
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Speech engine. live3 (the default for new agents) puts the Fish full-duplex speech model on the call: it listens while it speaks and takes turns on its own. English only: sessions in another language run on fish_tts. fish_tts speaks the model's text through Fish TTS in the agent's voice, and is what agents from before the engine existed run. asr.model reads fish_audio:transcribe-stream-1 while the engine is live3, and switching to live3 turns asr.multilingual on unless the same patch sets it. An agent still on the default voice_id also starts voice.live3_voice on Clara at the switch, when none is stored and the same patch sets neither. An agent with a voice of its own keeps speaking it.<br/>
    /// Default Value: fish_tts
    /// </summary>
    public enum PublicAgentVoiceConfigEngine
    {
        /// <summary>
        /// it listens while it speaks and takes turns on its own. English only: sessions in another language run on fish_tts. fish_tts speaks the model's text through Fish TTS in the agent's voice, and is what agents from before the engine existed run. asr.model reads fish_audio:transcribe-stream-1 while the engine is live3, and switching to live3 turns asr.multilingual on unless the same patch sets it. An agent still on the default voice_id also starts voice.live3_voice on Clara at the switch, when none is stored and the same patch sets neither. An agent with a voice of its own keeps speaking it.
        /// </summary>
        FishTts,
        /// <summary>
        /// it listens while it speaks and takes turns on its own. English only: sessions in another language run on fish_tts. fish_tts speaks the model's text through Fish TTS in the agent's voice, and is what agents from before the engine existed run. asr.model reads fish_audio:transcribe-stream-1 while the engine is live3, and switching to live3 turns asr.multilingual on unless the same patch sets it. An agent still on the default voice_id also starts voice.live3_voice on Clara at the switch, when none is stored and the same patch sets neither. An agent with a voice of its own keeps speaking it.
        /// </summary>
        Live3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVoiceConfigEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoiceConfigEngine value)
        {
            return value switch
            {
                PublicAgentVoiceConfigEngine.FishTts => "fish_tts",
                PublicAgentVoiceConfigEngine.Live3 => "live3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoiceConfigEngine? ToEnum(string value)
        {
            return value switch
            {
                "fish_tts" => PublicAgentVoiceConfigEngine.FishTts,
                "live3" => PublicAgentVoiceConfigEngine.Live3,
                _ => null,
            };
        }
    }
}