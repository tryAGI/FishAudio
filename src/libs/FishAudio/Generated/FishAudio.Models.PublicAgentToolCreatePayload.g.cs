
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
        /// Older shape of `parameters`: each entry becomes a required string parameter. Mutually exclusive with `parameters` in one request. Reads return both, `arguments` being the string parameters of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? Arguments { get; set; }

        /// <summary>
        /// Call parameters as a JSON Schema object (draft 2020-12): `type: object` (filled in when omitted), `properties`, `required`. Standard meaning throughout: `required` means the key must be present, `type: ["string", "null"]` allows null, `minLength: 1` makes a string non-empty, `enum` and `pattern` constrain the value, `default` fills a key the model left out. Mutually exclusive with `arguments` in one request. A tool created with `parameters` starts in `parameter_mode: strict`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Whether the agent runtime checks each call's arguments against `parameters` before running the tool. `legacy` (the default for tools created with `arguments`, and every tool from before this field existed): no check, the model's arguments run as sent. `strict` (the default for tools created with `parameters`): a call that does not satisfy the schema is refused and the model is told to ask the caller for the missing information, and the LLM provider's constrained decoding is turned on where the model supports it (OpenAI models and a custom OpenAI-compatible endpoint receive the tool with `strict: true`, Gemini on the platform's native channel runs validated function calling). Changing `parameters` never changes the mode, and the mode can be changed on its own.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_mode")]
        public global::FishAudio.PublicAgentToolCreatePayloadParameterMode? ParameterMode { get; set; }

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
        /// Request body sent for non-GET calls. `{{argument}}`, `{{system.*}}` and custom session variable placeholders are filled in at call time; a missing value becomes empty. When the body's content type is JSON (the default `application/json`, any `+json` type, or a `Content-Type` header saying so), a placeholder inside a JSON string, such as `{"note": "{{note}}"}`, is JSON-escaped, so quotes, backslashes and newlines in the value keep the body valid JSON. A placeholder outside a string, such as `{"count": {{count}}}`, is inserted as is. Other content types are filled in as is.
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
        /// <param name="arguments">
        /// Older shape of `parameters`: each entry becomes a required string parameter. Mutually exclusive with `parameters` in one request. Reads return both, `arguments` being the string parameters of the schema.
        /// </param>
        /// <param name="parameters">
        /// Call parameters as a JSON Schema object (draft 2020-12): `type: object` (filled in when omitted), `properties`, `required`. Standard meaning throughout: `required` means the key must be present, `type: ["string", "null"]` allows null, `minLength: 1` makes a string non-empty, `enum` and `pattern` constrain the value, `default` fills a key the model left out. Mutually exclusive with `arguments` in one request. A tool created with `parameters` starts in `parameter_mode: strict`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parameterMode">
        /// Whether the agent runtime checks each call's arguments against `parameters` before running the tool. `legacy` (the default for tools created with `arguments`, and every tool from before this field existed): no check, the model's arguments run as sent. `strict` (the default for tools created with `parameters`): a call that does not satisfy the schema is refused and the model is told to ask the caller for the missing information, and the LLM provider's constrained decoding is turned on where the model supports it (OpenAI models and a custom OpenAI-compatible endpoint receive the tool with `strict: true`, Gemini on the platform's native channel runs validated function calling). Changing `parameters` never changes the mode, and the mode can be changed on its own.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
        /// <param name="url"></param>
        /// <param name="contentType">
        /// Default Value: application/json
        /// </param>
        /// <param name="bodyTemplate">
        /// Request body sent for non-GET calls. `{{argument}}`, `{{system.*}}` and custom session variable placeholders are filled in at call time; a missing value becomes empty. When the body's content type is JSON (the default `application/json`, any `+json` type, or a `Content-Type` header saying so), a placeholder inside a JSON string, such as `{"note": "{{note}}"}`, is JSON-escaped, so quotes, backslashes and newlines in the value keep the body valid JSON. A placeholder outside a string, such as `{"count": {{count}}}`, is inserted as is. Other content types are filled in as is.
        /// </param>
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
            object? parameters,
            global::FishAudio.PublicAgentToolCreatePayloadParameterMode? parameterMode,
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
            this.Parameters = parameters;
            this.ParameterMode = parameterMode;
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