
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: openai/gpt-6.1-terra-fast
    /// </summary>
    public enum AgentLLMConfigRedactedModel
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
    public static class AgentLLMConfigRedactedModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLLMConfigRedactedModel value)
        {
            return value switch
            {
                AgentLLMConfigRedactedModel.AnthropicClaudeFable51 => "anthropic/claude-fable-5.1",
                AgentLLMConfigRedactedModel.AnthropicClaudeFable52 => "anthropic/claude-fable-5.2",
                AgentLLMConfigRedactedModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                AgentLLMConfigRedactedModel.AnthropicClaudeOpus55 => "anthropic/claude-opus-5.5",
                AgentLLMConfigRedactedModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                AgentLLMConfigRedactedModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                AgentLLMConfigRedactedModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                AgentLLMConfigRedactedModel.GoogleGemini35FlashLitePriority => "google/gemini-3.5-flash-lite-priority",
                AgentLLMConfigRedactedModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                AgentLLMConfigRedactedModel.GoogleGemini36FlashPriority => "google/gemini-3.6-flash-priority",
                AgentLLMConfigRedactedModel.GoogleGemini38Flash => "google/gemini-3.8-flash",
                AgentLLMConfigRedactedModel.GoogleGemini38FlashPriority => "google/gemini-3.8-flash-priority",
                AgentLLMConfigRedactedModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                AgentLLMConfigRedactedModel.OpenaiGpt41 => "openai/gpt-4.1",
                AgentLLMConfigRedactedModel.OpenaiGpt4o => "openai/gpt-4o",
                AgentLLMConfigRedactedModel.OpenaiGpt5 => "openai/gpt-5",
                AgentLLMConfigRedactedModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
                AgentLLMConfigRedactedModel.OpenaiGpt56LunaFast => "openai/gpt-5.6-luna-fast",
                AgentLLMConfigRedactedModel.OpenaiGpt6Astra => "openai/gpt-6-astra",
                AgentLLMConfigRedactedModel.OpenaiGpt6AstraFast => "openai/gpt-6-astra-fast",
                AgentLLMConfigRedactedModel.OpenaiGpt6Luna => "openai/gpt-6-luna",
                AgentLLMConfigRedactedModel.OpenaiGpt6LunaFast => "openai/gpt-6-luna-fast",
                AgentLLMConfigRedactedModel.OpenaiGpt61Sol => "openai/gpt-6.1-sol",
                AgentLLMConfigRedactedModel.OpenaiGpt61SolFast => "openai/gpt-6.1-sol-fast",
                AgentLLMConfigRedactedModel.OpenaiGpt61Terra => "openai/gpt-6.1-terra",
                AgentLLMConfigRedactedModel.OpenaiGpt61TerraFast => "openai/gpt-6.1-terra-fast",
                AgentLLMConfigRedactedModel.ZAiGlm53Flash => "z-ai/glm-5.3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLLMConfigRedactedModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-fable-5.1" => AgentLLMConfigRedactedModel.AnthropicClaudeFable51,
                "anthropic/claude-fable-5.2" => AgentLLMConfigRedactedModel.AnthropicClaudeFable52,
                "anthropic/claude-haiku-4.5" => AgentLLMConfigRedactedModel.AnthropicClaudeHaiku45,
                "anthropic/claude-opus-5.5" => AgentLLMConfigRedactedModel.AnthropicClaudeOpus55,
                "anthropic/claude-sonnet-4.6" => AgentLLMConfigRedactedModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => AgentLLMConfigRedactedModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => AgentLLMConfigRedactedModel.GoogleGemini35FlashLite,
                "google/gemini-3.5-flash-lite-priority" => AgentLLMConfigRedactedModel.GoogleGemini35FlashLitePriority,
                "google/gemini-3.6-flash" => AgentLLMConfigRedactedModel.GoogleGemini36Flash,
                "google/gemini-3.6-flash-priority" => AgentLLMConfigRedactedModel.GoogleGemini36FlashPriority,
                "google/gemini-3.8-flash" => AgentLLMConfigRedactedModel.GoogleGemini38Flash,
                "google/gemini-3.8-flash-priority" => AgentLLMConfigRedactedModel.GoogleGemini38FlashPriority,
                "google/gemma-4-26b-a4b-it" => AgentLLMConfigRedactedModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => AgentLLMConfigRedactedModel.OpenaiGpt41,
                "openai/gpt-4o" => AgentLLMConfigRedactedModel.OpenaiGpt4o,
                "openai/gpt-5" => AgentLLMConfigRedactedModel.OpenaiGpt5,
                "openai/gpt-5.6-luna" => AgentLLMConfigRedactedModel.OpenaiGpt56Luna,
                "openai/gpt-5.6-luna-fast" => AgentLLMConfigRedactedModel.OpenaiGpt56LunaFast,
                "openai/gpt-6-astra" => AgentLLMConfigRedactedModel.OpenaiGpt6Astra,
                "openai/gpt-6-astra-fast" => AgentLLMConfigRedactedModel.OpenaiGpt6AstraFast,
                "openai/gpt-6-luna" => AgentLLMConfigRedactedModel.OpenaiGpt6Luna,
                "openai/gpt-6-luna-fast" => AgentLLMConfigRedactedModel.OpenaiGpt6LunaFast,
                "openai/gpt-6.1-sol" => AgentLLMConfigRedactedModel.OpenaiGpt61Sol,
                "openai/gpt-6.1-sol-fast" => AgentLLMConfigRedactedModel.OpenaiGpt61SolFast,
                "openai/gpt-6.1-terra" => AgentLLMConfigRedactedModel.OpenaiGpt61Terra,
                "openai/gpt-6.1-terra-fast" => AgentLLMConfigRedactedModel.OpenaiGpt61TerraFast,
                "z-ai/glm-5.3-flash" => AgentLLMConfigRedactedModel.ZAiGlm53Flash,
                _ => null,
            };
        }
    }
}