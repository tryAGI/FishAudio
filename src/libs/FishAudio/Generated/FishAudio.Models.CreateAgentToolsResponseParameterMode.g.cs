
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Whether the agent runtime checks each call's arguments against `parameters` before running the tool. `legacy` (the default for tools created with `arguments`, and every tool from before this field existed): no check, the model's arguments run as sent. `strict` (the default for tools created with `parameters`): a call that does not satisfy the schema is refused and the model is told to ask the caller for the missing information, and the LLM provider's constrained decoding is turned on where the model supports it (OpenAI models and a custom OpenAI-compatible endpoint receive the tool with `strict: true`, Gemini on the platform's native channel runs validated function calling). Changing `parameters` never changes the mode, and the mode can be changed on its own.<br/>
    /// Default Value: legacy
    /// </summary>
    public enum CreateAgentToolsResponseParameterMode
    {
        /// <summary>
        /// no check, the model's arguments run as sent. `strict` (the default for tools created with `parameters`): a call that does not satisfy the schema is refused and the model is told to ask the caller for the missing information, and the LLM provider's constrained decoding is turned on where the model supports it (OpenAI models and a custom OpenAI-compatible endpoint receive the tool with `strict: true`, Gemini on the platform's native channel runs validated function calling). Changing `parameters` never changes the mode, and the mode can be changed on its own.
        /// </summary>
        Legacy,
        /// <summary>
        /// no check, the model's arguments run as sent. `strict` (the default for tools created with `parameters`): a call that does not satisfy the schema is refused and the model is told to ask the caller for the missing information, and the LLM provider's constrained decoding is turned on where the model supports it (OpenAI models and a custom OpenAI-compatible endpoint receive the tool with `strict: true`, Gemini on the platform's native channel runs validated function calling). Changing `parameters` never changes the mode, and the mode can be changed on its own.
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentToolsResponseParameterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentToolsResponseParameterMode value)
        {
            return value switch
            {
                CreateAgentToolsResponseParameterMode.Legacy => "legacy",
                CreateAgentToolsResponseParameterMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentToolsResponseParameterMode? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => CreateAgentToolsResponseParameterMode.Legacy,
                "strict" => CreateAgentToolsResponseParameterMode.Strict,
                _ => null,
            };
        }
    }
}