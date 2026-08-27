
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentLLMPatchModel2
    {
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeHaiku45,
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeSonnet46,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini35FlashLite,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini36Flash,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt4o,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt56Luna,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentLLMPatchModel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentLLMPatchModel2 value)
        {
            return value switch
            {
                PublicAgentLLMPatchModel2.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                PublicAgentLLMPatchModel2.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                PublicAgentLLMPatchModel2.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                PublicAgentLLMPatchModel2.GoogleGemini36Flash => "google/gemini-3.6-flash",
                PublicAgentLLMPatchModel2.OpenaiGpt4o => "openai/gpt-4o",
                PublicAgentLLMPatchModel2.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentLLMPatchModel2? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-haiku-4.5" => PublicAgentLLMPatchModel2.AnthropicClaudeHaiku45,
                "anthropic/claude-sonnet-4.6" => PublicAgentLLMPatchModel2.AnthropicClaudeSonnet46,
                "google/gemini-3.5-flash-lite" => PublicAgentLLMPatchModel2.GoogleGemini35FlashLite,
                "google/gemini-3.6-flash" => PublicAgentLLMPatchModel2.GoogleGemini36Flash,
                "openai/gpt-4o" => PublicAgentLLMPatchModel2.OpenaiGpt4o,
                "openai/gpt-5.6-luna" => PublicAgentLLMPatchModel2.OpenaiGpt56Luna,
                _ => null,
            };
        }
    }
}