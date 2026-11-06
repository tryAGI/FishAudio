#nullable enable

namespace FishAudio
{
    public partial interface IAgentBackgroundSoundsClient
    {
        /// <summary>
        /// Create Background Sound<br/>
        /// Upload an mp3/wav/ogg/m4a clip, up to 10 MB and 300 seconds. Send<br/>
        /// `multipart/form-data` with the file in `file`. The server loudness-<br/>
        /// normalizes and transcodes it to Ogg/Opus; the returned id is what<br/>
        /// `voice.background_sound.custom_asset_id` names.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentBackgroundSoundsResponse> CreateAgentBackgroundSoundsAsync(

            global::FishAudio.CreateAgentBackgroundSoundsRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Background Sound<br/>
        /// Upload an mp3/wav/ogg/m4a clip, up to 10 MB and 300 seconds. Send<br/>
        /// `multipart/form-data` with the file in `file`. The server loudness-<br/>
        /// normalizes and transcodes it to Ogg/Opus; the returned id is what<br/>
        /// `voice.background_sound.custom_asset_id` names.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentBackgroundSoundsResponse>> CreateAgentBackgroundSoundsAsResponseAsync(

            global::FishAudio.CreateAgentBackgroundSoundsRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Background Sound<br/>
        /// Upload an mp3/wav/ogg/m4a clip, up to 10 MB and 300 seconds. Send<br/>
        /// `multipart/form-data` with the file in `file`. The server loudness-<br/>
        /// normalizes and transcodes it to Ogg/Opus; the returned id is what<br/>
        /// `voice.background_sound.custom_asset_id` names.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentBackgroundSoundsResponse> CreateAgentBackgroundSoundsAsync(
            byte[] file,
            string filename,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Background Sound<br/>
        /// Upload an mp3/wav/ogg/m4a clip, up to 10 MB and 300 seconds. Send<br/>
        /// `multipart/form-data` with the file in `file`. The server loudness-<br/>
        /// normalizes and transcodes it to Ogg/Opus; the returned id is what<br/>
        /// `voice.background_sound.custom_asset_id` names.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateAgentBackgroundSoundsResponse> CreateAgentBackgroundSoundsAsync(
            global::System.IO.Stream file,
            string filename,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Background Sound<br/>
        /// Upload an mp3/wav/ogg/m4a clip, up to 10 MB and 300 seconds. Send<br/>
        /// `multipart/form-data` with the file in `file`. The server loudness-<br/>
        /// normalizes and transcodes it to Ogg/Opus; the returned id is what<br/>
        /// `voice.background_sound.custom_asset_id` names.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreateAgentBackgroundSoundsResponse>> CreateAgentBackgroundSoundsAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}