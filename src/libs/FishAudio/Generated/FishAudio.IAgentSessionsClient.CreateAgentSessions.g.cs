#nullable enable

namespace FishAudio
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Create Agent Session<br/>
        /// Start a conversation session with an agent and receive a join token for the<br/>
        /// session transport (currently LiveKit WebRTC). Authenticate with an API key to<br/>
        /// start sessions with any agent in your team; without credentials only agents<br/>
        /// published as public are reachable, and the request `Origin` must match the<br/>
        /// agent's allowed origins.<br/>
        /// `language` (and `overrides.language`) accepts `en`, `ja`, `zh`, `ko`, `es`,<br/>
        /// `fr`, `de`; anything else is 422. Omit it to use the agent's configured<br/>
        /// behavior (including automatic language detection when enabled).
        /// </summary>
        /// <param name="origin">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/sessions \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "agent_id": "&lt;agent-id&gt;"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentSessionsResponse> CreateAgentSessionsAsync(

            global::FishAudio.AgentSessionCreatePayload request,
            string? origin = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Session<br/>
        /// Start a conversation session with an agent and receive a join token for the<br/>
        /// session transport (currently LiveKit WebRTC). Authenticate with an API key to<br/>
        /// start sessions with any agent in your team; without credentials only agents<br/>
        /// published as public are reachable, and the request `Origin` must match the<br/>
        /// agent's allowed origins.<br/>
        /// `language` (and `overrides.language`) accepts `en`, `ja`, `zh`, `ko`, `es`,<br/>
        /// `fr`, `de`; anything else is 422. Omit it to use the agent's configured<br/>
        /// behavior (including automatic language detection when enabled).
        /// </summary>
        /// <param name="origin">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/sessions \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "agent_id": "&lt;agent-id&gt;"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentSessionsResponse>> CreateAgentSessionsAsResponseAsync(

            global::FishAudio.AgentSessionCreatePayload request,
            string? origin = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Session<br/>
        /// Start a conversation session with an agent and receive a join token for the<br/>
        /// session transport (currently LiveKit WebRTC). Authenticate with an API key to<br/>
        /// start sessions with any agent in your team; without credentials only agents<br/>
        /// published as public are reachable, and the request `Origin` must match the<br/>
        /// agent's allowed origins.<br/>
        /// `language` (and `overrides.language`) accepts `en`, `ja`, `zh`, `ko`, `es`,<br/>
        /// `fr`, `de`; anything else is 422. Omit it to use the agent's configured<br/>
        /// behavior (including automatic language detection when enabled).
        /// </summary>
        /// <param name="origin">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="timezone">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientTimezone">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="worldContext">
        /// Default Value: true
        /// </param>
        /// <param name="overrides">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dynamicVariables">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endUserId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolEvents">
        /// Default Value: true
        /// </param>
        /// <param name="recordAudio">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentSessionsResponse> CreateAgentSessionsAsync(
            string agentId,
            string? origin = default,
            string? name = default,
            global::FishAudio.AgentSessionCreatePayloadLanguage2? language = default,
            string? timezone = default,
            string? clientTimezone = default,
            bool? worldContext = default,
            global::FishAudio.AgentSessionOverridesPayload? overrides = default,
            object? dynamicVariables = default,
            string? endUserId = default,
            object? metadata = default,
            bool? toolEvents = default,
            bool? recordAudio = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}