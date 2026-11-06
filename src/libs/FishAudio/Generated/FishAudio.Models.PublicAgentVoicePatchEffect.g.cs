
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentVoicePatchEffect
    {
        /// <summary>
        ///
        /// </summary>
        Intercom,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVoicePatchEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoicePatchEffect value)
        {
            return value switch
            {
                PublicAgentVoicePatchEffect.Intercom => "intercom",
                PublicAgentVoicePatchEffect.None => "none",
                PublicAgentVoicePatchEffect.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoicePatchEffect? ToEnum(string value)
        {
            return value switch
            {
                "intercom" => PublicAgentVoicePatchEffect.Intercom,
                "none" => PublicAgentVoicePatchEffect.None,
                "phone" => PublicAgentVoicePatchEffect.Phone,
                _ => null,
            };
        }
    }
}