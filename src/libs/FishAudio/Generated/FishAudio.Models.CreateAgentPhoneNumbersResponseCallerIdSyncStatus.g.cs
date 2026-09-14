
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `synced` once the carrier confirmed the policy, `pending` while it is being applied, `error` when the last attempt failed (send `retry_caller_id_sync`), `carrier_managed` for imported `sip` numbers.<br/>
    /// Default Value: carrier_managed
    /// </summary>
    public enum CreateAgentPhoneNumbersResponseCallerIdSyncStatus
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
    public static class CreateAgentPhoneNumbersResponseCallerIdSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentPhoneNumbersResponseCallerIdSyncStatus value)
        {
            return value switch
            {
                CreateAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged => "carrier_managed",
                CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Error => "error",
                CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Pending => "pending",
                CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentPhoneNumbersResponseCallerIdSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "carrier_managed" => CreateAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged,
                "error" => CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Error,
                "pending" => CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Pending,
                "synced" => CreateAgentPhoneNumbersResponseCallerIdSyncStatus.Synced,
                _ => null,
            };
        }
    }
}