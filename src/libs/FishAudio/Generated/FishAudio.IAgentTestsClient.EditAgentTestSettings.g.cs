#nullable enable

namespace FishAudio
{
    public partial interface IAgentTestsClient
    {
        /// <summary>
        /// Update Test Settings<br/>
        /// Change the Tests settings of a workspace. Only the fields you send<br/>
        /// change. A test run picks its judge when it starts, so runs already<br/>
        /// started keep the judge they started with.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentTestSettingsResponse> EditAgentTestSettingsAsync(

            global::FishAudio.AgentTestSettingsPatch request,
            string? workspaceId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test Settings<br/>
        /// Change the Tests settings of a workspace. Only the fields you send<br/>
        /// change. A test run picks its judge when it starts, so runs already<br/>
        /// started keep the judge they started with.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchAgentTestSettingsResponse>> EditAgentTestSettingsAsResponseAsync(

            global::FishAudio.AgentTestSettingsPatch request,
            string? workspaceId = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test Settings<br/>
        /// Change the Tests settings of a workspace. Only the fields you send<br/>
        /// change. A test run picks its judge when it starts, so runs already<br/>
        /// started keep the judge they started with.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="judge">
        /// Null goes back to the platform default. Left out, unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchAgentTestSettingsResponse> EditAgentTestSettingsAsync(
            string? workspaceId = default,
            global::FishAudio.AgentTestJudge? judge = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}