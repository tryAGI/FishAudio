
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferItemWarmConnect
    {
        /// <summary>
        ///
        /// </summary>
        Briefing,
        /// <summary>
        ///
        /// </summary>
        Confirm,
        /// <summary>
        ///
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferItemWarmConnectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferItemWarmConnect value)
        {
            return value switch
            {
                AgentSessionTransferItemWarmConnect.Briefing => "briefing",
                AgentSessionTransferItemWarmConnect.Confirm => "confirm",
                AgentSessionTransferItemWarmConnect.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferItemWarmConnect? ToEnum(string value)
        {
            return value switch
            {
                "briefing" => AgentSessionTransferItemWarmConnect.Briefing,
                "confirm" => AgentSessionTransferItemWarmConnect.Confirm,
                "direct" => AgentSessionTransferItemWarmConnect.Direct,
                _ => null,
            };
        }
    }
}