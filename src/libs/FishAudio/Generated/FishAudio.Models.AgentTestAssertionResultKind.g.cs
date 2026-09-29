
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestAssertionResultKind
    {
        /// <summary>
        ///
        /// </summary>
        EndedBy,
        /// <summary>
        ///
        /// </summary>
        ForbiddenTool,
        /// <summary>
        ///
        /// </summary>
        ToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestAssertionResultKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestAssertionResultKind value)
        {
            return value switch
            {
                AgentTestAssertionResultKind.EndedBy => "ended_by",
                AgentTestAssertionResultKind.ForbiddenTool => "forbidden_tool",
                AgentTestAssertionResultKind.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestAssertionResultKind? ToEnum(string value)
        {
            return value switch
            {
                "ended_by" => AgentTestAssertionResultKind.EndedBy,
                "forbidden_tool" => AgentTestAssertionResultKind.ForbiddenTool,
                "tool_call" => AgentTestAssertionResultKind.ToolCall,
                _ => null,
            };
        }
    }
}