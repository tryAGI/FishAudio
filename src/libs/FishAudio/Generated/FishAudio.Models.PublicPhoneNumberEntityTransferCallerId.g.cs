
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicPhoneNumberEntityTransferCallerId
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
    public static class PublicPhoneNumberEntityTransferCallerIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberEntityTransferCallerId value)
        {
            return value switch
            {
                PublicPhoneNumberEntityTransferCallerId.AgentNumber => "agent_number",
                PublicPhoneNumberEntityTransferCallerId.OriginalCaller => "original_caller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberEntityTransferCallerId? ToEnum(string value)
        {
            return value switch
            {
                "agent_number" => PublicPhoneNumberEntityTransferCallerId.AgentNumber,
                "original_caller" => PublicPhoneNumberEntityTransferCallerId.OriginalCaller,
                _ => null,
            };
        }
    }
}