#nullable enable

namespace FishAudio
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Delete (archive) a version<br/>
        /// Soft-archive a historical version. The latest version cannot be deleted (409), and deleting an already archived version also returns 409.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePronunciationDictionariesByDictionaryIdVersionsByVersionIdAsync(
            string dictionaryId,
            string versionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete (archive) a version<br/>
        /// Soft-archive a historical version. The latest version cannot be deleted (409), and deleting an already archived version also returns 409.
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::FishAudio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::FishAudio.AutoSDKHttpResponse> DeletePronunciationDictionariesByDictionaryIdVersionsByVersionIdAsResponseAsync(
            string dictionaryId,
            string versionId,
            global::FishAudio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}