#nullable enable

namespace FishAudio
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Create Model for Users via API
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateModelResponse> CreateModelAsync(

            global::FishAudio.CreateModelRequest request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model for Users via API
        /// </summary>
        /// <param name="visibility">
        /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
        /// Default Value: public
        /// </param>
        /// <param name="type">
        /// Model type, tts is for text to speech
        /// </param>
        /// <param name="title">
        /// Model title or name
        /// </param>
        /// <param name="description">
        /// Model description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImage">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImagename">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trainMode">
        /// Model train mode, for TTS model, fast means model instantly available after creation
        /// </param>
        /// <param name="voices">
        /// Upload voices files that will be used to tune the model
        /// </param>
        /// <param name="texts">
        /// Texts corresponding to the voices, if unspecified, ASR will be performed on the voices<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tags">
        /// Model tags
        /// </param>
        /// <param name="enhanceAudioQuality">
        /// Enhance audio quality<br/>
        /// Default Value: true
        /// </param>
        /// <param name="generateSample">
        /// Generate default text<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreateModelResponse> CreateModelAsync(
            string title,
            global::FishAudio.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]> voices,
            global::FishAudio.CreateModelRequestVisibility? visibility = default,
            string type = "tts",
            string? description = default,
            byte[]? coverImage = default,
            string? coverImagename = default,
            string trainMode = "fast",
            global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? texts = default,
            global::FishAudio.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? tags = default,
            bool? enhanceAudioQuality = default,
            bool? generateSample = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}