
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentUpdatePayloadStatus2
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
    public static class PublicAgentUpdatePayloadStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentUpdatePayloadStatus2 value)
        {
            return value switch
            {
                PublicAgentUpdatePayloadStatus2.Active => "active",
                PublicAgentUpdatePayloadStatus2.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentUpdatePayloadStatus2? ToEnum(string value)
        {
            return value switch
            {
                "active" => PublicAgentUpdatePayloadStatus2.Active,
                "archived" => PublicAgentUpdatePayloadStatus2.Archived,
                _ => null,
            };
        }
    }
}