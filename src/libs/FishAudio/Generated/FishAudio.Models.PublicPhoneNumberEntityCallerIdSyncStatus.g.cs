
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// `synced` once the carrier confirmed the policy, `pending` while it is being applied, `error` when the last attempt failed (send `retry_caller_id_sync`), `carrier_managed` for imported `sip` numbers.<br/>
    /// Default Value: carrier_managed
    /// </summary>
    public enum PublicPhoneNumberEntityCallerIdSyncStatus
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
    public static class PublicPhoneNumberEntityCallerIdSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicPhoneNumberEntityCallerIdSyncStatus value)
        {
            return value switch
            {
                PublicPhoneNumberEntityCallerIdSyncStatus.CarrierManaged => "carrier_managed",
                PublicPhoneNumberEntityCallerIdSyncStatus.Error => "error",
                PublicPhoneNumberEntityCallerIdSyncStatus.Pending => "pending",
                PublicPhoneNumberEntityCallerIdSyncStatus.Synced => "synced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicPhoneNumberEntityCallerIdSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "carrier_managed" => PublicPhoneNumberEntityCallerIdSyncStatus.CarrierManaged,
                "error" => PublicPhoneNumberEntityCallerIdSyncStatus.Error,
                "pending" => PublicPhoneNumberEntityCallerIdSyncStatus.Pending,
                "synced" => PublicPhoneNumberEntityCallerIdSyncStatus.Synced,
                _ => null,
            };
        }
    }
}