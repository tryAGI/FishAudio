
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAgentSessionsResponseItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        ToolCall,
        /// <summary>
        ///
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentSessionsResponseItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSessionsResponseItemDiscriminatorType value)
        {
            return value switch
            {
                GetAgentSessionsResponseItemDiscriminatorType.Message => "message",
                GetAgentSessionsResponseItemDiscriminatorType.ToolCall => "tool_call",
                GetAgentSessionsResponseItemDiscriminatorType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSessionsResponseItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => GetAgentSessionsResponseItemDiscriminatorType.Message,
                "tool_call" => GetAgentSessionsResponseItemDiscriminatorType.ToolCall,
                "tool_result" => GetAgentSessionsResponseItemDiscriminatorType.ToolResult,
                _ => null,
            };
        }
    }
}