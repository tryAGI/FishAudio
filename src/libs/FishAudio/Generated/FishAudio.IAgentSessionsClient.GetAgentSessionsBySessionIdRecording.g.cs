#nullable enable

namespace FishAudio
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Get Agent Session Recording<br/>
        /// Return time-limited download URLs for the session's audio recording, one<br/>
        /// per speaker track (agent and user are recorded separately).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentSessionsRecordingResponse> GetAgentSessionsBySessionIdRecordingAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Session Recording<br/>
        /// Return time-limited download URLs for the session's audio recording, one<br/>
        /// per speaker track (agent and user are recorded separately).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentSessionsRecordingResponse>> GetAgentSessionsBySessionIdRecordingAsResponseAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}