
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// running until every run has finished.
    /// </summary>
    public enum GetAgentAgentsTestBatchesResponseStatus
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
    public static class GetAgentAgentsTestBatchesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAgentsTestBatchesResponseStatus value)
        {
            return value switch
            {
                GetAgentAgentsTestBatchesResponseStatus.Completed => "completed",
                GetAgentAgentsTestBatchesResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAgentsTestBatchesResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetAgentAgentsTestBatchesResponseStatus.Completed,
                "running" => GetAgentAgentsTestBatchesResponseStatus.Running,
                _ => null,
            };
        }
    }
}