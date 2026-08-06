
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentAgentsResponseOverridesAllowedItem
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
    public static class GetAgentAgentsResponseOverridesAllowedItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentAgentsResponseOverridesAllowedItem value)
        {
            return value switch
            {
                GetAgentAgentsResponseOverridesAllowedItem.FirstMessage => "first_message",
                GetAgentAgentsResponseOverridesAllowedItem.Language => "language",
                GetAgentAgentsResponseOverridesAllowedItem.SystemPrompt => "system_prompt",
                GetAgentAgentsResponseOverridesAllowedItem.VoiceId => "voice_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentAgentsResponseOverridesAllowedItem? ToEnum(string value)
        {
            return value switch
            {
                "first_message" => GetAgentAgentsResponseOverridesAllowedItem.FirstMessage,
                "language" => GetAgentAgentsResponseOverridesAllowedItem.Language,
                "system_prompt" => GetAgentAgentsResponseOverridesAllowedItem.SystemPrompt,
                "voice_id" => GetAgentAgentsResponseOverridesAllowedItem.VoiceId,
                _ => null,
            };
        }
    }
}