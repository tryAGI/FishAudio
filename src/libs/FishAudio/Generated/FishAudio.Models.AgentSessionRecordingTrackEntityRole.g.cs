
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionRecordingTrackEntityRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionRecordingTrackEntityRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionRecordingTrackEntityRole value)
        {
            return value switch
            {
                AgentSessionRecordingTrackEntityRole.Agent => "agent",
                AgentSessionRecordingTrackEntityRole.Human => "human",
                AgentSessionRecordingTrackEntityRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionRecordingTrackEntityRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentSessionRecordingTrackEntityRole.Agent,
                "human" => AgentSessionRecordingTrackEntityRole.Human,
                "user" => AgentSessionRecordingTrackEntityRole.User,
                _ => null,
            };
        }
    }
}