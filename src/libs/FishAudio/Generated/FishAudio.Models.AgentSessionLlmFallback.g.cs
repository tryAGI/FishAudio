
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// One move of a reply to another model.<br/>
    /// - error: the model failed the request.<br/>
    /// - timeout: no reply within the platform's own time limit (outside manual;<br/>
    ///   in manual every model has a first-token limit, 5 seconds when not set).<br/>
    /// - ttft_timeout: no first token within the model's `ttft_timeout_ms`.<br/>
    /// - total_timeout: the reply, nothing of it spoken yet, not finished within<br/>
    ///   the model's `total_timeout_ms`.<br/>
    /// - empty: the model's response stream broke off with no output and no end<br/>
    ///   signal (a provider failure). A reply the model finished with nothing in<br/>
    ///   it is the agent staying silent, not a fallback.<br/>
    /// - kick_in: running in parallel, the first fallback's reply was used<br/>
    ///   because the agent's own model had no first token within `kick_in_ms`.
    /// </summary>
    public sealed partial class AgentSessionLlmFallback
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
        /// A model as the agent config names it: a platform model id in `model`,<br/>
        /// or a customer endpoint in `custom` (never its key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionLlmModelRef From { get; set; }

        /// <summary>
        /// A model as the agent config names it: a platform model id in `model`,<br/>
        /// or a customer endpoint in `custom` (never its key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionLlmModelRef To { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.AgentSessionLlmFallbackReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.AgentSessionLlmFallbackReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmFallback" /> class.
        /// </summary>
        /// <param name="from">
        /// A model as the agent config names it: a platform model id in `model`,<br/>
        /// or a customer endpoint in `custom` (never its key).
        /// </param>
        /// <param name="to">
        /// A model as the agent config names it: a platform model id in `model`,<br/>
        /// or a customer endpoint in `custom` (never its key).
        /// </param>
        /// <param name="reason"></param>
        /// <param name="occurredAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="turnId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionLlmFallback(
            global::FishAudio.AgentSessionLlmModelRef from,
            global::FishAudio.AgentSessionLlmModelRef to,
            global::FishAudio.AgentSessionLlmFallbackReason reason,
            string? occurredAt,
            int? turnId)
        {
            this.OccurredAt = occurredAt;
            this.TurnId = turnId;
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionLlmFallback" /> class.
        /// </summary>
        public AgentSessionLlmFallback()
        {
        }

    }
}