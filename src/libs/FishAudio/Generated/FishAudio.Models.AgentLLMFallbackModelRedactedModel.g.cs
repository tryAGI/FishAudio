
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentLLMFallbackModelRedactedModel
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
    public static class AgentLLMFallbackModelRedactedModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMFallbackModelRedactedModel value)
        {
            return value switch
            {
                AgentLLMFallbackModelRedactedModel.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                AgentLLMFallbackModelRedactedModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                AgentLLMFallbackModelRedactedModel.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                AgentLLMFallbackModelRedactedModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                AgentLLMFallbackModelRedactedModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                AgentLLMFallbackModelRedactedModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                AgentLLMFallbackModelRedactedModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                AgentLLMFallbackModelRedactedModel.GoogleGemini36FlashPriority => "google/gemini-3.6-flash-priority",
                AgentLLMFallbackModelRedactedModel.GoogleGemini38Flash => "google/gemini-3.8-flash",
                AgentLLMFallbackModelRedactedModel.GoogleGemini38FlashPriority => "google/gemini-3.8-flash-priority",
                AgentLLMFallbackModelRedactedModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt41 => "openai/gpt-4.1",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt4o => "openai/gpt-4o",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt5 => "openai/gpt-5",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt6Astra => "openai/gpt-6-astra",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt6Luna => "openai/gpt-6-luna",
                AgentLLMFallbackModelRedactedModel.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMFallbackModelRedactedModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => AgentLLMFallbackModelRedactedModel.AnthropicClaudeFable51,
                "anthropic/claude-haiku-4.5" => AgentLLMFallbackModelRedactedModel.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => AgentLLMFallbackModelRedactedModel.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => AgentLLMFallbackModelRedactedModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => AgentLLMFallbackModelRedactedModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => AgentLLMFallbackModelRedactedModel.GoogleGemini35FlashLite,
                "google/gemini-3.6-flash" => AgentLLMFallbackModelRedactedModel.GoogleGemini36Flash,
                "google/gemini-3.6-flash-priority" => AgentLLMFallbackModelRedactedModel.GoogleGemini36FlashPriority,
                "google/gemini-3.8-flash" => AgentLLMFallbackModelRedactedModel.GoogleGemini38Flash,
                "google/gemini-3.8-flash-priority" => AgentLLMFallbackModelRedactedModel.GoogleGemini38FlashPriority,
                "google/gemma-4-26b-a4b-it" => AgentLLMFallbackModelRedactedModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => AgentLLMFallbackModelRedactedModel.OpenaiGpt41,
                "openai/gpt-4o" => AgentLLMFallbackModelRedactedModel.OpenaiGpt4o,
                "openai/gpt-5" => AgentLLMFallbackModelRedactedModel.OpenaiGpt5,
                "openai/gpt-5.6-luna" => AgentLLMFallbackModelRedactedModel.OpenaiGpt56Luna,
                "openai/gpt-6-astra" => AgentLLMFallbackModelRedactedModel.OpenaiGpt6Astra,
                "openai/gpt-6-luna" => AgentLLMFallbackModelRedactedModel.OpenaiGpt6Luna,
                "openai/gpt-6.1-sol" => AgentLLMFallbackModelRedactedModel.OpenaiGpt61Sol,
                _ => null,
            };
        }
    }
}