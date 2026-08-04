#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent, optionally with its full initial configuration inline —<br/>
        /// one call provisions a ready-to-publish agent. The agent starts as a draft:<br/>
        /// publish it before creating sessions with it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Receptionist",<br/>
        ///     "description": "Handles inbound calls.",<br/>
        ///     "config": {<br/>
        ///       "prompt": {<br/>
        ///         "system_prompt": "You are the receptionist for Fish Dental."<br/>
        ///       },<br/>
        ///       "voice": {<br/>
        ///         "voice_profile_id": "&lt;voice-model-id&gt;",<br/>
        ///         "speaking_language": "en"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsResponse> CreateAgentAgentsAsync(

            global::FishAudio.PublicAgentCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent, optionally with its full initial configuration inline —<br/>
        /// one call provisions a ready-to-publish agent. The agent starts as a draft:<br/>
        /// publish it before creating sessions with it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "name": "Receptionist",<br/>
        ///     "description": "Handles inbound calls.",<br/>
        ///     "config": {<br/>
        ///       "prompt": {<br/>
        ///         "system_prompt": "You are the receptionist for Fish Dental."<br/>
        ///       },<br/>
        ///       "voice": {<br/>
        ///         "voice_profile_id": "&lt;voice-model-id&gt;",<br/>
        ///         "speaking_language": "en"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentAgentsResponse>> CreateAgentAgentsAsResponseAsync(

            global::FishAudio.PublicAgentCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent, optionally with its full initial configuration inline —<br/>
        /// one call provisions a ready-to-publish agent. The agent starts as a draft:<br/>
        /// publish it before creating sessions with it.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Optional initial draft configuration, applied atop the platform defaults; one call provisions a fully configured agent.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsResponse> CreateAgentAgentsAsync(
            string name,
            string? description = default,
            global::FishAudio.PublicAgentConfigPatchPayload? config = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}