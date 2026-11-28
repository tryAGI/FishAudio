#nullable enable

namespace FishAudio
{
    public partial interface IAgentToolsClient
    {
        /// <summary>
        /// Revoke Previous Tool Signing Secret<br/>
        /// End a rotation window now. Only the current secret signs from the next<br/>
        /// session on.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.DeleteAgentToolsSigningSecretPreviousResponse> DeleteAgentToolsByToolIdSigningSecretPreviousAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Previous Tool Signing Secret<br/>
        /// End a rotation window now. Only the current secret signs from the next<br/>
        /// session on.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.DeleteAgentToolsSigningSecretPreviousResponse>> DeleteAgentToolsByToolIdSigningSecretPreviousAsResponseAsync(
            string toolId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}