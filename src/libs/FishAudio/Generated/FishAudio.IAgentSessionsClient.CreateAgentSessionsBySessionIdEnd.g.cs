#nullable enable

namespace FishAudio
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// End Agent Session<br/>
        /// Hang up a live session: the agent disconnects and the call terminates. The<br/>
        /// session record, transcript, and recording are retained and stay readable.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/sessions/&lt;session-id&gt;/end \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task CreateAgentSessionsBySessionIdEndAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End Agent Session<br/>
        /// Hang up a live session: the agent disconnects and the call terminates. The<br/>
        /// session record, transcript, and recording are retained and stay readable.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/agent/sessions/&lt;session-id&gt;/end \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> CreateAgentSessionsBySessionIdEndAsResponseAsync(
            string sessionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}