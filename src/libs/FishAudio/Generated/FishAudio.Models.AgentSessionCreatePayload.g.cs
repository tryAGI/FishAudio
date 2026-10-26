
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSessionCreatePayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// IANA timezone (like `Asia/Tokyo`) for the agent's sense of local date and time in this session. Overrides the agent's configured timezone, which defaults to UTC. Invalid names are rejected with 422.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// The end user's device timezone as an IANA name (like `Asia/Tokyo`), used as a fallback hint: it applies only when neither `timezone` nor the agent's configured timezone is set, and invalid values are ignored rather than rejected. The Web SDK fills it automatically from the browser for public agents. When your backend creates the session, forward the value from your client.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_timezone")]
        public string? ClientTimezone { get; set; }

        /// <summary>
        /// Per-session overrides of the agent's context switches (`context.current_time` in the agent config). A switch you leave out follows the agent.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::FishAudio.AgentSessionContextPayload? Context { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::FishAudio.AgentSessionOverridesPayload? Overrides { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Your identifier for the end user, stored verbatim. Returned on session reads and webhooks, and filterable with `GET /v1/agent/sessions?end_user_id=`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_user_id")]
        public string? EndUserId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_extra_body")]
        public object? LlmExtraBody { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_events")]
        public bool? ToolEvents { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_audio")]
        public bool? RecordAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreatePayload" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="timezone">
        /// IANA timezone (like `Asia/Tokyo`) for the agent's sense of local date and time in this session. Overrides the agent's configured timezone, which defaults to UTC. Invalid names are rejected with 422.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientTimezone">
        /// The end user's device timezone as an IANA name (like `Asia/Tokyo`), used as a fallback hint: it applies only when neither `timezone` nor the agent's configured timezone is set, and invalid values are ignored rather than rejected. The Web SDK fills it automatically from the browser for public agents. When your backend creates the session, forward the value from your client.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="context">
        /// Per-session overrides of the agent's context switches (`context.current_time` in the agent config). A switch you leave out follows the agent.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="overrides">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dynamicVariables">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endUserId">
        /// Your identifier for the end user, stored verbatim. Returned on session reads and webhooks, and filterable with `GET /v1/agent/sessions?end_user_id=`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="llmExtraBody">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolEvents">
        /// Default Value: true
        /// </param>
        /// <param name="recordAudio">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionCreatePayload(
            string agentId,
            string? name,
            string? timezone,
            string? clientTimezone,
            global::FishAudio.AgentSessionContextPayload? context,
            global::FishAudio.AgentSessionOverridesPayload? overrides,
            object? dynamicVariables,
            string? endUserId,
            object? metadata,
            object? llmExtraBody,
            bool? toolEvents,
            bool? recordAudio)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name;
            this.Timezone = timezone;
            this.ClientTimezone = clientTimezone;
            this.Context = context;
            this.Overrides = overrides;
            this.DynamicVariables = dynamicVariables;
            this.EndUserId = endUserId;
            this.Metadata = metadata;
            this.LlmExtraBody = llmExtraBody;
            this.ToolEvents = toolEvents;
            this.RecordAudio = recordAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionCreatePayload" /> class.
        /// </summary>
        public AgentSessionCreatePayload()
        {
        }

    }
}