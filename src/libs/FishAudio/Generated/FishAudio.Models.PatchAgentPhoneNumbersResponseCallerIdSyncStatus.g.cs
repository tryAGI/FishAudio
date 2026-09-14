
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `synced` once the carrier confirmed the policy, `pending` while it is being applied, `error` when the last attempt failed (send `retry_caller_id_sync`), `carrier_managed` for imported `sip` numbers.<br/>
    /// Default Value: carrier_managed
    /// </summary>
    public enum PatchAgentPhoneNumbersResponseCallerIdSyncStatus
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
    public static class PatchAgentPhoneNumbersResponseCallerIdSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentPhoneNumbersResponseCallerIdSyncStatus value)
        {
            return value switch
            {
                PatchAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged => "carrier_managed",
                PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Error => "error",
                PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Pending => "pending",
                PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentPhoneNumbersResponseCallerIdSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "carrier_managed" => PatchAgentPhoneNumbersResponseCallerIdSyncStatus.CarrierManaged,
                "error" => PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Error,
                "pending" => PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Pending,
                "synced" => PatchAgentPhoneNumbersResponseCallerIdSyncStatus.Synced,
                _ => null,
            };
        }
    }
}