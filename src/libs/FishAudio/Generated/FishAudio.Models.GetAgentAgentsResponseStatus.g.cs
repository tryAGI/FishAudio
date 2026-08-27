
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentAgentsResponseStatus
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
    public static class GetAgentAgentsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAgentsResponseStatus value)
        {
            return value switch
            {
                GetAgentAgentsResponseStatus.Active => "active",
                GetAgentAgentsResponseStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAgentsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetAgentAgentsResponseStatus.Active,
                "archived" => GetAgentAgentsResponseStatus.Archived,
                _ => null,
            };
        }
    }
}