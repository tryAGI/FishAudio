
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: deepgram:nova-3
    /// </summary>
    public enum AgentAsrConfigModel
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAsrConfigModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAsrConfigModel value)
        {
            return value switch
            {
                AgentAsrConfigModel.Deepgram_nova3 => "deepgram:nova-3",
                AgentAsrConfigModel.Elevenlabs_scribeV2Medical => "elevenlabs:scribe_v2_medical",
                AgentAsrConfigModel.Elevenlabs_scribeV2Realtime => "elevenlabs:scribe_v2_realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAsrConfigModel? ToEnum(string value)
        {
            return value switch
            {
                "deepgram:nova-3" => AgentAsrConfigModel.Deepgram_nova3,
                "elevenlabs:scribe_v2_medical" => AgentAsrConfigModel.Elevenlabs_scribeV2Medical,
                "elevenlabs:scribe_v2_realtime" => AgentAsrConfigModel.Elevenlabs_scribeV2Realtime,
                _ => null,
            };
        }
    }
}