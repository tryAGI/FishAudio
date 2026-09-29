
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Default Value: exact
    /// </summary>
    public enum AgentTestParamMatcherType
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Exact,
        /// <summary>
        ///
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTestParamMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTestParamMatcherType value)
        {
            return value switch
            {
                AgentTestParamMatcherType.Any => "any",
                AgentTestParamMatcherType.Exact => "exact",
                AgentTestParamMatcherType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTestParamMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "any" => AgentTestParamMatcherType.Any,
                "exact" => AgentTestParamMatcherType.Exact,
                "regex" => AgentTestParamMatcherType.Regex,
                _ => null,
            };
        }
    }
}