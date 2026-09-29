
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestMockGapSource
    {
        /// <summary>
        ///
        /// </summary>
        Missing,
        /// <summary>
        ///
        /// </summary>
        Unmatched,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestMockGapSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestMockGapSource value)
        {
            return value switch
            {
                AgentTestMockGapSource.Missing => "missing",
                AgentTestMockGapSource.Unmatched => "unmatched",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestMockGapSource? ToEnum(string value)
        {
            return value switch
            {
                "missing" => AgentTestMockGapSource.Missing,
                "unmatched" => AgentTestMockGapSource.Unmatched,
                _ => null,
            };
        }
    }
}