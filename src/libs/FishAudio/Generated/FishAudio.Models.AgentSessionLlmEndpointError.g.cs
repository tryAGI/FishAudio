
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One failed reply from the customer's own LLM endpoint, after the<br/>
    /// platform's single retry within the request.<br/>
    /// - http_error: the endpoint answered with a non-2xx status.<br/>
    /// - timeout: no response within the request timeout.<br/>
    /// - connection_error: the request got no answer. `reason` is dns_failed,<br/>
    ///   connection_refused, connection_reset, tls_failed, address_not_allowed<br/>
    ///   (an address the platform does not call) or unknown.<br/>
    /// - invalid_response: a 2xx response that was not a usable reply. `reason`<br/>
    ///   is not_event_stream (a streamed request answered with something else),<br/>
    ///   stream_incomplete (the stream ended without a finish_reason, usage or<br/>
    ///   output), empty_reply (no text and no tool call) or unknown.
    /// </summary>
    public sealed partial class AgentSessionLlmEndpointError
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurred_at")]
        public string? OccurredAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public int? TurnId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionLlmEndpointErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionLlmEndpointErrorType Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public global::FishAudio.AgentSessionLlmEndpointErrorReason? Reason { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consecutive_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConsecutiveFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmEndpointError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="consecutiveFailures"></param>
        /// <param name="occurredAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="turnId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reason">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="statusCode">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="responseBody">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="durationMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionLlmEndpointError(
            global::FishAudio.AgentSessionLlmEndpointErrorType type,
            int consecutiveFailures,
            string? occurredAt,
            int? turnId,
            global::FishAudio.AgentSessionLlmEndpointErrorReason? reason,
            int? statusCode,
            string? responseBody,
            int? durationMs)
        {
            this.OccurredAt = occurredAt;
            this.TurnId = turnId;
            this.Type = type;
            this.Reason = reason;
            this.StatusCode = statusCode;
            this.ResponseBody = responseBody;
            this.DurationMs = durationMs;
            this.ConsecutiveFailures = consecutiveFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmEndpointError" /> class.
        /// </summary>
        public AgentSessionLlmEndpointError()
        {
        }

    }
}