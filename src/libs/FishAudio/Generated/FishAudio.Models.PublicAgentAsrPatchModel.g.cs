
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentAsrPatchModel
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
    public static class PublicAgentAsrPatchModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentAsrPatchModel value)
        {
            return value switch
            {
                PublicAgentAsrPatchModel.Deepgram_nova3 => "deepgram:nova-3",
                PublicAgentAsrPatchModel.Elevenlabs_scribeV2Medical => "elevenlabs:scribe_v2_medical",
                PublicAgentAsrPatchModel.Elevenlabs_scribeV2Realtime => "elevenlabs:scribe_v2_realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentAsrPatchModel? ToEnum(string value)
        {
            return value switch
            {
                "deepgram:nova-3" => PublicAgentAsrPatchModel.Deepgram_nova3,
                "elevenlabs:scribe_v2_medical" => PublicAgentAsrPatchModel.Elevenlabs_scribeV2Medical,
                "elevenlabs:scribe_v2_realtime" => PublicAgentAsrPatchModel.Elevenlabs_scribeV2Realtime,
                _ => null,
            };
        }
    }
}