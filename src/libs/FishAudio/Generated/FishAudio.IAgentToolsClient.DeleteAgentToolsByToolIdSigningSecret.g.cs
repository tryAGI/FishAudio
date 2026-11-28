#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Disable Tool Signing<br/>
        /// Stop signing this tool's requests and delete its secrets.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.DeleteAgentToolsSigningSecretResponse> DeleteAgentToolsByToolIdSigningSecretAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disable Tool Signing<br/>
        /// Stop signing this tool's requests and delete its secrets.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.DeleteAgentToolsSigningSecretResponse>> DeleteAgentToolsByToolIdSigningSecretAsResponseAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}