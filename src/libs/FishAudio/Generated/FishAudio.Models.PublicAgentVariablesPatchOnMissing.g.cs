
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicAgentVariablesPatchOnMissing
    {
        /// <summary>
        ///
        /// </summary>
        Empty,
        /// <summary>
        ///
        /// </summary>
        Keep,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAgentVariablesPatchOnMissingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAgentVariablesPatchOnMissing value)
        {
            return value switch
            {
                PublicAgentVariablesPatchOnMissing.Empty => "empty",
                PublicAgentVariablesPatchOnMissing.Keep => "keep",
                PublicAgentVariablesPatchOnMissing.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAgentVariablesPatchOnMissing? ToEnum(string value)
        {
            return value switch
            {
                "empty" => PublicAgentVariablesPatchOnMissing.Empty,
                "keep" => PublicAgentVariablesPatchOnMissing.Keep,
                "reject" => PublicAgentVariablesPatchOnMissing.Reject,
                _ => null,
            };
        }
    }
}