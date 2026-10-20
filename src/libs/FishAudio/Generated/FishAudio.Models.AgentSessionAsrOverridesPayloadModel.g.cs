
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionAsrOverridesPayloadModel
    {
        /// <summary>
        ///
        /// </summary>
        Deepgram_nova3,
        /// <summary>
        ///
        /// </summary>
        Elevenlabs_scribeV2Medical,
        /// <summary>
        ///
        /// </summary>
        Elevenlabs_scribeV2Realtime,
        /// <summary>
        ///
        /// </summary>
        FishAudio_transcribeStream1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionAsrOverridesPayloadModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionAsrOverridesPayloadModel value)
        {
            return value switch
            {
                AgentSessionAsrOverridesPayloadModel.Deepgram_nova3 => "deepgram:nova-3",
                AgentSessionAsrOverridesPayloadModel.Elevenlabs_scribeV2Medical => "elevenlabs:scribe_v2_medical",
                AgentSessionAsrOverridesPayloadModel.Elevenlabs_scribeV2Realtime => "elevenlabs:scribe_v2_realtime",
                AgentSessionAsrOverridesPayloadModel.FishAudio_transcribeStream1 => "fish_audio:transcribe-stream-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionAsrOverridesPayloadModel? ToEnum(string value)
        {
            return value switch
            {
                "deepgram:nova-3" => AgentSessionAsrOverridesPayloadModel.Deepgram_nova3,
                "elevenlabs:scribe_v2_medical" => AgentSessionAsrOverridesPayloadModel.Elevenlabs_scribeV2Medical,
                "elevenlabs:scribe_v2_realtime" => AgentSessionAsrOverridesPayloadModel.Elevenlabs_scribeV2Realtime,
                "fish_audio:transcribe-stream-1" => AgentSessionAsrOverridesPayloadModel.FishAudio_transcribeStream1,
                _ => null,
            };
        }
    }
}