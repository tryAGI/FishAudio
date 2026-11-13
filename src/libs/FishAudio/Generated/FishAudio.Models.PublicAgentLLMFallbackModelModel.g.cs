
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentLLMFallbackModelModel
    {
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeFable51,
        /// <summary>
        ///
        /// </summary>
        AnthropicClaudeFable52,
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
        GoogleGemini35FlashLitePriority,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini36Flash,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini36FlashPriority,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini38Flash,
        /// <summary>
        ///
        /// </summary>
        GoogleGemini38FlashPriority,
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
        OpenaiGpt56LunaFast,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6Astra,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6AstraFast,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6Luna,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt6LunaFast,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt61Sol,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt61SolFast,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt61Terra,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt61TerraFast,
        /// <summary>
        ///
        /// </summary>
        ZAiGlm53Flash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentLLMFallbackModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentLLMFallbackModelModel value)
        {
            return value switch
            {
                PublicAgentLLMFallbackModelModel.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                PublicAgentLLMFallbackModelModel.AnthropicClaudeFable52 => "anthropic/claude-fable-5.2",
                PublicAgentLLMFallbackModelModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                PublicAgentLLMFallbackModelModel.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                PublicAgentLLMFallbackModelModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                PublicAgentLLMFallbackModelModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                PublicAgentLLMFallbackModelModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                PublicAgentLLMFallbackModelModel.GoogleGemini35FlashLitePriority => "google/gemini-3.5-flash-lite-priority",
                PublicAgentLLMFallbackModelModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                PublicAgentLLMFallbackModelModel.GoogleGemini36FlashPriority => "google/gemini-3.6-flash-priority",
                PublicAgentLLMFallbackModelModel.GoogleGemini38Flash => "google/gemini-3.8-flash",
                PublicAgentLLMFallbackModelModel.GoogleGemini38FlashPriority => "google/gemini-3.8-flash-priority",
                PublicAgentLLMFallbackModelModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                PublicAgentLLMFallbackModelModel.OpenaiGpt41 => "openai/gpt-4.1",
                PublicAgentLLMFallbackModelModel.OpenaiGpt4o => "openai/gpt-4o",
                PublicAgentLLMFallbackModelModel.OpenaiGpt5 => "openai/gpt-5",
                PublicAgentLLMFallbackModelModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                PublicAgentLLMFallbackModelModel.OpenaiGpt56LunaFast => "openai/gpt-5.6-luna-fast",
                PublicAgentLLMFallbackModelModel.OpenaiGpt6Astra => "openai/gpt-6-astra",
                PublicAgentLLMFallbackModelModel.OpenaiGpt6AstraFast => "openai/gpt-6-astra-fast",
                PublicAgentLLMFallbackModelModel.OpenaiGpt6Luna => "openai/gpt-6-luna",
                PublicAgentLLMFallbackModelModel.OpenaiGpt6LunaFast => "openai/gpt-6-luna-fast",
                PublicAgentLLMFallbackModelModel.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                PublicAgentLLMFallbackModelModel.OpenaiGpt61SolFast => "openai/gpt-6.1-sol-fast",
                PublicAgentLLMFallbackModelModel.OpenaiGpt61Terra => "openai/gpt-6.1-terra",
                PublicAgentLLMFallbackModelModel.OpenaiGpt61TerraFast => "openai/gpt-6.1-terra-fast",
                PublicAgentLLMFallbackModelModel.ZAiGlm53Flash => "z-ai/glm-5.3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentLLMFallbackModelModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => PublicAgentLLMFallbackModelModel.AnthropicClaudeFable51,
                "anthropic/claude-fable-5.2" => PublicAgentLLMFallbackModelModel.AnthropicClaudeFable52,
                "anthropic/claude-haiku-4.5" => PublicAgentLLMFallbackModelModel.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => PublicAgentLLMFallbackModelModel.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => PublicAgentLLMFallbackModelModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => PublicAgentLLMFallbackModelModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => PublicAgentLLMFallbackModelModel.GoogleGemini35FlashLite,
                "google/gemini-3.5-flash-lite-priority" => PublicAgentLLMFallbackModelModel.GoogleGemini35FlashLitePriority,
                "google/gemini-3.6-flash" => PublicAgentLLMFallbackModelModel.GoogleGemini36Flash,
                "google/gemini-3.6-flash-priority" => PublicAgentLLMFallbackModelModel.GoogleGemini36FlashPriority,
                "google/gemini-3.8-flash" => PublicAgentLLMFallbackModelModel.GoogleGemini38Flash,
                "google/gemini-3.8-flash-priority" => PublicAgentLLMFallbackModelModel.GoogleGemini38FlashPriority,
                "google/gemma-4-26b-a4b-it" => PublicAgentLLMFallbackModelModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => PublicAgentLLMFallbackModelModel.OpenaiGpt41,
                "openai/gpt-4o" => PublicAgentLLMFallbackModelModel.OpenaiGpt4o,
                "openai/gpt-5" => PublicAgentLLMFallbackModelModel.OpenaiGpt5,
                "openai/gpt-5.6-luna" => PublicAgentLLMFallbackModelModel.OpenaiGpt56Luna,
                "openai/gpt-5.6-luna-fast" => PublicAgentLLMFallbackModelModel.OpenaiGpt56LunaFast,
                "openai/gpt-6-astra" => PublicAgentLLMFallbackModelModel.OpenaiGpt6Astra,
                "openai/gpt-6-astra-fast" => PublicAgentLLMFallbackModelModel.OpenaiGpt6AstraFast,
                "openai/gpt-6-luna" => PublicAgentLLMFallbackModelModel.OpenaiGpt6Luna,
                "openai/gpt-6-luna-fast" => PublicAgentLLMFallbackModelModel.OpenaiGpt6LunaFast,
                "openai/gpt-6.1-sol" => PublicAgentLLMFallbackModelModel.OpenaiGpt61Sol,
                "openai/gpt-6.1-sol-fast" => PublicAgentLLMFallbackModelModel.OpenaiGpt61SolFast,
                "openai/gpt-6.1-terra" => PublicAgentLLMFallbackModelModel.OpenaiGpt61Terra,
                "openai/gpt-6.1-terra-fast" => PublicAgentLLMFallbackModelModel.OpenaiGpt61TerraFast,
                "z-ai/glm-5.3-flash" => PublicAgentLLMFallbackModelModel.ZAiGlm53Flash,
                _ => null,
            };
        }
    }
}