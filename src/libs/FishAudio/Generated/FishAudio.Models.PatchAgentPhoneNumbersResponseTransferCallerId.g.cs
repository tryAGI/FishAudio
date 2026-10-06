
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAgentPhoneNumbersResponseTransferCallerId
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
    public static class PatchAgentPhoneNumbersResponseTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentPhoneNumbersResponseTransferCallerId value)
        {
            return value switch
            {
                PatchAgentPhoneNumbersResponseTransferCallerId.AgentNumber => "agent_number",
                PatchAgentPhoneNumbersResponseTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentPhoneNumbersResponseTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => PatchAgentPhoneNumbersResponseTransferCallerId.AgentNumber,
                "original_caller" => PatchAgentPhoneNumbersResponseTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}