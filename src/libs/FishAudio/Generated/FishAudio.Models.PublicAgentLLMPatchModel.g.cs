
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentLLMPatchModel
    {
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeFable51,
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeHaiku45,
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeOpus55,
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeSonnet46,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini25Flash,
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
        GoogleGemini38Flash,
        /// <summary>
        ///
        /// </summary>
        GoogleGemma426bA4bIt,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt41,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt4o,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt5,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt56Luna,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6Astra,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6Luna,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt61Sol,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentLLMPatchModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentLLMPatchModel value)
        {
            return value switch
            {
                PublicAgentLLMPatchModel.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                PublicAgentLLMPatchModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                PublicAgentLLMPatchModel.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                PublicAgentLLMPatchModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                PublicAgentLLMPatchModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                PublicAgentLLMPatchModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                PublicAgentLLMPatchModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                PublicAgentLLMPatchModel.GoogleGemini38Flash => "google/gemini-3.8-flash",
                PublicAgentLLMPatchModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                PublicAgentLLMPatchModel.OpenaiGpt41 => "openai/gpt-4.1",
                PublicAgentLLMPatchModel.OpenaiGpt4o => "openai/gpt-4o",
                PublicAgentLLMPatchModel.OpenaiGpt5 => "openai/gpt-5",
                PublicAgentLLMPatchModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                PublicAgentLLMPatchModel.OpenaiGpt6Astra => "openai/gpt-6-astra",
                PublicAgentLLMPatchModel.OpenaiGpt6Luna => "openai/gpt-6-luna",
                PublicAgentLLMPatchModel.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentLLMPatchModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => PublicAgentLLMPatchModel.AnthropicClaudeFable51,
                "anthropic/claude-haiku-4.5" => PublicAgentLLMPatchModel.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => PublicAgentLLMPatchModel.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => PublicAgentLLMPatchModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => PublicAgentLLMPatchModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => PublicAgentLLMPatchModel.GoogleGemini35FlashLite,
                "google/gemini-3.6-flash" => PublicAgentLLMPatchModel.GoogleGemini36Flash,
                "google/gemini-3.8-flash" => PublicAgentLLMPatchModel.GoogleGemini38Flash,
                "google/gemma-4-26b-a4b-it" => PublicAgentLLMPatchModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => PublicAgentLLMPatchModel.OpenaiGpt41,
                "openai/gpt-4o" => PublicAgentLLMPatchModel.OpenaiGpt4o,
                "openai/gpt-5" => PublicAgentLLMPatchModel.OpenaiGpt5,
                "openai/gpt-5.6-luna" => PublicAgentLLMPatchModel.OpenaiGpt56Luna,
                "openai/gpt-6-astra" => PublicAgentLLMPatchModel.OpenaiGpt6Astra,
                "openai/gpt-6-luna" => PublicAgentLLMPatchModel.OpenaiGpt6Luna,
                "openai/gpt-6.1-sol" => PublicAgentLLMPatchModel.OpenaiGpt61Sol,
                _ => null,
            };
        }
    }
}