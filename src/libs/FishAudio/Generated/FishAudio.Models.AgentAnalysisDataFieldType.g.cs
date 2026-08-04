
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum AgentAnalysisDataFieldType
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
    public static class AgentAnalysisDataFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisDataFieldType value)
        {
            return value switch
            {
                AgentAnalysisDataFieldType.Boolean => "boolean",
                AgentAnalysisDataFieldType.Enum => "enum",
                AgentAnalysisDataFieldType.Number => "number",
                AgentAnalysisDataFieldType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisDataFieldType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentAnalysisDataFieldType.Boolean,
                "enum" => AgentAnalysisDataFieldType.Enum,
                "number" => AgentAnalysisDataFieldType.Number,
                "text" => AgentAnalysisDataFieldType.Text,
                _ => null,
            };
        }
    }
}