
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// How the agent's voice sounds on web calls (the console test call, the widget, the SDK). none (default): the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.<br/>
    /// Default Value: none
    /// </summary>
    public enum PublicAgentVoiceConfigEffect
    {
        /// <summary>
        /// the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.
        /// </summary>
        Intercom,
        /// <summary>
        /// the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.
        /// </summary>
        None,
        /// <summary>
        /// the clean voice. phone: a handset line, the 300 to 3400 Hz band with the codec's grain. intercom: a small overdriven speaker, as at a drive-thru order post or a door intercom. Phone and WhatsApp calls already sound like a line and ignore it.
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVoiceConfigEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVoiceConfigEffect value)
        {
            return value switch
            {
                PublicAgentVoiceConfigEffect.Intercom => "intercom",
                PublicAgentVoiceConfigEffect.None => "none",
                PublicAgentVoiceConfigEffect.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVoiceConfigEffect? ToEnum(string value)
        {
            return value switch
            {
                "intercom" => PublicAgentVoiceConfigEffect.Intercom,
                "none" => PublicAgentVoiceConfigEffect.None,
                "phone" => PublicAgentVoiceConfigEffect.Phone,
                _ => null,
            };
        }
    }
}