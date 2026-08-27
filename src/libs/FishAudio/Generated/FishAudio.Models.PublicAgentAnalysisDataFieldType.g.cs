
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum PublicAgentAnalysisDataFieldType
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
    public static class PublicAgentAnalysisDataFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentAnalysisDataFieldType value)
        {
            return value switch
            {
                PublicAgentAnalysisDataFieldType.Boolean => "boolean",
                PublicAgentAnalysisDataFieldType.Enum => "enum",
                PublicAgentAnalysisDataFieldType.Number => "number",
                PublicAgentAnalysisDataFieldType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentAnalysisDataFieldType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => PublicAgentAnalysisDataFieldType.Boolean,
                "enum" => PublicAgentAnalysisDataFieldType.Enum,
                "number" => PublicAgentAnalysisDataFieldType.Number,
                "text" => PublicAgentAnalysisDataFieldType.Text,
                _ => null,
            };
        }
    }
}