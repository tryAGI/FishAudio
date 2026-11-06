#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Delete (archive) a pronunciation dictionary<br/>
        /// Soft-archive the dictionary: it disappears from list/get and can no longer be modified, while its versions remain stored. Idempotent.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePronunciationDictionariesByDictionaryIdAsync(
            string dictionaryId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete (archive) a pronunciation dictionary<br/>
        /// Soft-archive the dictionary: it disappears from list/get and can no longer be modified, while its versions remain stored. Idempotent.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeletePronunciationDictionariesByDictionaryIdAsResponseAsync(
            string dictionaryId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}