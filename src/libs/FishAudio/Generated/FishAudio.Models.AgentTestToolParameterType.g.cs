
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTestToolParameterType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestToolParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestToolParameterType value)
        {
            return value switch
            {
                AgentTestToolParameterType.Boolean => "boolean",
                AgentTestToolParameterType.Number => "number",
                AgentTestToolParameterType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestToolParameterType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentTestToolParameterType.Boolean,
                "number" => AgentTestToolParameterType.Number,
                "string" => AgentTestToolParameterType.String,
                _ => null,
            };
        }
    }
}