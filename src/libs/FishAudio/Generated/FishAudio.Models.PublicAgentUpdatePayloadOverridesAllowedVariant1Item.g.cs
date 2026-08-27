
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentUpdatePayloadOverridesAllowedVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        FirstMessage,
        /// <summary>
        ///
        /// </summary>
        Language,
        /// <summary>
        ///
        /// </summary>
        SystemPrompt,
        /// <summary>
        ///
        /// </summary>
        VoiceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentUpdatePayloadOverridesAllowedVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentUpdatePayloadOverridesAllowedVariant1Item value)
        {
            return value switch
            {
                PublicAgentUpdatePayloadOverridesAllowedVariant1Item.FirstMessage => "first_message",
                PublicAgentUpdatePayloadOverridesAllowedVariant1Item.Language => "language",
                PublicAgentUpdatePayloadOverridesAllowedVariant1Item.SystemPrompt => "system_prompt",
                PublicAgentUpdatePayloadOverridesAllowedVariant1Item.VoiceId => "voice_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentUpdatePayloadOverridesAllowedVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "first_message" => PublicAgentUpdatePayloadOverridesAllowedVariant1Item.FirstMessage,
                "language" => PublicAgentUpdatePayloadOverridesAllowedVariant1Item.Language,
                "system_prompt" => PublicAgentUpdatePayloadOverridesAllowedVariant1Item.SystemPrompt,
                "voice_id" => PublicAgentUpdatePayloadOverridesAllowedVariant1Item.VoiceId,
                _ => null,
            };
        }
    }
}