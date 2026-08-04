
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSessionAnalysisDataValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Enum,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionAnalysisDataValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionAnalysisDataValueType value)
        {
            return value switch
            {
                AgentSessionAnalysisDataValueType.Boolean => "boolean",
                AgentSessionAnalysisDataValueType.Enum => "enum",
                AgentSessionAnalysisDataValueType.Number => "number",
                AgentSessionAnalysisDataValueType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionAnalysisDataValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentSessionAnalysisDataValueType.Boolean,
                "enum" => AgentSessionAnalysisDataValueType.Enum,
                "number" => AgentSessionAnalysisDataValueType.Number,
                "text" => AgentSessionAnalysisDataValueType.Text,
                _ => null,
            };
        }
    }
}