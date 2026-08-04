#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Publish Agent<br/>
        /// Freeze the current draft into an immutable version (version_number<br/>
        /// auto-increments) and make it the live configuration for new sessions. The<br/>
        /// body is optional; the title and description label the version for audit<br/>
        /// and rollback.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/publish \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "version_title": "Tighter greeting"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsPublishResponse> CreateAgentAgentsByAgentIdPublishAsync(
            string agentId,

            global::FishAudio.CreateAgentAgentsPublishRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Agent<br/>
        /// Freeze the current draft into an immutable version (version_number<br/>
        /// auto-increments) and make it the live configuration for new sessions. The<br/>
        /// body is optional; the title and description label the version for audit<br/>
        /// and rollback.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/agents/&lt;agent-id&gt;/publish \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{<br/>
        ///     "version_title": "Tighter greeting"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentAgentsPublishResponse>> CreateAgentAgentsByAgentIdPublishAsResponseAsync(
            string agentId,

            global::FishAudio.CreateAgentAgentsPublishRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Agent<br/>
        /// Freeze the current draft into an immutable version (version_number<br/>
        /// auto-increments) and make it the live configuration for new sessions. The<br/>
        /// body is optional; the title and description label the version for audit<br/>
        /// and rollback.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionTitle">
        /// Optional label shown in the version history.
        /// </param>
        /// <param name="versionDescription">
        /// Optional longer note for audit and rollback context.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsPublishResponse> CreateAgentAgentsByAgentIdPublishAsync(
            string agentId,
            string? versionTitle = default,
            string? versionDescription = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}