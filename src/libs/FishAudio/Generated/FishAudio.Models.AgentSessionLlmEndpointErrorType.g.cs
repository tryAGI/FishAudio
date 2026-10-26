
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionLlmEndpointErrorType
    {
        /// <summary>
        ///
        /// </summary>
        ConnectionError,
        /// <summary>
        ///
        /// </summary>
        HttpError,
        /// <summary>
        ///
        /// </summary>
        InvalidResponse,
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionLlmEndpointErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionLlmEndpointErrorType value)
        {
            return value switch
            {
                AgentSessionLlmEndpointErrorType.ConnectionError => "connection_error",
                AgentSessionLlmEndpointErrorType.HttpError => "http_error",
                AgentSessionLlmEndpointErrorType.InvalidResponse => "invalid_response",
                AgentSessionLlmEndpointErrorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionLlmEndpointErrorType? ToEnum(string value)
        {
            return value switch
            {
                "connection_error" => AgentSessionLlmEndpointErrorType.ConnectionError,
                "http_error" => AgentSessionLlmEndpointErrorType.HttpError,
                "invalid_response" => AgentSessionLlmEndpointErrorType.InvalidResponse,
                "timeout" => AgentSessionLlmEndpointErrorType.Timeout,
                _ => null,
            };
        }
    }
}