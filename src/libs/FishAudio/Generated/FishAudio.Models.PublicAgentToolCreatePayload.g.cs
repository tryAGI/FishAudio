
#nullable enable

namespace FishAudio
{
    /// <summary>
    /// Console payload minus the folder concept (folders are console-only).
    /// </summary>
    public sealed partial class PublicAgentToolCreatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadToolTypeJsonConverter))]
        public global::FishAudio.PublicAgentToolCreatePayloadToolType? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Arguments { get; set; }

        /// <summary>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadMethodJsonConverter))]
        public global::FishAudio.PublicAgentToolCreatePayloadMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Default Value: application/json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_template")]
        public string? BodyTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? Headers { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Default Value: passthrough
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_handling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadErrorHandlingJsonConverter))]
        public global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? ErrorHandling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_responses")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? MockResponses { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// Default Value: blocking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.PublicAgentToolCreatePayloadExecutionModeJsonConverter))]
        public global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentToolCreatePayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="toolType">
        /// Default Value: webhook
        /// </param>
        /// <param name="arguments"></param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
        /// <param name="url"></param>
        /// <param name="contentType">
        /// Default Value: application/json
        /// </param>
        /// <param name="bodyTemplate"></param>
        /// <param name="headers"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: 30
        /// </param>
        /// <param name="errorHandling">
        /// Default Value: passthrough
        /// </param>
        /// <param name="mockResponses"></param>
        /// <param name="expectsResponse">
        /// Default Value: true
        /// </param>
        /// <param name="executionMode">
        /// Default Value: blocking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentToolCreatePayload(
            string name,
            string? description,
            global::FishAudio.PublicAgentToolCreatePayloadToolType? toolType,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? arguments,
            global::FishAudio.PublicAgentToolCreatePayloadMethod? method,
            string? url,
            string? contentType,
            string? bodyTemplate,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? headers,
            int? timeoutSeconds,
            global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? errorHandling,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? mockResponses,
            bool? expectsResponse,
            global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? executionMode)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ToolType = toolType;
            this.Arguments = arguments;
            this.Method = method;
            this.Url = url;
            this.ContentType = contentType;
            this.BodyTemplate = bodyTemplate;
            this.Headers = headers;
            this.TimeoutSeconds = timeoutSeconds;
            this.ErrorHandling = errorHandling;
            this.MockResponses = mockResponses;
            this.ExpectsResponse = expectsResponse;
            this.ExecutionMode = executionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentToolCreatePayload" /> class.
        /// </summary>
        public PublicAgentToolCreatePayload()
        {
        }

    }
}