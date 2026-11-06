#nullable enable

namespace FishAudio
{
    public partial interface IAgentBackgroundSoundsClient
    {
        /// <summary>
        /// List Background Sounds<br/>
        /// List your team's uploaded background-ambience clips, newest first.<br/>
        /// Select one with `voice.background_sound.custom_asset_id` (preset<br/>
        /// `custom`) on an agent's config.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.GetAgentBackgroundSoundsResponse> GetAgentBackgroundSoundsAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Background Sounds<br/>
        /// List your team's uploaded background-ambience clips, newest first.<br/>
        /// Select one with `voice.background_sound.custom_asset_id` (preset<br/>
        /// `custom`) on an agent's config.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.GetAgentBackgroundSoundsResponse>> GetAgentBackgroundSoundsAsResponseAsync(
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}