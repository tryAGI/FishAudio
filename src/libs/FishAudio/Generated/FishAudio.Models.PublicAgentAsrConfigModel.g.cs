
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: deepgram:nova-3
    /// </summary>
    public enum PublicAgentAsrConfigModel
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
        FishAudio_transcribe1ProRealtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentAsrConfigModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentAsrConfigModel value)
        {
            return value switch
            {
                PublicAgentAsrConfigModel.Deepgram_nova3 => "deepgram:nova-3",
                PublicAgentAsrConfigModel.Elevenlabs_scribeV2Medical => "elevenlabs:scribe_v2_medical",
                PublicAgentAsrConfigModel.Elevenlabs_scribeV2Realtime => "elevenlabs:scribe_v2_realtime",
                PublicAgentAsrConfigModel.FishAudio_transcribe1ProRealtime => "fish_audio:transcribe-1-pro-realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentAsrConfigModel? ToEnum(string value)
        {
            return value switch
            {
                "deepgram:nova-3" => PublicAgentAsrConfigModel.Deepgram_nova3,
                "elevenlabs:scribe_v2_medical" => PublicAgentAsrConfigModel.Elevenlabs_scribeV2Medical,
                "elevenlabs:scribe_v2_realtime" => PublicAgentAsrConfigModel.Elevenlabs_scribeV2Realtime,
                "fish_audio:transcribe-1-pro-realtime" => PublicAgentAsrConfigModel.FishAudio_transcribe1ProRealtime,
                _ => null,
            };
        }
    }
}