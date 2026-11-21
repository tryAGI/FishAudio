
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// The model id, as set in `llm.model` on an agent's config.
    /// </summary>
    public enum PublicLLMModelId
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
        AnthropicClaudeSonnet55,
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
        OpenaiGpt41Fast,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt4o,
        /// <summary>
        ///
        /// </summary>
        OpenaiGpt4oFast,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicLLMModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicLLMModelId value)
        {
            return value switch
            {
                PublicLLMModelId.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                PublicLLMModelId.AnthropicClaudeFable52 => "anthropic/claude-fable-5.2",
                PublicLLMModelId.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                PublicLLMModelId.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                PublicLLMModelId.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                PublicLLMModelId.AnthropicClaudeSonnet55 => "anthropic/claude-sonnet-5.5",
                PublicLLMModelId.GoogleGemini25Flash => "google/gemini-2.5-flash",
                PublicLLMModelId.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                PublicLLMModelId.GoogleGemini35FlashLitePriority => "google/gemini-3.5-flash-lite-priority",
                PublicLLMModelId.GoogleGemini36Flash => "google/gemini-3.6-flash",
                PublicLLMModelId.GoogleGemini36FlashPriority => "google/gemini-3.6-flash-priority",
                PublicLLMModelId.GoogleGemini38Flash => "google/gemini-3.8-flash",
                PublicLLMModelId.GoogleGemini38FlashPriority => "google/gemini-3.8-flash-priority",
                PublicLLMModelId.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                PublicLLMModelId.OpenaiGpt41 => "openai/gpt-4.1",
                PublicLLMModelId.OpenaiGpt41Fast => "openai/gpt-4.1-fast",
                PublicLLMModelId.OpenaiGpt4o => "openai/gpt-4o",
                PublicLLMModelId.OpenaiGpt4oFast => "openai/gpt-4o-fast",
                PublicLLMModelId.OpenaiGpt5 => "openai/gpt-5",
                PublicLLMModelId.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                PublicLLMModelId.OpenaiGpt56LunaFast => "openai/gpt-5.6-luna-fast",
                PublicLLMModelId.OpenaiGpt6Astra => "openai/gpt-6-astra",
                PublicLLMModelId.OpenaiGpt6AstraFast => "openai/gpt-6-astra-fast",
                PublicLLMModelId.OpenaiGpt6Luna => "openai/gpt-6-luna",
                PublicLLMModelId.OpenaiGpt6LunaFast => "openai/gpt-6-luna-fast",
                PublicLLMModelId.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                PublicLLMModelId.OpenaiGpt61SolFast => "openai/gpt-6.1-sol-fast",
                PublicLLMModelId.OpenaiGpt61Terra => "openai/gpt-6.1-terra",
                PublicLLMModelId.OpenaiGpt61TerraFast => "openai/gpt-6.1-terra-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicLLMModelId? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => PublicLLMModelId.AnthropicClaudeFable51,
                "anthropic/claude-fable-5.2" => PublicLLMModelId.AnthropicClaudeFable52,
                "anthropic/claude-haiku-4.5" => PublicLLMModelId.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => PublicLLMModelId.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => PublicLLMModelId.AnthropicClaudeSonnet46,
                "anthropic/claude-sonnet-5.5" => PublicLLMModelId.AnthropicClaudeSonnet55,
                "google/gemini-2.5-flash" => PublicLLMModelId.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => PublicLLMModelId.GoogleGemini35FlashLite,
                "google/gemini-3.5-flash-lite-priority" => PublicLLMModelId.GoogleGemini35FlashLitePriority,
                "google/gemini-3.6-flash" => PublicLLMModelId.GoogleGemini36Flash,
                "google/gemini-3.6-flash-priority" => PublicLLMModelId.GoogleGemini36FlashPriority,
                "google/gemini-3.8-flash" => PublicLLMModelId.GoogleGemini38Flash,
                "google/gemini-3.8-flash-priority" => PublicLLMModelId.GoogleGemini38FlashPriority,
                "google/gemma-4-26b-a4b-it" => PublicLLMModelId.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => PublicLLMModelId.OpenaiGpt41,
                "openai/gpt-4.1-fast" => PublicLLMModelId.OpenaiGpt41Fast,
                "openai/gpt-4o" => PublicLLMModelId.OpenaiGpt4o,
                "openai/gpt-4o-fast" => PublicLLMModelId.OpenaiGpt4oFast,
                "openai/gpt-5" => PublicLLMModelId.OpenaiGpt5,
                "openai/gpt-5.6-luna" => PublicLLMModelId.OpenaiGpt56Luna,
                "openai/gpt-5.6-luna-fast" => PublicLLMModelId.OpenaiGpt56LunaFast,
                "openai/gpt-6-astra" => PublicLLMModelId.OpenaiGpt6Astra,
                "openai/gpt-6-astra-fast" => PublicLLMModelId.OpenaiGpt6AstraFast,
                "openai/gpt-6-luna" => PublicLLMModelId.OpenaiGpt6Luna,
                "openai/gpt-6-luna-fast" => PublicLLMModelId.OpenaiGpt6LunaFast,
                "openai/gpt-6.1-sol" => PublicLLMModelId.OpenaiGpt61Sol,
                "openai/gpt-6.1-sol-fast" => PublicLLMModelId.OpenaiGpt61SolFast,
                "openai/gpt-6.1-terra" => PublicLLMModelId.OpenaiGpt61Terra,
                "openai/gpt-6.1-terra-fast" => PublicLLMModelId.OpenaiGpt61TerraFast,
                _ => null,
            };
        }
    }
}