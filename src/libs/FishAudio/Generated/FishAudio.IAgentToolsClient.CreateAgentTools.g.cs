#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a workspace tool. `tool_type: webhook` calls your HTTP endpoint<br/>
        /// during conversations; `tool_type: client` is executed by your own frontend<br/>
        /// through the SDK (no URL). Attach it to agents via the agent config's<br/>
        /// `tools.tool_ids`. Credential headers (authorization_bearer /<br/>
        /// authorization_basic) are write-only and read back as `has_secret`.
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
        /// through the SDK (no URL). Attach it to agents via the agent config's<br/>
        /// `tools.tool_ids`. Credential headers (authorization_bearer /<br/>
        /// authorization_basic) are write-only and read back as `has_secret`.
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
        /// through the SDK (no URL). Attach it to agents via the agent config's<br/>
        /// `tools.tool_ids`. Credential headers (authorization_bearer /<br/>
        /// authorization_basic) are write-only and read back as `has_secret`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentToolsResponse> CreateAgentToolsAsync(
            string name,
            string? description = default,
            global::FishAudio.PublicAgentToolCreatePayloadToolType? toolType = default,
            global::System.Collections.Generic.IList<global::FishAudio.AgentWebhookArgumentPayload>? arguments = default,
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