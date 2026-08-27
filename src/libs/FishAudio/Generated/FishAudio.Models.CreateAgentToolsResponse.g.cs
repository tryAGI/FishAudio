
#nullable enable

namespace FishAudio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentToolsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.CreateAgentToolsResponseToolType ToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.CreateAgentToolsResponseMethod Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// How many agents reference this tool in their draft configuration.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        public int? UsedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_template")]
        public string? BodyTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeoutSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_handling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseErrorHandlingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::FishAudio.CreateAgentToolsResponseErrorHandling ErrorHandling { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::FishAudio.JsonConverters.CreateAgentToolsResponseExecutionModeJsonConverter))]
        public global::FishAudio.CreateAgentToolsResponseExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolsResponse" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="toolType"></param>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="contentType"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="errorHandling"></param>
        /// <param name="description"></param>
        /// <param name="usedBy">
        /// How many agents reference this tool in their draft configuration.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="arguments"></param>
        /// <param name="bodyTemplate"></param>
        /// <param name="headers"></param>
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
        public CreateAgentToolsResponse(
            string toolId,
            string workspaceId,
            string name,
            global::FishAudio.CreateAgentToolsResponseToolType toolType,
            global::FishAudio.CreateAgentToolsResponseMethod method,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string contentType,
            int timeoutSeconds,
            global::FishAudio.CreateAgentToolsResponseErrorHandling errorHandling,
            string? description,
            int? usedBy,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? arguments,
            string? bodyTemplate,
            global::System.Collections.Generic.IList<global::FishAudio.PublicToolHeader>? headers,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? mockResponses,
            bool? expectsResponse,
            global::FishAudio.CreateAgentToolsResponseExecutionMode? executionMode)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ToolType = toolType;
            this.Method = method;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UsedBy = usedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Arguments = arguments;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.BodyTemplate = bodyTemplate;
            this.Headers = headers;
            this.TimeoutSeconds = timeoutSeconds;
            this.ErrorHandling = errorHandling;
            this.MockResponses = mockResponses;
            this.ExpectsResponse = expectsResponse;
            this.ExecutionMode = executionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolsResponse" /> class.
        /// </summary>
        public CreateAgentToolsResponse()
        {
        }

    }
}