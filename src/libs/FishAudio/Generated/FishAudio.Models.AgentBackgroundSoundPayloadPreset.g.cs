
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: off
    /// </summary>
    public enum AgentBackgroundSoundPayloadPreset
    {
        /// <summary>
        ///
        /// </summary>
        Cafe,
        /// <summary>
        ///
        /// </summary>
        CallCenter,
        /// <summary>
        ///
        /// </summary>
        CityStreet,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
        /// <summary>
        ///
        /// </summary>
        PhoneLine,
        /// <summary>
        ///
        /// </summary>
        PhoneLineDigital,
        /// <summary>
        ///
        /// </summary>
        Restaurant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentBackgroundSoundPayloadPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBackgroundSoundPayloadPreset value)
        {
            return value switch
            {
                AgentBackgroundSoundPayloadPreset.Cafe => "cafe",
                AgentBackgroundSoundPayloadPreset.CallCenter => "call_center",
                AgentBackgroundSoundPayloadPreset.CityStreet => "city_street",
                AgentBackgroundSoundPayloadPreset.Custom => "custom",
                AgentBackgroundSoundPayloadPreset.Off => "off",
                AgentBackgroundSoundPayloadPreset.Office => "office",
                AgentBackgroundSoundPayloadPreset.PhoneLine => "phone_line",
                AgentBackgroundSoundPayloadPreset.PhoneLineDigital => "phone_line_digital",
                AgentBackgroundSoundPayloadPreset.Restaurant => "restaurant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBackgroundSoundPayloadPreset? ToEnum(string value)
        {
            return value switch
            {
                "cafe" => AgentBackgroundSoundPayloadPreset.Cafe,
                "call_center" => AgentBackgroundSoundPayloadPreset.CallCenter,
                "city_street" => AgentBackgroundSoundPayloadPreset.CityStreet,
                "custom" => AgentBackgroundSoundPayloadPreset.Custom,
                "off" => AgentBackgroundSoundPayloadPreset.Off,
                "office" => AgentBackgroundSoundPayloadPreset.Office,
                "phone_line" => AgentBackgroundSoundPayloadPreset.PhoneLine,
                "phone_line_digital" => AgentBackgroundSoundPayloadPreset.PhoneLineDigital,
                "restaurant" => AgentBackgroundSoundPayloadPreset.Restaurant,
                _ => null,
            };
        }
    }
}