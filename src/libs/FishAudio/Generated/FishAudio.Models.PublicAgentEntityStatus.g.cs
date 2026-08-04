
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentEntityStatus
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
    public static class PublicAgentEntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentEntityStatus value)
        {
            return value switch
            {
                PublicAgentEntityStatus.Active => "active",
                PublicAgentEntityStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentEntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PublicAgentEntityStatus.Active,
                "archived" => PublicAgentEntityStatus.Archived,
                _ => null,
            };
        }
    }
}