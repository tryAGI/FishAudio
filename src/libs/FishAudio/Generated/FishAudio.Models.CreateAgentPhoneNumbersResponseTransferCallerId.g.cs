
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentPhoneNumbersResponseTransferCallerId
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
    public static class CreateAgentPhoneNumbersResponseTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentPhoneNumbersResponseTransferCallerId value)
        {
            return value switch
            {
                CreateAgentPhoneNumbersResponseTransferCallerId.AgentNumber => "agent_number",
                CreateAgentPhoneNumbersResponseTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentPhoneNumbersResponseTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => CreateAgentPhoneNumbersResponseTransferCallerId.AgentNumber,
                "original_caller" => CreateAgentPhoneNumbersResponseTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}