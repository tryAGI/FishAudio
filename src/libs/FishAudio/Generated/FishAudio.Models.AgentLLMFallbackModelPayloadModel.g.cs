
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentLLMFallbackModelPayloadModel
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
    public static class AgentLLMFallbackModelPayloadModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMFallbackModelPayloadModel value)
        {
            return value switch
            {
                AgentLLMFallbackModelPayloadModel.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                AgentLLMFallbackModelPayloadModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                AgentLLMFallbackModelPayloadModel.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                AgentLLMFallbackModelPayloadModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                AgentLLMFallbackModelPayloadModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                AgentLLMFallbackModelPayloadModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                AgentLLMFallbackModelPayloadModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                AgentLLMFallbackModelPayloadModel.GoogleGemini36FlashPriority => "google/gemini-3.6-flash-priority",
                AgentLLMFallbackModelPayloadModel.GoogleGemini38Flash => "google/gemini-3.8-flash",
                AgentLLMFallbackModelPayloadModel.GoogleGemini38FlashPriority => "google/gemini-3.8-flash-priority",
                AgentLLMFallbackModelPayloadModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt41 => "openai/gpt-4.1",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt4o => "openai/gpt-4o",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt5 => "openai/gpt-5",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt6Astra => "openai/gpt-6-astra",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt6Luna => "openai/gpt-6-luna",
                AgentLLMFallbackModelPayloadModel.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMFallbackModelPayloadModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => AgentLLMFallbackModelPayloadModel.AnthropicClaudeFable51,
                "anthropic/claude-haiku-4.5" => AgentLLMFallbackModelPayloadModel.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => AgentLLMFallbackModelPayloadModel.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => AgentLLMFallbackModelPayloadModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => AgentLLMFallbackModelPayloadModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => AgentLLMFallbackModelPayloadModel.GoogleGemini35FlashLite,
                "google/gemini-3.6-flash" => AgentLLMFallbackModelPayloadModel.GoogleGemini36Flash,
                "google/gemini-3.6-flash-priority" => AgentLLMFallbackModelPayloadModel.GoogleGemini36FlashPriority,
                "google/gemini-3.8-flash" => AgentLLMFallbackModelPayloadModel.GoogleGemini38Flash,
                "google/gemini-3.8-flash-priority" => AgentLLMFallbackModelPayloadModel.GoogleGemini38FlashPriority,
                "google/gemma-4-26b-a4b-it" => AgentLLMFallbackModelPayloadModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => AgentLLMFallbackModelPayloadModel.OpenaiGpt41,
                "openai/gpt-4o" => AgentLLMFallbackModelPayloadModel.OpenaiGpt4o,
                "openai/gpt-5" => AgentLLMFallbackModelPayloadModel.OpenaiGpt5,
                "openai/gpt-5.6-luna" => AgentLLMFallbackModelPayloadModel.OpenaiGpt56Luna,
                "openai/gpt-6-astra" => AgentLLMFallbackModelPayloadModel.OpenaiGpt6Astra,
                "openai/gpt-6-luna" => AgentLLMFallbackModelPayloadModel.OpenaiGpt6Luna,
                "openai/gpt-6.1-sol" => AgentLLMFallbackModelPayloadModel.OpenaiGpt61Sol,
                _ => null,
            };
        }
    }
}