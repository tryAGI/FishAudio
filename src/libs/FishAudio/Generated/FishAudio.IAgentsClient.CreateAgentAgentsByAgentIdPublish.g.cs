#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Publish Agent<br/>
        /// Freeze the current draft into an immutable version and make it the live<br/>
        /// configuration for new sessions. Each new version gets the next<br/>
        /// version_number. If the draft already matches the live version, no version<br/>
        /// is created and the live version comes back with `created: false`.<br/>
        /// The response describes what was published:<br/>
        /// - `version_number` and `config_hash` identify the version.<br/>
        /// - `config` is the configuration exactly as published. Check your<br/>
        ///   read-back against it, not against the request you sent.<br/>
        /// - `created` tells whether this call made a new version.<br/>
        /// Publishing copies the draft as it is stored. It does not change any field.<br/>
        /// Writes do normalize some values, see Update Draft Config.<br/>
        /// The body is optional:<br/>
        /// - `expected_config_hash` publishes only while the draft still has that<br/>
        ///   config_hash. Take it from Get Draft Config or Update Draft Config. On a<br/>
        ///   mismatch the call returns 409 with `reason: "draft_changed"` and the<br/>
        ///   draft's current `config_hash`. Nothing is written.<br/>
        /// - `config` applies draft changes first, in the same shape as Update Draft<br/>
        ///   Config. The changes and the publish are one atomic step. If either fails,<br/>
        ///   the draft stays as it was.<br/>
        /// - With both, `expected_config_hash` is checked against the draft before<br/>
        ///   `config` is applied.<br/>
        /// - `version_title` and `version_description` label a new version.
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
        /// Freeze the current draft into an immutable version and make it the live<br/>
        /// configuration for new sessions. Each new version gets the next<br/>
        /// version_number. If the draft already matches the live version, no version<br/>
        /// is created and the live version comes back with `created: false`.<br/>
        /// The response describes what was published:<br/>
        /// - `version_number` and `config_hash` identify the version.<br/>
        /// - `config` is the configuration exactly as published. Check your<br/>
        ///   read-back against it, not against the request you sent.<br/>
        /// - `created` tells whether this call made a new version.<br/>
        /// Publishing copies the draft as it is stored. It does not change any field.<br/>
        /// Writes do normalize some values, see Update Draft Config.<br/>
        /// The body is optional:<br/>
        /// - `expected_config_hash` publishes only while the draft still has that<br/>
        ///   config_hash. Take it from Get Draft Config or Update Draft Config. On a<br/>
        ///   mismatch the call returns 409 with `reason: "draft_changed"` and the<br/>
        ///   draft's current `config_hash`. Nothing is written.<br/>
        /// - `config` applies draft changes first, in the same shape as Update Draft<br/>
        ///   Config. The changes and the publish are one atomic step. If either fails,<br/>
        ///   the draft stays as it was.<br/>
        /// - With both, `expected_config_hash` is checked against the draft before<br/>
        ///   `config` is applied.<br/>
        /// - `version_title` and `version_description` label a new version.
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
        /// Freeze the current draft into an immutable version and make it the live<br/>
        /// configuration for new sessions. Each new version gets the next<br/>
        /// version_number. If the draft already matches the live version, no version<br/>
        /// is created and the live version comes back with `created: false`.<br/>
        /// The response describes what was published:<br/>
        /// - `version_number` and `config_hash` identify the version.<br/>
        /// - `config` is the configuration exactly as published. Check your<br/>
        ///   read-back against it, not against the request you sent.<br/>
        /// - `created` tells whether this call made a new version.<br/>
        /// Publishing copies the draft as it is stored. It does not change any field.<br/>
        /// Writes do normalize some values, see Update Draft Config.<br/>
        /// The body is optional:<br/>
        /// - `expected_config_hash` publishes only while the draft still has that<br/>
        ///   config_hash. Take it from Get Draft Config or Update Draft Config. On a<br/>
        ///   mismatch the call returns 409 with `reason: "draft_changed"` and the<br/>
        ///   draft's current `config_hash`. Nothing is written.<br/>
        /// - `config` applies draft changes first, in the same shape as Update Draft<br/>
        ///   Config. The changes and the publish are one atomic step. If either fails,<br/>
        ///   the draft stays as it was.<br/>
        /// - With both, `expected_config_hash` is checked against the draft before<br/>
        ///   `config` is applied.<br/>
        /// - `version_title` and `version_description` label a new version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionTitle">
        /// Optional label shown in the version history.
        /// </param>
        /// <param name="versionDescription">
        /// Optional longer note for audit and rollback context.
        /// </param>
        /// <param name="expectedConfigHash">
        /// Publish only while the draft has this config_hash. Otherwise 409 with reason `draft_changed` and nothing is written.
        /// </param>
        /// <param name="config">
        /// Draft changes to apply before publishing, same shape as Update Draft Config. The write and the publish succeed or fail together.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentAgentsPublishResponse> CreateAgentAgentsByAgentIdPublishAsync(
            string agentId,
            string? versionTitle = default,
            string? versionDescription = default,
            string? expectedConfigHash = default,
            global::FishAudio.PublicAgentConfigPatchPayload? config = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}