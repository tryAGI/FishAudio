
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: inbound
    /// </summary>
    public enum AgentSessionSummaryDirection
    {
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionSummaryDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionSummaryDirection value)
        {
            return value switch
            {
                AgentSessionSummaryDirection.Inbound => "inbound",
                AgentSessionSummaryDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionSummaryDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => AgentSessionSummaryDirection.Inbound,
                "outbound" => AgentSessionSummaryDirection.Outbound,
                _ => null,
            };
        }
    }
}