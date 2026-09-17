
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: google/gemini-3.5-flash-lite
    /// </summary>
    public enum AgentLLMConfigRedactedModel
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
        OpenaiGpt56Luna,
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
                AgentLLMConfigRedactedModel.AnthropicClaudeHaiku45 => "anthropic/claude-haiku-4.5",
                AgentLLMConfigRedactedModel.AnthropicClaudeSonnet46 => "anthropic/claude-sonnet-4.6",
                AgentLLMConfigRedactedModel.GoogleGemini25Flash => "google/gemini-2.5-flash",
                AgentLLMConfigRedactedModel.GoogleGemini35FlashLite => "google/gemini-3.5-flash-lite",
                AgentLLMConfigRedactedModel.GoogleGemini36Flash => "google/gemini-3.6-flash",
                AgentLLMConfigRedactedModel.GoogleGemma426bA4bIt => "google/gemma-4-26b-a4b-it",
                AgentLLMConfigRedactedModel.OpenaiGpt41 => "openai/gpt-4.1",
                AgentLLMConfigRedactedModel.OpenaiGpt4o => "openai/gpt-4o",
                AgentLLMConfigRedactedModel.OpenaiGpt56Luna => "openai/gpt-5.6-luna",
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
                "anthropic/claude-haiku-4.5" => AgentLLMConfigRedactedModel.AnthropicClaudeHaiku45,
                "anthropic/claude-sonnet-4.6" => AgentLLMConfigRedactedModel.AnthropicClaudeSonnet46,
                "google/gemini-2.5-flash" => AgentLLMConfigRedactedModel.GoogleGemini25Flash,
                "google/gemini-3.5-flash-lite" => AgentLLMConfigRedactedModel.GoogleGemini35FlashLite,
                "google/gemini-3.6-flash" => AgentLLMConfigRedactedModel.GoogleGemini36Flash,
                "google/gemma-4-26b-a4b-it" => AgentLLMConfigRedactedModel.GoogleGemma426bA4bIt,
                "openai/gpt-4.1" => AgentLLMConfigRedactedModel.OpenaiGpt41,
                "openai/gpt-4o" => AgentLLMConfigRedactedModel.OpenaiGpt4o,
                "openai/gpt-5.6-luna" => AgentLLMConfigRedactedModel.OpenaiGpt56Luna,
                _ => null,
            };
        }
    }
}