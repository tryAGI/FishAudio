
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: generated
    /// </summary>
    public enum AgentTransferDestinationPatchAnnouncementMode
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
    public static class AgentTransferDestinationPatchAnnouncementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationPatchAnnouncementMode value)
        {
            return value switch
            {
                AgentTransferDestinationPatchAnnouncementMode.Fixed => "fixed",
                AgentTransferDestinationPatchAnnouncementMode.Generated => "generated",
                AgentTransferDestinationPatchAnnouncementMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationPatchAnnouncementMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentTransferDestinationPatchAnnouncementMode.Fixed,
                "generated" => AgentTransferDestinationPatchAnnouncementMode.Generated,
                "off" => AgentTransferDestinationPatchAnnouncementMode.Off,
                _ => null,
            };
        }
    }
}