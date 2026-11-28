#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Get Test Settings<br/>
        /// Get the Tests settings of a workspace, the defaults every test in it<br/>
        /// uses unless the test sets its own. `judge` judges the Single Turn and<br/>
        /// Simulation tests without a `judge` of their own.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentTestSettingsResponse> GetAgentTestSettingsAsync(
            string? workspaceId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Test Settings<br/>
        /// Get the Tests settings of a workspace, the defaults every test in it<br/>
        /// uses unless the test sets its own. `judge` judges the Single Turn and<br/>
        /// Simulation tests without a `judge` of their own.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentTestSettingsResponse>> GetAgentTestSettingsAsResponseAsync(
            string? workspaceId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}