
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionLlmEndpointErrorReason
    {
        /// <summary>
        ///
        /// </summary>
        AddressNotAllowed,
        /// <summary>
        ///
        /// </summary>
        ConnectionRefused,
        /// <summary>
        ///
        /// </summary>
        ConnectionReset,
        /// <summary>
        ///
        /// </summary>
        DnsFailed,
        /// <summary>
        ///
        /// </summary>
        EmptyReply,
        /// <summary>
        ///
        /// </summary>
        NotEventStream,
        /// <summary>
        ///
        /// </summary>
        StreamIncomplete,
        /// <summary>
        ///
        /// </summary>
        TlsFailed,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionLlmEndpointErrorReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionLlmEndpointErrorReason value)
        {
            return value switch
            {
                AgentSessionLlmEndpointErrorReason.AddressNotAllowed => "address_not_allowed",
                AgentSessionLlmEndpointErrorReason.ConnectionRefused => "connection_refused",
                AgentSessionLlmEndpointErrorReason.ConnectionReset => "connection_reset",
                AgentSessionLlmEndpointErrorReason.DnsFailed => "dns_failed",
                AgentSessionLlmEndpointErrorReason.EmptyReply => "empty_reply",
                AgentSessionLlmEndpointErrorReason.NotEventStream => "not_event_stream",
                AgentSessionLlmEndpointErrorReason.StreamIncomplete => "stream_incomplete",
                AgentSessionLlmEndpointErrorReason.TlsFailed => "tls_failed",
                AgentSessionLlmEndpointErrorReason.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionLlmEndpointErrorReason? ToEnum(string value)
        {
            return value switch
            {
                "address_not_allowed" => AgentSessionLlmEndpointErrorReason.AddressNotAllowed,
                "connection_refused" => AgentSessionLlmEndpointErrorReason.ConnectionRefused,
                "connection_reset" => AgentSessionLlmEndpointErrorReason.ConnectionReset,
                "dns_failed" => AgentSessionLlmEndpointErrorReason.DnsFailed,
                "empty_reply" => AgentSessionLlmEndpointErrorReason.EmptyReply,
                "not_event_stream" => AgentSessionLlmEndpointErrorReason.NotEventStream,
                "stream_incomplete" => AgentSessionLlmEndpointErrorReason.StreamIncomplete,
                "tls_failed" => AgentSessionLlmEndpointErrorReason.TlsFailed,
                "unknown" => AgentSessionLlmEndpointErrorReason.Unknown,
                _ => null,
            };
        }
    }
}