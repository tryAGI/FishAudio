
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentAgentsResponseStatus
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
    public static class CreateAgentAgentsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentAgentsResponseStatus value)
        {
            return value switch
            {
                CreateAgentAgentsResponseStatus.Active => "active",
                CreateAgentAgentsResponseStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentAgentsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateAgentAgentsResponseStatus.Active,
                "archived" => CreateAgentAgentsResponseStatus.Archived,
                _ => null,
            };
        }
    }
}