
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PutAgentPhoneNumbersSipConfigResponseTransferCallerId
    {
        /// <summary>
        ///
        /// </summary>
        AgentNumber,
        /// <summary>
        ///
        /// </summary>
        OriginalCaller,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutAgentPhoneNumbersSipConfigResponseTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAgentPhoneNumbersSipConfigResponseTransferCallerId value)
        {
            return value switch
            {
                PutAgentPhoneNumbersSipConfigResponseTransferCallerId.AgentNumber => "agent_number",
                PutAgentPhoneNumbersSipConfigResponseTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAgentPhoneNumbersSipConfigResponseTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => PutAgentPhoneNumbersSipConfigResponseTransferCallerId.AgentNumber,
                "original_caller" => PutAgentPhoneNumbersSipConfigResponseTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}