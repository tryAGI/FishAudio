#nullable enable

namespace FishAudio
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Get Agent Session<br/>
        /// Fetch one session's full detail: status, timing, and the conversation<br/>
        /// timeline (transcript turns interleaved with tool calls, in order).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentSessionsResponse4> GetAgentSessionsBySessionIdAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Session<br/>
        /// Fetch one session's full detail: status, timing, and the conversation<br/>
        /// timeline (transcript turns interleaved with tool calls, in order).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentSessionsResponse4>> GetAgentSessionsBySessionIdAsResponseAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}