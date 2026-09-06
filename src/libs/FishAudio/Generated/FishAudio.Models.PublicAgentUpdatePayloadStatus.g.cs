
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentUpdatePayloadStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentUpdatePayloadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentUpdatePayloadStatus value)
        {
            return value switch
            {
                PublicAgentUpdatePayloadStatus.Active => "active",
                PublicAgentUpdatePayloadStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentUpdatePayloadStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PublicAgentUpdatePayloadStatus.Active,
                "archived" => PublicAgentUpdatePayloadStatus.Archived,
                _ => null,
            };
        }
    }
}