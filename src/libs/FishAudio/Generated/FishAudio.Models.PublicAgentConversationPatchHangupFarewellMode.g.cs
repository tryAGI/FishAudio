
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentConversationPatchHangupFarewellMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Generated,
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentConversationPatchHangupFarewellModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentConversationPatchHangupFarewellMode value)
        {
            return value switch
            {
                PublicAgentConversationPatchHangupFarewellMode.Fixed => "fixed",
                PublicAgentConversationPatchHangupFarewellMode.Generated => "generated",
                PublicAgentConversationPatchHangupFarewellMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentConversationPatchHangupFarewellMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => PublicAgentConversationPatchHangupFarewellMode.Fixed,
                "generated" => PublicAgentConversationPatchHangupFarewellMode.Generated,
                "off" => PublicAgentConversationPatchHangupFarewellMode.Off,
                _ => null,
            };
        }
    }
}