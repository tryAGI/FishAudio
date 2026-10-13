
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionTransferMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        TransferTarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionTransferMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionTransferMessageRole value)
        {
            return value switch
            {
                AgentSessionTransferMessageRole.Assistant => "assistant",
                AgentSessionTransferMessageRole.TransferTarget => "transfer_target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionTransferMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentSessionTransferMessageRole.Assistant,
                "transfer_target" => AgentSessionTransferMessageRole.TransferTarget,
                _ => null,
            };
        }
    }
}