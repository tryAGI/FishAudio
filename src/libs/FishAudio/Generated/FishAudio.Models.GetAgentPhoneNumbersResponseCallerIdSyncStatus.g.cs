
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `synced` once the carrier confirmed the policy, `pending` while it is being applied, `error` when the last attempt failed (send `retry_caller_id_sync`), `carrier_managed` for imported `sip` numbers.<br/>
    /// Default Value: carrier_managed
    /// </summary>
    public enum GetAgentPhoneNumbersResponseCallerIdSyncStatus
    {
        /// <summary>
        ///
        /// </summary>
        CarrierManaged,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Synced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentPhoneNumbersResponseCallerIdSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentPhoneNumbersResponseCallerIdSyncStatus value)
        {
            return value switch
            {
                GetAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged => "carrier_managed",
                GetAgentPhoneNumbersResponseCallerIdSyncStatus.Error => "error",
                GetAgentPhoneNumbersResponseCallerIdSyncStatus.Pending => "pending",
                GetAgentPhoneNumbersResponseCallerIdSyncStatus.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentPhoneNumbersResponseCallerIdSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "carrier_managed" => GetAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged,
                "error" => GetAgentPhoneNumbersResponseCallerIdSyncStatus.Error,
                "pending" => GetAgentPhoneNumbersResponseCallerIdSyncStatus.Pending,
                "synced" => GetAgentPhoneNumbersResponseCallerIdSyncStatus.Synced,
                _ => null,
            };
        }
    }
}