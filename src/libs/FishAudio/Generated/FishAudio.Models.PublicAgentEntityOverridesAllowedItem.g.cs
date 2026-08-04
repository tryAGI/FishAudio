
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicAgentEntityOverridesAllowedItem
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
        VoiceProfileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentEntityOverridesAllowedItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentEntityOverridesAllowedItem value)
        {
            return value switch
            {
                PublicAgentEntityOverridesAllowedItem.FirstMessage => "first_message",
                PublicAgentEntityOverridesAllowedItem.Language => "language",
                PublicAgentEntityOverridesAllowedItem.SystemPrompt => "system_prompt",
                PublicAgentEntityOverridesAllowedItem.VoiceProfileId => "voice_profile_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentEntityOverridesAllowedItem? ToEnum(string value)
        {
            return value switch
            {
                "first_message" => PublicAgentEntityOverridesAllowedItem.FirstMessage,
                "language" => PublicAgentEntityOverridesAllowedItem.Language,
                "system_prompt" => PublicAgentEntityOverridesAllowedItem.SystemPrompt,
                "voice_profile_id" => PublicAgentEntityOverridesAllowedItem.VoiceProfileId,
                _ => null,
            };
        }
    }
}