
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestToolCallRecordMockSource
    {
        /// <summary>
        ///
        /// </summary>
        Missing,
        /// <summary>
        ///
        /// </summary>
        Real,
        /// <summary>
        ///
        /// </summary>
        Test,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        ///
        /// </summary>
        Unmatched,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestToolCallRecordMockSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestToolCallRecordMockSource value)
        {
            return value switch
            {
                AgentTestToolCallRecordMockSource.Missing => "missing",
                AgentTestToolCallRecordMockSource.Real => "real",
                AgentTestToolCallRecordMockSource.Test => "test",
                AgentTestToolCallRecordMockSource.Tool => "tool",
                AgentTestToolCallRecordMockSource.Unmatched => "unmatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestToolCallRecordMockSource? ToEnum(string value)
        {
            return value switch
            {
                "missing" => AgentTestToolCallRecordMockSource.Missing,
                "real" => AgentTestToolCallRecordMockSource.Real,
                "test" => AgentTestToolCallRecordMockSource.Test,
                "tool" => AgentTestToolCallRecordMockSource.Tool,
                "unmatched" => AgentTestToolCallRecordMockSource.Unmatched,
                _ => null,
            };
        }
    }
}