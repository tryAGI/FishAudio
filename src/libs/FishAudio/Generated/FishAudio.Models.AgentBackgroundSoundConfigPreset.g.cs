
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: off
    /// </summary>
    public enum AgentBackgroundSoundConfigPreset
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
    public static class AgentBackgroundSoundConfigPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBackgroundSoundConfigPreset value)
        {
            return value switch
            {
                AgentBackgroundSoundConfigPreset.Cafe => "cafe",
                AgentBackgroundSoundConfigPreset.CallCenter => "call_center",
                AgentBackgroundSoundConfigPreset.CityStreet => "city_street",
                AgentBackgroundSoundConfigPreset.Custom => "custom",
                AgentBackgroundSoundConfigPreset.Off => "off",
                AgentBackgroundSoundConfigPreset.Office => "office",
                AgentBackgroundSoundConfigPreset.PhoneLine => "phone_line",
                AgentBackgroundSoundConfigPreset.PhoneLineDigital => "phone_line_digital",
                AgentBackgroundSoundConfigPreset.Restaurant => "restaurant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBackgroundSoundConfigPreset? ToEnum(string value)
        {
            return value switch
            {
                "cafe" => AgentBackgroundSoundConfigPreset.Cafe,
                "call_center" => AgentBackgroundSoundConfigPreset.CallCenter,
                "city_street" => AgentBackgroundSoundConfigPreset.CityStreet,
                "custom" => AgentBackgroundSoundConfigPreset.Custom,
                "off" => AgentBackgroundSoundConfigPreset.Off,
                "office" => AgentBackgroundSoundConfigPreset.Office,
                "phone_line" => AgentBackgroundSoundConfigPreset.PhoneLine,
                "phone_line_digital" => AgentBackgroundSoundConfigPreset.PhoneLineDigital,
                "restaurant" => AgentBackgroundSoundConfigPreset.Restaurant,
                _ => null,
            };
        }
    }
}