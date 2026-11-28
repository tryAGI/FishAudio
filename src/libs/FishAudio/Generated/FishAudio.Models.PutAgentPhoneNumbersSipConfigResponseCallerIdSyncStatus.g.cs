
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `synced` once the carrier confirmed the policy, `pending` while it is being applied, `error` when the last attempt failed (send `retry_caller_id_sync`), `carrier_managed` for imported `sip` numbers.<br/>
    /// Default Value: carrier_managed
    /// </summary>
    public enum PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus
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
    public static class PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus value)
        {
            return value switch
            {
                PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.CarrierManaged => "carrier_managed",
                PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Error => "error",
                PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Pending => "pending",
                PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "carrier_managed" => PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.CarrierManaged,
                "error" => PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Error,
                "pending" => PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Pending,
                "synced" => PutAgentPhoneNumbersSipConfigResponseCallerIdSyncStatus.Synced,
                _ => null,
            };
        }
    }
}