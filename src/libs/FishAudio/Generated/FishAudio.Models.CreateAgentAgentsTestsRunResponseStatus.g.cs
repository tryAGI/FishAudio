
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// running until every run has finished.
    /// </summary>
    public enum CreateAgentAgentsTestsRunResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentAgentsTestsRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentAgentsTestsRunResponseStatus value)
        {
            return value switch
            {
                CreateAgentAgentsTestsRunResponseStatus.Completed => "completed",
                CreateAgentAgentsTestsRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentAgentsTestsRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateAgentAgentsTestsRunResponseStatus.Completed,
                "running" => CreateAgentAgentsTestsRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}