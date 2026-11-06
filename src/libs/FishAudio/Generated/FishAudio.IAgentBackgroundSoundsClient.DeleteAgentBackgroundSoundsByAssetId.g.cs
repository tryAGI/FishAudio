#nullable enable

namespace FishAudio
{
    public partial interface IAgentBackgroundSoundsClient
    {
        /// <summary>
        /// Delete Background Sound<br/>
        /// Soft-deletes the clip. An agent still naming it in<br/>
        /// `voice.background_sound.custom_asset_id` falls back to silence for that<br/>
        /// ambience at its next session rather than failing the call.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentBackgroundSoundsByAssetIdAsync(
            string assetId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Background Sound<br/>
        /// Soft-deletes the clip. An agent still naming it in<br/>
        /// `voice.background_sound.custom_asset_id` falls back to silence for that<br/>
        /// ambience at its next session rather than failing the call.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeleteAgentBackgroundSoundsByAssetIdAsResponseAsync(
            string assetId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}