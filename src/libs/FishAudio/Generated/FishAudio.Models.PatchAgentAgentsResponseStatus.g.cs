
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAgentAgentsResponseStatus
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
    public static class PatchAgentAgentsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentAgentsResponseStatus value)
        {
            return value switch
            {
                PatchAgentAgentsResponseStatus.Active => "active",
                PatchAgentAgentsResponseStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentAgentsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PatchAgentAgentsResponseStatus.Active,
                "archived" => PatchAgentAgentsResponseStatus.Archived,
                _ => null,
            };
        }
    }
}