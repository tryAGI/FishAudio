#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a workspace tool. `tool_type: webhook` calls your HTTP endpoint<br/>
        /// during conversations; `tool_type: client` is executed by your own frontend<br/>
        /// through the SDK (no URL). Describe the call with `parameters` (a JSON<br/>
        /// Schema object, checked at call time under `parameter_mode: strict`) or<br/>
        /// the older `arguments` list (every argument a required string, unchecked).<br/>
        /// Attach it to agents via the agent config's `tools.tool_ids`. Credential<br/>
        /// headers (authorization_bearer / authorization_basic) are write-only and<br/>
        /// read back as `has_secret`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/tools \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Book appointment",<br/>
        ///     "description": "Creates an appointment in the scheduling system.",<br/>
        ///     "method": "POST",<br/>
        ///     "url": "https://api.example.com/appointments",<br/>
        ///     "arguments": [<br/>
        ///       {"name": "date", "description": "Appointment date, YYYY-MM-DD"}<br/>
        ///     ],<br/>
        ///     "body_template": "{\"date\": \"{{date}}\"}",<br/>
        ///     "headers": [<br/>
        ///       {"name": "Authorization", "value": "Bearer &lt;api-token&gt;", "kind": "authorization_bearer"}<br/>
        ///     ]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentToolsResponse> CreateAgentToolsAsync(

            global::FishAudio.PublicAgentToolCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a workspace tool. `tool_type: webhook` calls your HTTP endpoint<br/>
        /// during conversations; `tool_type: client` is executed by your own frontend<br/>
        /// through the SDK (no URL). Describe the call with `parameters` (a JSON<br/>
        /// Schema object, checked at call time under `parameter_mode: strict`) or<br/>
        /// the older `arguments` list (every argument a required string, unchecked).<br/>
        /// Attach it to agents via the agent config's `tools.tool_ids`. Credential<br/>
        /// headers (authorization_bearer / authorization_basic) are write-only and<br/>
        /// read back as `has_secret`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/tools \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Book appointment",<br/>
        ///     "description": "Creates an appointment in the scheduling system.",<br/>
        ///     "method": "POST",<br/>
        ///     "url": "https://api.example.com/appointments",<br/>
        ///     "arguments": [<br/>
        ///       {"name": "date", "description": "Appointment date, YYYY-MM-DD"}<br/>
        ///     ],<br/>
        ///     "body_template": "{\"date\": \"{{date}}\"}",<br/>
        ///     "headers": [<br/>
        ///       {"name": "Authorization", "value": "Bearer &lt;api-token&gt;", "kind": "authorization_bearer"}<br/>
        ///     ]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentToolsResponse>> CreateAgentToolsAsResponseAsync(

            global::FishAudio.PublicAgentToolCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a workspace tool. `tool_type: webhook` calls your HTTP endpoint<br/>
        /// during conversations; `tool_type: client` is executed by your own frontend<br/>
        /// through the SDK (no URL). Describe the call with `parameters` (a JSON<br/>
        /// Schema object, checked at call time under `parameter_mode: strict`) or<br/>
        /// the older `arguments` list (every argument a required string, unchecked).<br/>
        /// Attach it to agents via the agent config's `tools.tool_ids`. Credential<br/>
        /// headers (authorization_bearer / authorization_basic) are write-only and<br/>
        /// read back as `has_secret`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentToolsResponse> CreateAgentToolsAsync(
            string name,
            string? description = default,
            global::FishAudio.PublicAgentToolCreatePayloadToolType? toolType = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? arguments = default,
            object? parameters = default,
            global::FishAudio.PublicAgentToolCreatePayloadParameterMode? parameterMode = default,
            global::FishAudio.PublicAgentToolCreatePayloadMethod? method = default,
            string? url = default,
            string? contentType = default,
            string? bodyTemplate = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookHeaderPayload>? headers = default,
            int? timeoutSeconds = default,
            global::FishAudio.PublicAgentToolCreatePayloadErrorHandling? errorHandling = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookMockResponsePayload>? mockResponses = default,
            bool? expectsResponse = default,
            global::FishAudio.PublicAgentToolCreatePayloadExecutionMode? executionMode = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}