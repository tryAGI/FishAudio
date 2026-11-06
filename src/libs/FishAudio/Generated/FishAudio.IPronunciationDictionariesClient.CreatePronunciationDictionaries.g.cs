#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Create a pronunciation dictionary<br/>
        /// Create an empty dictionary for the team the credential belongs to (the API key's team, or the personal team for a session without x-team-id). Publish rules with POST /versions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreatePronunciationDictionariesResponse> CreatePronunciationDictionariesAsync(

            global::FishAudio.PronunciationDictionaryCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pronunciation dictionary<br/>
        /// Create an empty dictionary for the team the credential belongs to (the API key's team, or the personal team for a session without x-team-id). Publish rules with POST /versions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.CreatePronunciationDictionariesResponse>> CreatePronunciationDictionariesAsResponseAsync(

            global::FishAudio.PronunciationDictionaryCreatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pronunciation dictionary<br/>
        /// Create an empty dictionary for the team the credential belongs to (the API key's team, or the personal team for a session without x-team-id). Publish rules with POST /versions.
        /// </summary>
        /// <param name="name">
        /// Display name for the dictionary (1-128 characters).
        /// </param>
        /// <param name="description">
        /// Optional free-form description (up to 1024 characters).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.CreatePronunciationDictionariesResponse> CreatePronunciationDictionariesAsync(
            string name,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}