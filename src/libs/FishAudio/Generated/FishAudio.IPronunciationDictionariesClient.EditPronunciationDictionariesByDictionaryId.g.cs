#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Update a pronunciation dictionary<br/>
        /// Change the dictionary's name or description. Rules live in published versions and are not editable in place.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchPronunciationDictionariesResponse> EditPronunciationDictionariesByDictionaryIdAsync(
            string dictionaryId,

            global::FishAudio.PronunciationDictionaryUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary<br/>
        /// Change the dictionary's name or description. Rules live in published versions and are not editable in place.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse<global::FishAudio.PatchPronunciationDictionariesResponse>> EditPronunciationDictionariesByDictionaryIdAsResponseAsync(
            string dictionaryId,

            global::FishAudio.PronunciationDictionaryUpdatePayload request,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary<br/>
        /// Change the dictionary's name or description. Rules live in published versions and are not editable in place.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="name">
        /// New display name; omitted or null leaves it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// New description; omitted or null leaves it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.PatchPronunciationDictionariesResponse> EditPronunciationDictionariesByDictionaryIdAsync(
            string dictionaryId,
            string? name = default,
            string? description = default,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}