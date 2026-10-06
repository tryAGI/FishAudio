
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: generated
    /// </summary>
    public enum AgentTransferDestinationAnnouncementMode
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
    public static class AgentTransferDestinationAnnouncementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTransferDestinationAnnouncementMode value)
        {
            return value switch
            {
                AgentTransferDestinationAnnouncementMode.Fixed => "fixed",
                AgentTransferDestinationAnnouncementMode.Generated => "generated",
                AgentTransferDestinationAnnouncementMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTransferDestinationAnnouncementMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AgentTransferDestinationAnnouncementMode.Fixed,
                "generated" => AgentTransferDestinationAnnouncementMode.Generated,
                "off" => AgentTransferDestinationAnnouncementMode.Off,
                _ => null,
            };
        }
    }
}