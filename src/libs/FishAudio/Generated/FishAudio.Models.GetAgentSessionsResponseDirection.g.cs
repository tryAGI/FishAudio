
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: inbound
    /// </summary>
    public enum GetAgentSessionsResponseDirection
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
    public static class GetAgentSessionsResponseDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseDirection value)
        {
            return value switch
            {
                GetAgentSessionsResponseDirection.Inbound => "inbound",
                GetAgentSessionsResponseDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => GetAgentSessionsResponseDirection.Inbound,
                "outbound" => GetAgentSessionsResponseDirection.Outbound,
                _ => null,
            };
        }
    }
}