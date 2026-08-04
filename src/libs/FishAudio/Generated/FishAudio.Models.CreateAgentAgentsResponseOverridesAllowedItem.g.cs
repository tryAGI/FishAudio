
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentAgentsResponseOverridesAllowedItem
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
    public static class CreateAgentAgentsResponseOverridesAllowedItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentAgentsResponseOverridesAllowedItem value)
        {
            return value switch
            {
                CreateAgentAgentsResponseOverridesAllowedItem.FirstMessage => "first_message",
                CreateAgentAgentsResponseOverridesAllowedItem.Language => "language",
                CreateAgentAgentsResponseOverridesAllowedItem.SystemPrompt => "system_prompt",
                CreateAgentAgentsResponseOverridesAllowedItem.VoiceProfileId => "voice_profile_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentAgentsResponseOverridesAllowedItem? ToEnum(string value)
        {
            return value switch
            {
                "first_message" => CreateAgentAgentsResponseOverridesAllowedItem.FirstMessage,
                "language" => CreateAgentAgentsResponseOverridesAllowedItem.Language,
                "system_prompt" => CreateAgentAgentsResponseOverridesAllowedItem.SystemPrompt,
                "voice_profile_id" => CreateAgentAgentsResponseOverridesAllowedItem.VoiceProfileId,
                _ => null,
            };
        }
    }
}