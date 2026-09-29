
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestTranscriptMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestTranscriptMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestTranscriptMessageRole value)
        {
            return value switch
            {
                AgentTestTranscriptMessageRole.Agent => "agent",
                AgentTestTranscriptMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestTranscriptMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentTestTranscriptMessageRole.Agent,
                "user" => AgentTestTranscriptMessageRole.User,
                _ => null,
            };
        }
    }
}