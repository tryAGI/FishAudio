
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionLlmFallbackReason
    {
        /// <summary>
        ///
        /// </summary>
        Empty,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        KickIn,
        /// <summary>
        ///
        /// </summary>
        Timeout,
        /// <summary>
        ///
        /// </summary>
        TotalTimeout,
        /// <summary>
        ///
        /// </summary>
        TtftTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionLlmFallbackReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionLlmFallbackReason value)
        {
            return value switch
            {
                AgentSessionLlmFallbackReason.Empty => "empty",
                AgentSessionLlmFallbackReason.Error => "error",
                AgentSessionLlmFallbackReason.KickIn => "kick_in",
                AgentSessionLlmFallbackReason.Timeout => "timeout",
                AgentSessionLlmFallbackReason.TotalTimeout => "total_timeout",
                AgentSessionLlmFallbackReason.TtftTimeout => "ttft_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionLlmFallbackReason? ToEnum(string value)
        {
            return value switch
            {
                "empty" => AgentSessionLlmFallbackReason.Empty,
                "error" => AgentSessionLlmFallbackReason.Error,
                "kick_in" => AgentSessionLlmFallbackReason.KickIn,
                "timeout" => AgentSessionLlmFallbackReason.Timeout,
                "total_timeout" => AgentSessionLlmFallbackReason.TotalTimeout,
                "ttft_timeout" => AgentSessionLlmFallbackReason.TtftTimeout,
                _ => null,
            };
        }
    }
}