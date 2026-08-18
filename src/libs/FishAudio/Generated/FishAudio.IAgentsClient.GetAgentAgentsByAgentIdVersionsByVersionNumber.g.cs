#nullable enable

namespace FishAudio
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Agent Version<br/>
        /// One published version with its full frozen configuration snapshot —<br/>
        /// including the current live version. Secrets inside the snapshot are<br/>
        /// redacted the same way as the draft config.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentAgentsVersionsResponse6> GetAgentAgentsByAgentIdVersionsByVersionNumberAsync(
            string agentId,
            int versionNumber,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Version<br/>
        /// One published version with its full frozen configuration snapshot —<br/>
        /// including the current live version. Secrets inside the snapshot are<br/>
        /// redacted the same way as the draft config.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentAgentsVersionsResponse6>> GetAgentAgentsByAgentIdVersionsByVersionNumberAsResponseAsync(
            string agentId,
            int versionNumber,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}