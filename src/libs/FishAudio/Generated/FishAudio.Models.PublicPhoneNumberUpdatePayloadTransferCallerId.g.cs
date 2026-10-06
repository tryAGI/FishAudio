
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicPhoneNumberUpdatePayloadTransferCallerId
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
    public static class PublicPhoneNumberUpdatePayloadTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberUpdatePayloadTransferCallerId value)
        {
            return value switch
            {
                PublicPhoneNumberUpdatePayloadTransferCallerId.AgentNumber => "agent_number",
                PublicPhoneNumberUpdatePayloadTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberUpdatePayloadTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => PublicPhoneNumberUpdatePayloadTransferCallerId.AgentNumber,
                "original_caller" => PublicPhoneNumberUpdatePayloadTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}