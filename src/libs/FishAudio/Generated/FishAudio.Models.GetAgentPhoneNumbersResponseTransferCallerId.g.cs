
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentPhoneNumbersResponseTransferCallerId
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
    public static class GetAgentPhoneNumbersResponseTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentPhoneNumbersResponseTransferCallerId value)
        {
            return value switch
            {
                GetAgentPhoneNumbersResponseTransferCallerId.AgentNumber => "agent_number",
                GetAgentPhoneNumbersResponseTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentPhoneNumbersResponseTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => GetAgentPhoneNumbersResponseTransferCallerId.AgentNumber,
                "original_caller" => GetAgentPhoneNumbersResponseTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}