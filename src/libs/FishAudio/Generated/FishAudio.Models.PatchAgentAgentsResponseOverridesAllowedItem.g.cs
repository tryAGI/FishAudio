
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAgentAgentsResponseOverridesAllowedItem
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
    public static class PatchAgentAgentsResponseOverridesAllowedItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAgentAgentsResponseOverridesAllowedItem value)
        {
            return value switch
            {
                PatchAgentAgentsResponseOverridesAllowedItem.FirstMessage => "first_message",
                PatchAgentAgentsResponseOverridesAllowedItem.Language => "language",
                PatchAgentAgentsResponseOverridesAllowedItem.SystemPrompt => "system_prompt",
                PatchAgentAgentsResponseOverridesAllowedItem.VoiceProfileId => "voice_profile_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAgentAgentsResponseOverridesAllowedItem? ToEnum(string value)
        {
            return value switch
            {
                "first_message" => PatchAgentAgentsResponseOverridesAllowedItem.FirstMessage,
                "language" => PatchAgentAgentsResponseOverridesAllowedItem.Language,
                "system_prompt" => PatchAgentAgentsResponseOverridesAllowedItem.SystemPrompt,
                "voice_profile_id" => PatchAgentAgentsResponseOverridesAllowedItem.VoiceProfileId,
                _ => null,
            };
        }
    }
}